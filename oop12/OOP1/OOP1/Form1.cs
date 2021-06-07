using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            squareItem.Click += SquareItem_Click;
            rectangleItem.Click += RectangleItem_Click;
            circleItem.Click += CircleItem_Click;
            ellipseItem.Click += EllipseItem_Click;
            arcItem.Click += ArcItem_Click;
        }

        private Shape _shape;
        private Shapes _shapes = new Shapes();
        Pen pen = new Pen(Color.Red, 3);

        private void ArcItem_Click(object sender, EventArgs e)
        {
            _shape = new Arc(-10, -10, 1, 1, 0, 360);
            _shapes.Add(_shape);
        }


        private void EllipseItem_Click(object sender, EventArgs e)
        {
            _shape = new Ellipse(0, 0, 0, 0);
            _shapes.Add(_shape);
        }

        private void CircleItem_Click(object sender, EventArgs e)
        {
            _shape = new Circle(0, 0, 0);
            _shapes.Add(_shape);
        }

        private void RectangleItem_Click(object sender, EventArgs e)
        {
            _shape = new Rectangle(0, 0, 0, 0);
            _shapes.Add(_shape);
        }

        private void SquareItem_Click(object sender, EventArgs e)
        {
            _shape = new Square(0, 0, 0);
            _shapes.Add(_shape);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _shapes.draw(e.Graphics, pen);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ( _shape != null && !_angle)
            {
                _shape.x = e.X;
                _shape.y = e.Y;
                _shape.startX = e.X;
                _shape.startY = e.Y;
                _drawing = true;
            }
            if (_angle)
            {
                _sweeping = true;
                int x = e.X - (_shape.x + Width) / 2, y = e.Y - (_shape.y + Height / 2);
                (_shape as Arc).startAngle = getAngle(e.X, e.Y);
            }
        }

        float prevAngle = 0;
        private float getAngle(int x, int y)
        {
            int delX = x - (_shape.x + _shape.width / 2), delY = y - (_shape.y + _shape.height / 2);
            float angle = (float) (Math.Asin(delY / Math.Sqrt(Math.Pow(delX, 2) + Math.Pow(delY, 2))) * 180 / Math.PI);
            if (x < _shape.x + _shape.width / 2) angle = 180 - angle;
            if (Math.Abs(angle - prevAngle) > 180)
            {
                if (angle < prevAngle) angle += 360;
                else angle -= 360;
            }
            prevAngle = angle;
            return angle;
        }

        private bool _drawing = false;
        private bool _angle = false , _sweeping;
        private int _prevX = 0, _prevY= 0;
        private bool _left = true;
        private bool _top = true;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ( _drawing)
            {
                if (e.X > _prevX)
                {
                    if (e.X > _shape.x + _shape.width)
                    {
                        if (_left) _shape.x += _shape.width;
                        _shape.width = Math.Abs(e.X - _shape.x);
                        _left = false;
                    }
                    else
                    {
                        _shape.width -= Math.Abs(e.X - _shape.x);
                        _shape.x = e.X;
                        _left = true;
                    }
                } 
                else
                {
                    if (e.X > _shape.x)
                    {
                        _shape.width = Math.Abs(e.X - _shape.x);
                        _left = false;
                    }
                    else
                    {
                        _shape.width += Math.Abs(e.X - _shape.x);
                        if (!_left)
                            _shape.width = Math.Abs(e.X - _shape.x);
                        _shape.x = e.X;
                        _left = true;
                    }
                }
                if (e.Y > _prevY)
                {
                    if (e.Y > _shape.y + _shape.height)
                    {
                        if (_top) _shape.y += _shape.height;
                        _shape.height = Math.Abs(e.Y - _shape.y);
                        _top = false;
                    }
                    else
                    {
                        _shape.height -= Math.Abs(e.Y - _shape.y);
                        _shape.y = e.Y;
                        _top = true;
                    }
                }
                else
                {
                    if (e.Y > _shape.y)
                    {
                        _shape.height = Math.Abs(e.Y - _shape.y);
                        _top = false;
                    }
                    else
                    {
                        _shape.height += Math.Abs(e.Y - _shape.y);
                        if (!_top)
                            _shape.height = Math.Abs(e.Y - _shape.y);
                        _shape.y = e.Y;
                        _top = true;
                    }
                }

            }
            if (_sweeping)
            {
                int x = e.X - _shape.x + Width / 2, y = e.Y - _shape.y + Height / 2;
                (_shape as Arc).sweepAngle = getAngle(e.X, e.Y) - (_shape as Arc).startAngle;
            }
            _prevX = e.X;
            _prevY = e.Y;
            this.Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _angle = false;
            if (_shape is Arc && _drawing)
            {
                _angle = true;
            } else
                _shape = null;
            _drawing = false;
            _sweeping = false;
            this.Invalidate();
        }
    }
}
