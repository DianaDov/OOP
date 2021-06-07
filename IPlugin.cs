using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    public interface IPlugin
    {
        public byte GetId();
        public byte[] Encrypt(byte[] data, string key);
        public byte[] Decrypt(byte[] data, string key);

        public string ToString();
    }
}
