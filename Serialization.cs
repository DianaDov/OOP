using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace oop3
{
    public class Serialization
    {
        IPluginCryptography pluginCryptography = new PluginCryptographyProxy();
        public void serializeBinary()
        {
            Form1 form = Form1.GetInstance();
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, form.system);
                File.WriteAllBytes(form.saveFileDialog1.FileName, pluginCryptography.Encrypt(stream.ToArray(), form.encryptForm.keyBox.Text));

            }
        }
        public void serializeXml()
        {
            Form1 form = Form1.GetInstance();
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer formatter = new XmlSerializer(typeof(PlanetSystem));
                formatter.Serialize(stream, form.system);
                File.WriteAllBytes(form.saveFileDialog1.FileName, pluginCryptography.Encrypt(stream.ToArray(), form.encryptForm.keyBox.Text));
            }
        }
        public void serializeText()
        {
            Form1 form = Form1.GetInstance();
            StringBuilder sb = new StringBuilder();
            foreach (AstronomicalObject astronomical in form.system.astronomicalObjects)
            {
                sb.Append(astronomical.GetType() + "|" + astronomical.ToString() + "\n");
            }
            File.WriteAllBytes(form.saveFileDialog1.FileName, pluginCryptography.Encrypt(Encoding.UTF8.GetBytes(sb.ToString()), form.encryptForm.keyBox.Text));
        }
        public void deserializeBinary()
        {
            Form1 form = Form1.GetInstance();
            byte[] data = pluginCryptography.Decrypt(File.ReadAllBytes(form.openFileDialog1.FileName), form.decryptForm.textBox1.Text);
            if (data is null)
            {
                MessageBox.Show("Неизвестный формат шифрования", "Внимание");
                return;
            }
            if (data.Length == 0) return;
            File.WriteAllBytes("temp.bin", data);
            using (FileStream fs = File.OpenRead("temp.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                form.system = (PlanetSystem)formatter.Deserialize(fs);
            }
            File.Delete("temp.bin");
        }
        public void deserializeXml()
        {
            Form1 form = Form1.GetInstance();
            byte[] data = pluginCryptography.Decrypt(File.ReadAllBytes(form.openFileDialog1.FileName), form.decryptForm.textBox1.Text);
            if (data is null)
            {
                MessageBox.Show("Неизвестный формат шифрования", "Внимание");
                return;
            }
            if (data.Length == 0) return;
            File.WriteAllBytes("temp.xml", data);
            using (FileStream fs = File.OpenRead("temp.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(PlanetSystem));
                form.system = (PlanetSystem)formatter.Deserialize(fs);
            }
            File.Delete("temp.xml");
        }

        public void refreshPlugins()
        {
            ((PluginCryptographyProxy)pluginCryptography).refreshPlugins();
        }
        public void deserializeText()
        {
            Form1 form = Form1.GetInstance();
            byte[] data = pluginCryptography.Decrypt(File.ReadAllBytes(form.openFileDialog1.FileName), form.decryptForm.textBox1.Text);
            if (data is null)
            {
                MessageBox.Show("Неизвестный формат шифрования", "Внимание");
                return;
            }
            if (data.Length == 0) return;
            string[] lines = Encoding.UTF8.GetString(data).Split('\n');
            form.system = new PlanetSystem();
            foreach (string line in lines)
            {
                int index = line.IndexOf("|");
                if (index <= 0) continue;
                AstronomicalObject astronomical;
                string s = line.Substring(index + 1);
                switch (line.Substring(0, index))
                {
                    case "oop3.Star":
                        astronomical = new Star(s);
                        break;
                    case "oop3.GasGiant":
                        astronomical = new GasGiant(s);
                        break;
                    case "oop3.Comet":
                        astronomical = new Comet(s);
                        break;
                    case "oop3.Planet":
                    default:
                        astronomical = new Planet(s);
                        break;
                }
                form.system.Add(astronomical);
            }
        }
    }
}
