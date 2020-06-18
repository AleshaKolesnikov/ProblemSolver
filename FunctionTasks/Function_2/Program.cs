using System;

namespace Function_2
{
    // Напишите ф-цию, которая рисует равнобедренный треугольник из звездочек:
    //      *
    //     ***
    //    *****
    //   *******
    //  *********
    // Кол-во рядов должно вводиться с клавиатуры.Доп., напишите такую же ф-цию, но
    // которая выведет перевернутый треугольник.
    class Program
    {
        public static int _height;
        static void Main(string[] args)
        {
            Console.WriteLine("Input the height of trianlge");
            _height = Convert.ToInt32(Console.ReadLine());

            char[] array = new char[_height * 2];
            int incr = _height;
            char symbol = '*';

            UnturnedTriangle(array, symbol, incr);

        }

        public static void UnturnedTriangle(char[] array, char symbol, int incr)
        {
            Console.WriteLine("Unturned triangle:");
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
