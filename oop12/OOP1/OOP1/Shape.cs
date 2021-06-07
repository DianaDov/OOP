using System;
using System.Drawing;

namespace OOP1
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public int startX;
        public int startY;

        public int width;
        public int height;

        public Shape(Int32 x, Int32 y)
        {
            this.x = x;
            this.y = y;
        }

        protected abstract System.Drawing.Rectangle GetRectangle();

        public abstract void draw(Graphics graphics, Pen pen);
    }
}
