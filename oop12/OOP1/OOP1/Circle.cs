using System;
using System.Drawing;

namespace OOP1
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int radius): base(x, y)
        {
            width = radius * 2;
        }

        protected override System.Drawing.Rectangle GetRectangle()
        {
            return new System.Drawing.Rectangle(x < startX ? startX - Math.Min(width, height) : x, y < startY ? startY - Math.Min(width, height) : y, Math.Min(width, height), Math.Min(width, height));
        }

        public override void draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, GetRectangle());
        }

    }
}
