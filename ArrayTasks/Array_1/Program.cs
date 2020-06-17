using System;

namespace Array_1
{
    // Outputting an array
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
