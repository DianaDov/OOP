using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    [Serializable]
    public abstract class AstronomicalObject { 
        public string Name { get; set; }
        private double _mass;
        public double Mass
        {
            get { return _mass; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Mass");
                _mass = value;
            }
        }

        public Vector3 position;
        public Vector3 velocity;
        public AstronomicalObject() {
            position = new Vector3();
            velocity = new Vector3();
        }

        public AstronomicalObject(string s)
        {
            string[] strings = s.Split('|');
            Name = strings[0];
            Mass = double.Parse(strings[1]);
            position = new Vector3();
            position.X = double.Parse(strings[2]);
            position.Y = double.Parse(strings[3]);
            position.Z = double.Parse(strings[4]);
            velocity = new Vector3();
            velocity.X = double.Parse(strings[5]);
            velocity.Y = double.Parse(strings[6]);
            velocity.Z = double.Parse(strings[7]);
        }

        public override string ToString()
        {
            return Name + "|" + Mass.ToString() + "|" + position.ToString() +"|" + velocity.ToString();
        }
    }
}
