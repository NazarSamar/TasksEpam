//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Nazar Samardak">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace TasksEpam
{
    using System;
    using P1 = TasksEpam.Project1;
    using P2 = TasksEpam.Project2;
    using System.Collections.Generic;
    using System.IO;
    using Interface = TasksEpam.Project2.Interface;

    public class Program
    {
        
        public static void ReadFileTASK1()
        {
            string[] lines = File.ReadAllLines(@"fileTASK1.txt");     
            
            var line1 = lines[0].Split(',');
            P1.Point a = new P1.Point(Int32.Parse(line1[0]), Int32.Parse(line1[1]));

            var line2 = lines[1].Split(',');        
            P1.Point b = new P1.Point(Int32.Parse(line2[0]), Int32.Parse(line2[1]));

            P1.Rectangle rect = new P1.Rectangle(a, b);
            Console.WriteLine("------TASK1------");
            Console.WriteLine(rect);
            Console.WriteLine($"Perimetr = {rect.Perimetr()}");
            Console.WriteLine($"Square = {rect.Square()}\n");

            var line3 = lines[2].Split(',');
            P1.Point a1 = new P1.Point(Int32.Parse(line3[0]), Int32.Parse(line3[1]));

            var line4 = lines[3].Split(',');
            P1.Point b1 = new P1.Point(Int32.Parse(line4[0]), Int32.Parse(line4[1]));
            P1.RectangleProperties rect_prop = new P1.RectangleProperties(a1, b1);

            Console.WriteLine("------TASK2------");
            Console.WriteLine(rect_prop);
            Console.WriteLine($"Perimetr = {rect_prop.Perimetr}");
            Console.WriteLine($"Square = {rect_prop.Square}\n");

            Console.WriteLine("------TASK3------");
            Console.WriteLine("Circle");            
            var line5 = lines[4];
            double radius = Double.Parse(line5);
            P1.Circle circle = new P1.Circle(radius);
            Console.Write($"Radius = {radius}");
            Console.WriteLine($"Square = {circle.Square()}");
            Console.WriteLine($"Length = {circle.Length()}");

            Console.WriteLine("------TASK4------");
            var line6 = lines[5].Split(',');
            P1.Point a2 = new P1.Point(Int32.Parse(line6[0]), Int32.Parse(line6[1]));
            var line7 = lines[6].Split(',');
            P1.Point b2 = new P1.Point(Int32.Parse(line7[0]), Int32.Parse(line7[1]));

            Console.WriteLine("Static Rectangle");
            Console.WriteLine($"Perimetr = {P1.StaticClasses.Rectangle.Perimetr(a2, b2)}");
            Console.WriteLine($"Square = {P1.StaticClasses.Rectangle.Square(a2, b2)}\n");

            var line8 = lines[7];
            double radius1 = Double.Parse(line8);
            Console.WriteLine("Static Circle");
            Console.WriteLine($"Square = {P1.StaticClasses.Circle.Square(radius1)}");
            Console.WriteLine($"Length = {P1.StaticClasses.Circle.Length(radius1)}");

            Console.WriteLine("------TASK5------");
            var line9 = lines[8].Split(',');
            P1.ComplexNumber complex1 = new P1.ComplexNumber(Double.Parse(line9[0]), Double.Parse(line9[1]));
            Console.Write($"Complex1 = {complex1}");

            var line10 = lines[9].Split(',');
            P1.ComplexNumber complex2 = new P1.ComplexNumber(Double.Parse(line10[0]), Double.Parse(line10[1]));
            Console.Write($"Complex2 = {complex2}");

            Console.WriteLine($"Multiplication = {complex1 * complex2}");
            Console.WriteLine($"Division = {complex1 * complex2}");

        }
        public static void ConsoleTASK1()
        {
            Console.WriteLine("------TASK1------");
            Console.WriteLine("Rectangle");
            Console.Write("Enter x1: ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y2 = Int32.Parse(Console.ReadLine());

            P1.Point a = new P1.Point(x1, y1);
            P1.Point b = new P1.Point(x2, y2);
            P1.Rectangle rect = new P1.Rectangle(a, b);
            Console.WriteLine($"Perimetr = {rect.Perimetr()}");
            Console.WriteLine($"Square = {rect.Square()}\n");

            Console.WriteLine("------TASK2------");
            Console.WriteLine("RectangleProperties");
            Console.Write("Enter x1: ");
            int x11 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y11 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            int x21 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y21 = Int32.Parse(Console.ReadLine());
            P1.Point a1 = new P1.Point(x11, y11);
            P1.Point b1 = new P1.Point(x21, y21);
            P1.RectangleProperties rect_prop = new P1.RectangleProperties(a1, b1);
            Console.WriteLine(rect_prop);
            Console.WriteLine($"Perimetr = {rect_prop.Perimetr}");
            Console.WriteLine($"Square = {rect_prop.Square}\n");

            Console.WriteLine("------TASK3------");
            Console.WriteLine("Circle");
            Console.Write("Enter radius: ");
            double radius = Double.Parse(Console.ReadLine());
            P1.Circle circle = new P1.Circle(radius);
            Console.WriteLine($"Square = {circle.Square()}");
            Console.WriteLine($"Length = {circle.Length()}");

            Console.WriteLine("------TASK4------");
            Console.WriteLine("Static Rectangle");
            Console.WriteLine($"Perimetr = {P1.StaticClasses.Rectangle.Perimetr(a, b)}");
            Console.WriteLine($"Square = {P1.StaticClasses.Rectangle.Square(a, b)}\n");

            Console.WriteLine("Static Circle");
            Console.WriteLine($"Square = {P1.StaticClasses.Circle.Square(radius)}");
            Console.WriteLine($"Length = {P1.StaticClasses.Circle.Length(radius)}");

            Console.WriteLine("------TASK5------");
            Console.WriteLine("Complex Number");
            Console.Write("Enter real1: ");
            double real1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter imaginary1: ");
            double imaginary1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter real2: ");
            double real2 = Double.Parse(Console.ReadLine());
            Console.Write("Enter imaginary2: ");
            double imaginary2 = Double.Parse(Console.ReadLine());

            P1.ComplexNumber complex1 = new P1.ComplexNumber(real1, imaginary1);
            P1.ComplexNumber complex2 = new P1.ComplexNumber(real2, imaginary2);

            Console.WriteLine($"Multiplication = {complex1 * complex2}");
            Console.WriteLine($"Division = {complex1 * complex2}");

        }

        private static void Main(string[] args)
        {
            Console.CursorVisible = false;
            choose:
            while (true)
            {
                Console.WriteLine("1: Taskl\n" +
                "2: Task2\n" +
                "3: Exit");
                Console.WriteLine("Enter number:");
                int input1 = Int32.Parse(Console.ReadLine());
                switch(input1)
                {
                    case 1:
                        Console.WriteLine("TASK1");
                        goto task1;
                    case 2:
                        Console.WriteLine("TASK2");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            task1:
                Console.Clear();
                Console.WriteLine("1: File\n" +
                "2: Console\n" +
                "3: Return back");
                Console.WriteLine("Enter number:");
                int input2 = Int32.Parse(Console.ReadLine());
                switch (input2)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("File");
                        ReadFileTASK1();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Console");
                        ConsoleTASK1();
                        Console.WriteLine();
                        break;
                    case 3:
                        goto choose;
                    default:
                        break;
                }

            }
        }
    }
}
