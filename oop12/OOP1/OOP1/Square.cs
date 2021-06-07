using System;
using System.Drawing;

namespace OOP1
{
    class Square : Shape
    {
        public Square(int x, int y, int width) : base(x, y)
        {
            this.width = width;
        }

        protected override System.Drawing.Rectangle GetRectangle()
        {
            return new System.Drawing.Rectangle(x < startX ? startX - Math.Min(width, height) : x, y < startY ? startY - Math.Min(width, height) : y, Math.Min(width, height), Math.Min(width, height));
        }

        public override void draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, GetRectangle());
        }

    }
}
