using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class PluginCryptographyProxy : IPluginCryptography
    {
        private PluginCryptography _subject = new PluginCryptography();

        public PluginCryptographyProxy()
        {

        }

        public byte[] Encrypt(byte[] data, string key)
        {
            refreshPlugins();
            return _subject.Encrypt(data, key);
        }
        public byte[] Decrypt(byte[] data, string key)
        {
            refreshPlugins();
            return _subject.Decrypt(data, key);
        }
        public void refreshPlugins()
        {
            _subject.plugins.Clear();
            DirectoryInfo pluginDirectory = new DirectoryInfo("plugins");
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();


            var pluginFiles = Directory.GetFiles("plugins", "*.dll");
            foreach (var file in pluginFiles)
            {

                Assembly asm = Assembly.LoadFrom(file);
                var types = asm.GetTypes().
                                Where(t => t.GetInterfaces().
                                Where(i => i.FullName == typeof(CryptoPlugin.IPlugin).FullName).Any());


                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as CryptoPlugin.IPlugin;
                    _subject.plugins.Add(new Adapter(plugin));
                }
            }
            EncryptForm encryptForm = Form1.GetInstance().encryptForm;
            if (encryptForm != null) foreach (IPlugin plugin in _subject.plugins)
            {
                encryptForm.comboBox1.Items.Add(plugin.ToString());
            }

        }
    }
}
