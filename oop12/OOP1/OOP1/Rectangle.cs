using System;

namespace OOP1
{
    class Rectangle : Square
    {
        public Rectangle(int x, int y, int width, int height): base(x, y, width)
        {
            base.height = height;
        }

        protected override System.Drawing.Rectangle GetRectangle()
        {
            return new System.Drawing.Rectangle(x, y, width, height);
        }

    }
}
