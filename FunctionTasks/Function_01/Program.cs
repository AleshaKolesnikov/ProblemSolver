using System;

namespace Function_01
{
    // Сделайте функцию, которая отнимает от первого числа второе и делит на третье. Числа
    // передаются параметром.
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = Input();
            float num2 = Input();
            float num3 = Input();

            float result = Func(num1, num2, num3);
            Console.WriteLine(result);
        }

        public static float Func(float num1, float num2, float num3)
        {
            return (num1 - num2) / num3;
        }

        public static float Input()
        {
            float num = (float)Convert.ToDecimal(Console.ReadLine());
            return num;
        }
    }
}
