using System;

namespace Array_3
{
    // Создайте новый массив и заполните его значениями от 23 до 57, 
    // используя цикл for и while. 
    // С помощью цикла for найдите сумму элементов этого массива.
    // Запишите ее в переменную result и выведите.
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            int maxValueable = 57;
            int minValueable = 23;
            int arrayLength = (maxValueable - minValueable) + 1;
            int temp = minValueable;
            int[] array = new int[arrayLength];

            //Filling an array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp;
                temp++;
            }

            Console.WriteLine("Outputting an array:");
            foreach (var i in array)
            {
                Console.Write($"{i},");
            }

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            Console.WriteLine($"Array's numbers sum is:{result}");
        }
    }
}
