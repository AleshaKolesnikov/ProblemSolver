using System;

namespace Array_8
{
    // Нарисовать равнобедренный треугольник из символов ^. Высоту выбирает пользователь.
    class Program
    {
        public static int _height;
        static void Main(string[] args)
        {
            Console.WriteLine("Input the height of trianlge");
            _height = Convert.ToInt32(Console.ReadLine());

            char[] array = new char[_height * 2];
            int incr = _height;
            char symbol = '^';

            do
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[_height - 1] = symbol;
                    Console.Write($"{array[i]}");
                }
                Console.WriteLine();
                if (_height >= 0)
                {
                    incr++;
                    array[incr - 1] = symbol;
                    _height--;
                }
            }
            while (_height > 0);
        }
    }
}
