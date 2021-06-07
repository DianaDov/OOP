using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    public interface IPluginCryptography
    {
        public byte[] Decrypt(byte[] data, string key);
        public byte[] Encrypt(byte[] data, string key);
    }
}
