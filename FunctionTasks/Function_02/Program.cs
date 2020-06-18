using System;

namespace Function_02
{
    // Сделайте функцию, которая возвращает куб числа и его квадрат. Число передается параметром
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(9));
            Console.WriteLine(Cube(5));
        }

        public static int Square (int num)
        {
            return num * num;
        }

        public static int Cube (int num)
        {
            return num * num * num;
        }
    }
}
