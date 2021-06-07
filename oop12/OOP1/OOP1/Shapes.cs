using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP1
{
    public class Shapes
    {
        private List<Shape> _shapes;
        
        public Shapes()
        {
            _shapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void draw(Graphics graphics, Pen pen)
        {
            foreach ( Shape shape in _shapes)
            {
                shape.draw(graphics, pen);
            }
        }
    }
}
