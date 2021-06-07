using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3
{
    class PluginCryptography : IPluginCryptography
    {
        public List<IPlugin> plugins = new List<IPlugin>();
        public byte[] Encrypt(byte[] data, string key)
        {
            EncryptForm encryptForm = Form1.GetInstance().encryptForm;
            if (encryptForm.comboBox1.SelectedIndex == 0)
            {
                byte[] keyBytes = new byte[data.Length + 1];
                data.CopyTo(keyBytes, 0);
                keyBytes[data.Length] = 0; 
                return keyBytes;
            }
            IPlugin chosenPlugin = null;
            foreach (var plugin in plugins)
            {
                if (plugin.ToString() == encryptForm.comboBox1.SelectedItem.ToString())
                {
                    chosenPlugin = plugin;
                }
            }
            if (chosenPlugin is null) return null;
            byte[] text = chosenPlugin.Encrypt(data, key);
            byte[] bytes = new byte[text.Length + 1];
            text.CopyTo(bytes, 0);
            bytes[bytes.Length - 1] = chosenPlugin.GetId();
            return bytes;
        }
        public byte[] Decrypt(byte[] data, string key)
        {
            if (data[data.Length - 1] == 0) return data;
            IPlugin chosenPlugin = null;
            foreach (IPlugin plugin in plugins)
            {
                if (plugin.GetId() == data[data.Length - 1])
                {
                    chosenPlugin = plugin;
                }
            }
            if (chosenPlugin is null) return null;
            byte[] bytes = new byte[data.Length - 1];
            Array.Copy(data, bytes, bytes.Length);

            try
            {
                return chosenPlugin.Decrypt(bytes, key);
            }
            catch (Exception e)
            {
                MessageBox.Show("Проверьте введенный ключ", "Произошла ошибка");
            }
            return new byte[0];
        }
    }
}
