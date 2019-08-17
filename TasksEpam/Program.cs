using System;
using TasksEpam.Project1;
using TasksEpam.Project2;

namespace TasksEpam
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Project2.Rectangle rectangle = new Project2.Rectangle();
            square.Draw();
            rectangle.Draw();
            Console.ReadKey();
        }
    }
}
