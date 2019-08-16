using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEpam.Project1
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() => $"({X},{Y})";
    }
    class Task1
    {
        //LT = left top 
        //RB = right bottom
        protected Point LT { get; set; }
        protected Point RB { get; set; }
        readonly double a;
        readonly double b;

        public Task1()
        {
            this.LT = new Point();
            this.RB = new Point();
        }
        public Task1(Point left_top, Point right_bottom)
        {
            this.LT = left_top;
            this.RB = right_bottom;
            a = RB.X - LT.X;
            b = LT.Y - RB.Y;
        }

        public double Perimetr() => 0;
        public double Square() => 0;

        public override string ToString() => $"{LT} {RB}";

    }
}
