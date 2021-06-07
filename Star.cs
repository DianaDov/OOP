using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    public enum StarClass
    {
        O,
        B,
        A,
        F,
        G,
        K,
        M
    }
    [Serializable]
    public class Star: Planet
    {
        public StarClass starClass;
        private double _temperature;
        public double Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Temperature");
                _temperature = value;
            }
        }
        public Star(string s) : base(s) {
            string[] strings = s.Split('|');
            starClass = (StarClass) Enum.Parse(typeof(StarClass), strings[9]);
            Temperature = double.Parse(strings[10]);
        }

        public Star() : base() { }

        public override string ToString()
        {
            return base.ToString() + "|" + starClass.ToString() + "|" + Temperature.ToString();
        }

    }
}
