using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    [Serializable]
    public class GasGiant:Planet
    {

        private double _liquidLayerRadius;
        public double LiquidLayerRadius
        {
            get
            {
                return _liquidLayerRadius;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("LiquidLayerRadius");
                _liquidLayerRadius = value;
            }
        }
        private double _coreRadius;
        public double CoreRadius
        {
            get
            {
                return _coreRadius;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Radius");
                _coreRadius = value;
            }
        }
        public GasGiant(string s) : base(s) {
            string[] strings = s.Split('|');
            LiquidLayerRadius = double.Parse(strings[9]);
            CoreRadius = double.Parse(strings[10]);
        }
        public GasGiant() : base() { }
        public override string ToString()
        {
            return base.ToString() + "|" + LiquidLayerRadius.ToString() + "|" + CoreRadius.ToString();
        }
    }
}
