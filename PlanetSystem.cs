using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace oop3
{
    [XmlInclude(typeof(Planet)), XmlInclude(typeof(Star)), XmlInclude(typeof(GasGiant)), XmlInclude(typeof(Comet))]
    [Serializable]
    public class PlanetSystem
    {
        public List<AstronomicalObject> astronomicalObjects;


        public void Add(AstronomicalObject astronomicalObject)
        {
            astronomicalObjects.Add(astronomicalObject);
        }

        public void  Remove(AstronomicalObject astronomicalObject)
        {
            astronomicalObjects.Remove(astronomicalObject);
        }

        public void RemoveAt(int index)
        {
            astronomicalObjects.RemoveAt(index);
        }

        public PlanetSystem()
        {
            astronomicalObjects = new List<AstronomicalObject>();
        }
    }
}
