using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    [Serializable]
    public class Planet : AstronomicalObject
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Radius");
                _radius = value;
            }
        }

        public Planet(string s) : base(s) {
            string[] strings = s.Split('|');
            Radius = double.Parse(strings[8]);
        }

        public Planet() : base() { }

        public override string ToString()
        {
            return base.ToString() + "|" + Radius.ToString();
        }
    }
}
