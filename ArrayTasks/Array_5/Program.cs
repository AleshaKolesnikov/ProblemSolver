using System;
using System.Drawing;

namespace Array_5
{
    // Составьте массив дней недели (ПН, ВТ, СР и т.д.). 
    // С помощью цикла for выведите все дни недели, а выходные дни выведите другим цветом.
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            foreach (string day in daysOfWeek)
            {
                if (day.Equals("Saturday")|| day.Equals("Sunday"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(day);
                Console.ResetColor();
            }

        }
    }
}
