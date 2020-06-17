using System;

namespace Array_4
{
    // Дан массив числами(строчного типа), 
    // например: ["10", "20", "30", "50", "235", "3000"]. 
    // Выведите на экран только те числа из массива, которые начинаются на цифру 1, 2 или 5.
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "10", "20", "30", "50", "235", "3000" };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i][0].Equals('1') || array[i][0].Equals('2') || array[i][0].Equals('5'))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
