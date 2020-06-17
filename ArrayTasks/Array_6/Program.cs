using System;
using System.Collections;

namespace Array_6
{
    // Запросите у пользователя по очереди числовые значения и сохраните их в массив. 
    // Собирайте числа до тех пор пока пользователь не введет пустое значение. 
    // Выведите получившийся массив на экран. Выполните сортировку чисел массива, и выведите его на экран.
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            bool correct = true;
            try
            {
                while (correct)
                {
                    Console.WriteLine("Input a number");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    list.Add(inputNumber);
                }
            }
            catch (FormatException)
            {
                correct = false;
                Console.WriteLine("End of filling");
            }

            Console.WriteLine("Not sorted array:");
            foreach (var i in list)
            {
                Console.WriteLine($"{i},");
            }

            list.Sort();
            Console.WriteLine("Sorted array:");
            foreach (var i in list)
            {
                Console.WriteLine($"{i},");
            }
        }
    }
}
