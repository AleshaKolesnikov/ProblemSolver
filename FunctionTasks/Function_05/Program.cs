using System;

namespace Function_05
{
    // Сделайте функцию isEven() (even - это четный), которая параметром принимает целое
    // число и проверяет: четное оно или нет.Если четное - пусть функция возвращает true,
    // если нечетное - false.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEven(9)); 
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
