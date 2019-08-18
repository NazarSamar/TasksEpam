﻿using System;
namespace TasksEpam.Project2
{
    abstract class Figure
    {
        public abstract void Draw();
    }
    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
