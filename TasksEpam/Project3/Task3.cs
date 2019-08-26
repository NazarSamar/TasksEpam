namespace TasksEpam.Project3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Documentation for the Task3.
    /// </summary>
    public static class Task3
    {
        /// <summary>
        /// List
        /// </summary>
        public static List<string> List { get; set; }

        /// <summary>
        /// Generate random string
        /// </summary>
        public static string Generate()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            Thread.Sleep(1);
            for (int k = 0; k < 4; ++k)
            {
                builder.Append((char)random.Next(65, 91));
            }
                
            return builder.ToString();
        }

        /// <summary>
        /// Removing string that starts with 'z' and duplicate strings
        /// </summary>
        public static void Remove(ref List<string> strings)
        {
            List = strings;
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i][0] == 'Z')
                {
                    strings.Remove(strings[i]);
                }

                for (int j = i + 1; j < strings.Count; j++)
                {
                    if (strings[i] == strings[j])
                    {
                        strings.RemoveAt(j);
                        --j;
                    }
                }
            }
        }

        /// <summary>
        /// Sort List by descending
        /// </summary>
        public static void Sort(ref List<string> strings)
        {
            strings.Sort(delegate(string x, string y)
            {
                return y.CompareTo(x);
            });
        }

        /// <summary>
        /// Showing information on page
        /// </summary>
        public static void DisplayPage(int pageNumber)
        {
            if (pageNumber < 1)
            {
                throw new Exception("Pages starts with 1");
            }
            else if ((pageNumber - 1) * 5 >= List.Count)
            {
                throw new Exception("Page doesn`t exist");
            }

            int start = (pageNumber - 1) * 5;
            for (int i = start; i < List.Count && i < start + 5; ++i)
            {
                Console.WriteLine($"{i} {List[i]}");
            }
        }
    }
}
