using System;

namespace Function_04
{
    // Напишите две функции: первая ф-ция должна возвращать массив с числовыми
    // значениями, диапазон которых должен вводиться пользователем с клавиатуры;
    // вторая – выводить полученный массив.
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = GetArray();
            ShowArray(result);
        }

        public static int[] GetArray()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] array = { num1, num2, num3 };
            return array;
        }

        public static void ShowArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
