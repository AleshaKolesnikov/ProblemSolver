using System;

namespace Array_2
{
    // Given an array [-2, -1, -3, 15, 0, -4, 2, -5, 9, -15, 0, 4, 5, -6, 10, 7]. 
    // Numbers can be positive and negative. 
    // Dysplay only negative numbers
    // which are greater than -10, but less than -3.

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2, -1, -3, 15, 0, -4, 2, -5, 9, -15, 0, 4, 5, -6, 10, 7 };

            foreach (var i in array)
            {
                if (i > - 10 && i < -3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
