using System;

namespace OOP1
{
    public class Ellipse : Circle
    {
        public Ellipse(int x, int y, int aAxis, int bAxis) : base(x, y, aAxis) 
        {
            height = bAxis * 2;
        }

        protected override System.Drawing.Rectangle GetRectangle()
        {
            return new System.Drawing.Rectangle(x, y, width == 0? 1: width, height == 0? 1: height);
        }

    }
}
