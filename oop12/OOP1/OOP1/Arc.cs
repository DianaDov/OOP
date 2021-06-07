using System;
using System.Drawing;

namespace OOP1
{
    public class Arc: Ellipse
    {
        public float startAngle, sweepAngle;

        public Arc(int x, int y, int aAxis, int bAxis, float startAngle, float sweepAngle): base(x, y, aAxis, bAxis)
        {
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public override void draw(Graphics graphics, Pen pen)
        {
            graphics.DrawArc(pen, GetRectangle(), startAngle, sweepAngle);
        }
    }
}
