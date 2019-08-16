﻿namespace TasksEpam.Project1
{
    namespace StaticClasses
    {
        static class Rectangle
        {
            public static double Perimetr(Point LT, Point RB)
            {
                if (LT.X > RB.X || LT.Y < RB.Y)
                {
                    throw new System.Exception();
                }
                else
                {
                    double a = RB.X - LT.X;
                    double b = LT.Y - RB.Y;
                    return (a + b) * 2;
                }                
            }
            public static double Square(Point LT, Point RB)
            {
                if (LT.X > RB.X || LT.Y < RB.Y)
                {
                    throw new System.Exception();
                }
                else
                {
                    double a = RB.X - LT.X;
                    double b = LT.Y - RB.Y;
                    return a * b;
                }               
            }
        }
  
        static class Circle
        {
            public const double PI = 3.14159265358979;

            public static double Square(double radius)
            {
                if (radius <= 0)
                {
                    throw new System.Exception();
                }
                else
                {
                    return PI * radius * radius;
                }
            }
            public static double Length(double radius)
            {
                if (radius <= 0)
                {
                    throw new System.Exception();
                }
                else
                {
                    return 2 * PI * radius;
                }
            }
        }
    }
}
