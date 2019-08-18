//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Nazar Samardak">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace TasksEpam
{
    using System;
    using TasksEpam.Project1;
    using TasksEpam.Project2;    
    using System.Collections.Generic;
    using System.IO;
    using Interface = TasksEpam.Project2.Interface;

    public class Program
    {
        private static int index = 0;

        private static void Main(string[] args)
        {
            List<string> menuItems = new List<string>() {
                "1: Taskl",
                "2: Task2",
                "3: Exit"
            };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = DrawMenu(menuItems);
                switch(selectedMenuItem)
                {
                    case "1: Taskl":
                        Console.WriteLine("TASK1");
                        Console.Read();
                        break;
                    case "2: Task2":
                        Console.WriteLine("TASK2");
                        Console.Read();
                        break;
                    case "3: Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            }
        }

        private static string DrawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
