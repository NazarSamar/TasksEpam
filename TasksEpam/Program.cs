//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Nazar Samardak">
//     Company copyright tag.
// </copyright>
// <author>NazarSamar</author>
//-----------------------------------------------------------------------
namespace TasksEpam
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Interface = TasksEpam.Project2.Interface;
    using P1 = TasksEpam.Project1;
    using P2 = TasksEpam.Project2;

    /// <summary>
    /// Class Program contains menu.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Reading from file for TASK1.
        /// </summary>
        public static void ReadFileTASK1()
        {
            string[] lines = File.ReadAllLines(@"fileTASK1.txt");

            var line1 = lines[0].Split(',');
            P1.Point a = new P1.Point(int.Parse(line1[0]), int.Parse(line1[1]));

            var line2 = lines[1].Split(',');
            P1.Point b = new P1.Point(int.Parse(line2[0]), int.Parse(line2[1]));

            P1.Rectangle rect = new P1.Rectangle(a, b);
            Console.WriteLine("------TASK1------");
            Console.WriteLine(rect);
            Console.WriteLine($"Perimetr = {rect.Perimetr()}");
            Console.WriteLine($"Square = {rect.Square()}\n");

            var line3 = lines[2].Split(',');
            P1.Point a1 = new P1.Point(int.Parse(line3[0]), int.Parse(line3[1]));

            var line4 = lines[3].Split(',');
            P1.Point b1 = new P1.Point(int.Parse(line4[0]), int.Parse(line4[1]));
            P1.RectangleProperties rect_prop = new P1.RectangleProperties(a1, b1);

            Console.WriteLine("------TASK2------");
            Console.WriteLine(rect_prop);
            Console.WriteLine($"Perimetr = {rect_prop.Perimetr}");
            Console.WriteLine($"Square = {rect_prop.Square}\n");

            Console.WriteLine("------TASK3------");
            Console.WriteLine("Circle");
            var line5 = lines[4];
            double radius = double.Parse(line5);
            P1.Circle circle = new P1.Circle(radius);
            Console.Write($"Radius = {radius}");
            Console.WriteLine($"Square = {circle.Square()}");
            Console.WriteLine($"Length = {circle.Length()}");

            Console.WriteLine("------TASK4------");
            var line6 = lines[5].Split(',');
            P1.Point a2 = new P1.Point(int.Parse(line6[0]), int.Parse(line6[1]));
            var line7 = lines[6].Split(',');
            P1.Point b2 = new P1.Point(int.Parse(line7[0]), int.Parse(line7[1]));

            Console.WriteLine("Static Rectangle");
            Console.WriteLine($"Perimetr = {P1.StaticClasses.Rectangle.Perimetr(a2, b2)}");
            Console.WriteLine($"Square = {P1.StaticClasses.Rectangle.Square(a2, b2)}\n");

            var line8 = lines[7];
            double radius1 = double.Parse(line8);
            Console.WriteLine("Static Circle");
            Console.WriteLine($"Square = {P1.StaticClasses.Circle.Square(radius1)}");
            Console.WriteLine($"Length = {P1.StaticClasses.Circle.Length(radius1)}");

            Console.WriteLine("------TASK5------");
            var line9 = lines[8].Split(',');
            P1.ComplexNumber complex1 = new P1.ComplexNumber(double.Parse(line9[0]), double.Parse(line9[1]));
            Console.Write($"Complex1 = {complex1}");

            var line10 = lines[9].Split(',');
            P1.ComplexNumber complex2 = new P1.ComplexNumber(double.Parse(line10[0]), double.Parse(line10[1]));
            Console.Write($"Complex2 = {complex2}");

            Console.WriteLine($"Multiplication = {complex1 * complex2}");
            Console.WriteLine($"Division = {complex1 * complex2}");
            Console.ReadKey();
        }

        /// <summary>
        /// Reading from console for TASK1.
        /// </summary>
        public static void ConsoleTASK1()
        {
            Console.WriteLine("------TASK1------");
            Console.WriteLine("Rectangle");
            Console.WriteLine("Left Top coordinates");
            Console.Write("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Right Bottom coordinates");
            Console.Write("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());

            P1.Point a = new P1.Point(x1, y1);
            P1.Point b = new P1.Point(x2, y2);
            P1.Rectangle rect = new P1.Rectangle(a, b);
            Console.WriteLine($"Perimetr = {rect.Perimetr()}");
            Console.WriteLine($"Square = {rect.Square()}\n");

            Console.WriteLine("------TASK2------");
            Console.WriteLine("RectangleProperties");
            Console.WriteLine("Left Top coordinates");
            Console.Write("Enter x1: ");
            int x11 = int.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Right Bottom coordinates");
            Console.Write("Enter x2: ");
            int x21 = int.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y21 = int.Parse(Console.ReadLine());
            P1.Point a1 = new P1.Point(x11, y11);
            P1.Point b1 = new P1.Point(x21, y21);
            P1.RectangleProperties rect_prop = new P1.RectangleProperties(a1, b1);
            Console.WriteLine(rect_prop);
            Console.WriteLine($"Perimetr = {rect_prop.Perimetr}");
            Console.WriteLine($"Square = {rect_prop.Square}\n");

            Console.WriteLine("------TASK3------");
            Console.WriteLine("Circle");
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
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
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Enter imaginary1: ");
            double imaginary1 = double.Parse(Console.ReadLine());
            Console.Write("Enter real2: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("Enter imaginary2: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            P1.ComplexNumber complex1 = new P1.ComplexNumber(real1, imaginary1);
            P1.ComplexNumber complex2 = new P1.ComplexNumber(real2, imaginary2);

            Console.WriteLine($"Multiplication = {complex1 * complex2}");
            Console.WriteLine($"Division = {complex1 * complex2}");
            Console.ReadKey();
        }

        /// <summary>
        /// Reading from file for TASK2.
        /// </summary>
        public static void ReadFileTASK2()
        {
            string[] lines = File.ReadAllLines(@"fileTASK2.txt");

            Console.WriteLine("------TASK1------");
            P2.Square square = new P2.Square();
            P2.Rectangle rectangle = new P2.Rectangle();

            Console.Write("class Square : ");
            square.Draw();
            Console.WriteLine();
            Console.Write("class Rectangle : ");
            rectangle.Draw();
            Console.WriteLine();

            Console.WriteLine("------TASK2------");
            var line1 = lines[0].Split(',');
            Console.WriteLine("Square");
            P2.Abstract.Square square1 = new P2.Abstract.Square(int.Parse(line1[0]), int.Parse(line1[1]));
            square1.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle");
            var line2 = lines[1].Split(',');
            P2.Abstract.Rectangle rectangle1 = new P2.Abstract.Rectangle(int.Parse(line2[0]), int.Parse(line2[1]));
            rectangle1.Draw();
            Console.WriteLine();

            Console.WriteLine("------TASK3------");

            Console.WriteLine("Figure");
            var line3 = lines[2].Split(',');
            P2.Virtual.Figure figure2 = new P2.Virtual.Figure(int.Parse(line3[0]), int.Parse(line3[1]));
            figure2.Draw();
            Console.WriteLine();

            Console.WriteLine("Square");
            var line4 = lines[3].Split(',');
            P2.Virtual.Square square2 = new P2.Virtual.Square(int.Parse(line4[0]), int.Parse(line4[1]));
            square2.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle");
            var line5 = lines[4].Split(',');
            P2.Virtual.Rectangle rectangle2 = new P2.Virtual.Rectangle(int.Parse(line5[0]), int.Parse(line5[1]));
            rectangle2.Draw();
            Console.WriteLine();

            Console.WriteLine("------TASK4------");
            Interface.IDrawable[] drawables = new Interface.IDrawable[]
                {
                    new Interface.Figure(int.Parse(lines[5].Split(',')[0]), int.Parse(lines[5].Split(',')[1])),
                    new Interface.Square(int.Parse(lines[6].Split(',')[0]), int.Parse(lines[6].Split(',')[1])),
                    new Interface.Square(int.Parse(lines[7].Split(',')[0]), int.Parse(lines[7].Split(',')[1])),
                    new Interface.Figure(int.Parse(lines[8].Split(',')[0]), int.Parse(lines[8].Split(',')[1])),
                    new Interface.Square(int.Parse(lines[9].Split(',')[0]), int.Parse(lines[9].Split(',')[1]))
                };
            P2.Interface.Addition.DrawAll(drawables);
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        /// Reading from console for TASK2.
        /// </summary>
        public static void ConsoleTASK2()
        {
            Console.WriteLine("------TASK1------");
            P2.Square square = new P2.Square();
            P2.Rectangle rectangle = new P2.Rectangle();

            Console.Write("class Square : ");
            square.Draw();
            Console.WriteLine();
            Console.Write("class Rectangle : ");
            rectangle.Draw();
            Console.WriteLine();

            Console.WriteLine("------TASK2------");
            Console.WriteLine("Square");
            Console.Write("Enter x: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y1 = int.Parse(Console.ReadLine());
            P2.Abstract.Square square1 = new P2.Abstract.Square(x1, y1);
            square1.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle");
            Console.Write("Enter x: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y2 = int.Parse(Console.ReadLine());
            P2.Abstract.Rectangle rectangle1 = new P2.Abstract.Rectangle(x2, y2);
            rectangle1.Draw();
            Console.WriteLine();

            Console.WriteLine("------TASK3------");

            Console.WriteLine("Figure");
            Console.Write("Enter x: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y3 = int.Parse(Console.ReadLine());
            P2.Virtual.Figure figure2 = new P2.Virtual.Figure(x3, y3);
            figure2.Draw();
            Console.WriteLine();

            Console.WriteLine("Square");
            Console.Write("Enter x: ");
            int x4 = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y4 = int.Parse(Console.ReadLine());
            P2.Virtual.Square square2 = new P2.Virtual.Square(x4, y4);
            square2.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle");
            Console.Write("Enter x: ");
            int x5 = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y5 = int.Parse(Console.ReadLine());
            P2.Virtual.Rectangle rectangle2 = new P2.Virtual.Rectangle(x5, y5);
            rectangle2.Draw();
            Console.WriteLine();

            Console.WriteLine("------TASK4------");
            Interface.IDrawable[] drawables = new Interface.IDrawable[]
                {
                    new Interface.Figure(2, 6),
                    new Interface.Square(7, -2),
                    new Interface.Square(-2, 5),
                    new Interface.Figure(5, 2),
                    new Interface.Square(0, 0),
                    new Interface.Rectangle(1, 2)
                };
            P2.Interface.Addition.DrawAll(drawables);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void ConsoleTASK3()
        {

        }
        public static void ReadFileTASK3()
        {

        }
        public static void Choose()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1: Taskl\n" +
                "2: Task2\n" +
                "3: Task3\n" +
                "3: Exit");
                Console.Write("Enter number: ");
                int input1 = int.Parse(Console.ReadLine());
                switch (input1)
                {
                    case 1:
                        Console.WriteLine("TASK1");
                        Task1();
                        break;
                    case 2:
                        Console.WriteLine("TASK2");
                        Task2();
                        break;
                    case 3:
                        Console.WriteLine("TASK3");
                        Task3();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            void Task1()
            {
                Console.Clear();
                Console.WriteLine("1: File\n" +
                "2: Console\n" +
                "3: Return back");
                Console.Write("Enter number: ");
                int input2 = int.Parse(Console.ReadLine());
                switch (input2)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("File");
                        ReadFileTASK1();
                        Console.WriteLine();
                        Choose();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Console");
                        ConsoleTASK1();
                        Console.WriteLine();
                        Choose();
                        break;
                    case 3:
                        Console.Clear();
                        Choose();
                        break;
                    default:
                        break;
                }
            }
            void Task2()
            {
                Console.Clear();
                Console.WriteLine("1: File\n" +
                "2: Console\n" +
                "3: Return back");
                Console.WriteLine("Enter number: ");
                int input3 = int.Parse(Console.ReadLine());
                switch (input3)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("File");
                        ReadFileTASK2();
                        Console.WriteLine();
                        Choose();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Console");
                        ConsoleTASK2();
                        Console.WriteLine();
                        Choose();
                        break;
                    case 3:
                        Console.Clear();
                        Choose();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Task3()
        {
            Console.Clear();
            Console.WriteLine("1: File\n" +
            "2: Console\n" +
            "3: Return back");
            Console.Write("Enter number: ");
            int input2 = int.Parse(Console.ReadLine());
            switch (input2)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("File");
                    ReadFileTASK1();
                    Console.WriteLine();
                    Choose();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Console");
                    ConsoleTASK1();
                    Console.WriteLine();
                    Choose();
                    break;
                case 3:
                    Console.Clear();
                    Choose();
                    break;
                default:
                    break;
            }
        }

        /// <auto-generated />
        private static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Choose();
        }
    }
}

