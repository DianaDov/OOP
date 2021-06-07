using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    [Serializable]
    public class Comet: AstronomicalObject
    {
        private double _tailLength;
        public double TailLength
        {
            get { return _tailLength; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("TailLength");
                _tailLength = value;
            }
        }
        public Coma coma;
        public Comet(string s) : base(s) {
            string[] strings = s.Split('|');
            TailLength = double.Parse(strings[8]);
            if (strings.Length > 9)
            {
                coma = new Coma();
                coma.Radius =double.Parse(strings[10]);
            }
        }
        public Comet() : base() { }
        public override string ToString()
        {
            return base.ToString() + "|" + TailLength.ToString() + (coma == null ? "" : ("|" + coma.Radius.ToString()));
        }
    }
    [Serializable]
    public class Coma
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Radius");
                _radius = value;
            }
        }
    }
}
