using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    [Serializable]
    public class Vector3
    {
        public double X;
        public double Y;
        public double Z;

        public Vector3(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector3()
        {
         
        }

        public override string ToString()
        {
            return X.ToString() + "|" + Y.ToString() +  "|"  + Z.ToString();
        }
    }
}
