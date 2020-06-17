using System;

namespace Array_7
{
    // Найдите сумму элементов массива между двумя нулями (первым и последним нулями в массиве). 
    // Если двух нулей нет в массиве, то выведите ноль. В массиве может быть более 2х нулей. 
    // Пример массива: [48,9,0,4,21,2,1,0,8,84,76,8,4,13,2] или [1,8,0,13,76,8,7,0,22,0,2,3,2].
    class Program
    {
        static void Main(string[] args)
        {
            int firstZeroIndex = 0;
            int lastZeroIndex = 0;

            int[] array = { 48, 9, 1, 4, 21, 2, 1, 1, 8, 84, 76, 8, 4, 13, 2 };

            //first 0 search
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(0))
                {
                    firstZeroIndex = i;
                    break;
                }
            }

            //last 0 search
            for (int j = array.Length - 1; j > 0; j--)
            {
                if (array[j].Equals(0))
                {
                    lastZeroIndex = j;
                    break;
                }
            }

            if (firstZeroIndex == lastZeroIndex)
            {
                Console.WriteLine("В массиве нет двух \"0\"");
            }

            int sum = 0;
            for (int i = firstZeroIndex; i < lastZeroIndex; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
