﻿
namespace TasksEpam.Project1
{
    class Circle
    {
        public const double PI = 3.14159265358979;

        public double R { get; set; }

        public Circle()
        {
        }

        public Circle(double radius)
        {
            if(radius<=0)
            {
                throw new System.Exception();
            }
            else
            {
                this.R = radius;
            }
        }

        public double Square() => PI * R * R;

        public double Length() => 2 * PI * R;

        public override string ToString() => $"{R}";

    }
}
