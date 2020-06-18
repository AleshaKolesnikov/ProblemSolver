using System;

namespace Function_03
{
    // Напишите функции min и max, которые возвращают меньшее и большее из чисел a и b.
    class Program
    {
        static void Main(string[] args)
        {
            Max(1, 2);
            Min(5, 6);

            Max(10, 10);
            Min(15, 15);
        }
        public static void Max(int num1, int num2)
        {
            if (num1 > num2)
                Console.WriteLine(num1);
            else if (num2 > num1)
                Console.WriteLine(num2);
            else
                Console.WriteLine("Equals");
        }
        public static void Min(int num1, int num2)
        {
            if (num1 < num2)
                Console.WriteLine(num1);
            else if (num2 < num1)
                Console.WriteLine(num2);
            else
                Console.WriteLine("Equals");
        }
    }
}
