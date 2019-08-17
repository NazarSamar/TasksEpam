﻿using System;
namespace TasksEpam.Project2
{
    namespace Virtual
    {
        class Figure
        {
            readonly int X;
            readonly int Y;

            public Figure(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public virtual void Draw()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }
        class Square : Figure
        {
            public Square(int x, int y) : base(x, y)
            {
            }

            public override void Draw()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }
        class Rectangle : Figure
        {
            public Rectangle(int x, int y) : base(x, y)
            {
            }

            public override void Draw()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }
    }
}
