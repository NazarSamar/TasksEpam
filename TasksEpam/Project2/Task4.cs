using System;
namespace TasksEpam.Project2
{
    namespace Interface
    {
        interface IDrawable
        {
            void Draw();            
        }

        static class Addition
        {
            public static void DrawAll(params IDrawable[] array)
            {
                foreach (var item in array)
                {
                    item.Draw();
                }
            }
        }

        class Figure: IDrawable
        {
            readonly int X;
            readonly int Y;

            public Figure(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public void Draw()
            {
                Console.WriteLine(this.GetType().Name);
            }
            
        }

        class Square : Figure
        {
            public Square(int x, int y) : base(x, y)
            {
            }
            public new void Draw()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }

        class Rectangle : Figure, IDrawable
        {
            public Rectangle(int x, int y) : base(x, y)
            {
            }
            public new void Draw()
            {
                Console.WriteLine(this.GetType().Name);
            }
        }
    }
    
}
