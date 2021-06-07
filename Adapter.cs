using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class Adapter : IPlugin
    {
        private CryptoPlugin.IPlugin _plugin;
        public byte[] Decrypt(byte[] data, string key)
        {
            byte[] bytes = new byte[16];
            Encoding.UTF8.GetBytes(key).CopyTo(bytes, 0);
            return _plugin.Decrypt(data, bytes);
        }

        public byte[] Encrypt(byte[] data, string key)
        {
            byte[] bytes = new byte[16];
            Encoding.UTF8.GetBytes(key).CopyTo(bytes, 0);
            return _plugin.Encrypt(data, bytes);
        }

        public byte GetId()
        {
            return _plugin.GetId();
        }

        public override string ToString()
        {
            return _plugin.GetType().Name;
        }

        public Adapter(CryptoPlugin.IPlugin plugin)
        {
            _plugin = plugin;
        }
    }
}
