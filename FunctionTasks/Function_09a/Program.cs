using System;
using System.Linq;

namespace Function_09a
{
    // Дан массив с числами (передается параметром). Выведите последовательно его
    // элементы, используя рекурсию и не используя цикл.
    class Program
    {
        public static int iterator = 0;
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Output(array);
        }
        static void Output(int[] array)
        {
            if (iterator < array.Length)
            {
                Console.WriteLine(array[iterator]);
                iterator++;
                Output(array);
            }
            else return;
        }
    }
}
