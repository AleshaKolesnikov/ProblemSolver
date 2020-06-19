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
        public static int _input;
        public static char[] array;
        public static char symbol;
        static void Main(string[] args)
        {
            Console.WriteLine("Input the height of trianlge");
            _input = Convert.ToInt32(Console.ReadLine());
            _height = _input;
            symbol = '*';

            DrawTriangle(array);
            DrawTurned(array);
        }
        public static void DrawTriangle(char[] array)
        {
            array = new char[(_height * 2)];
            Console.WriteLine("Unturned triangle:");

            int next = _height;

            for (; _height > 0; next++, _height--)
            {
                FillFromMiddle(array, symbol);
                Output(array);
                array[next] = symbol;
            }
            _height = _input;
        }
        public static void DrawTurned(char[] array)
        {
            array = new char[(_height * 2) + 1];
            Console.WriteLine("Turned:");

            int incrInd = 0;
            int decrInd = array.Length - 1;
            char[] tempArray = new char[array.Length];
            char space = ' ';

            FillArray(array, symbol);

            for (; _height > 0; _height--)
            {
                for (int i = 0; i < 1; incrInd++, decrInd--, i++)
                {
                    array[incrInd] = space;
                    array[decrInd] = space;
                }
                tempArray = array;
                Output(tempArray);
            }
            _height = _input;
        }
        public static void Output(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        public static void FillArray(char[] array, char symbol)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = symbol;
            }
        }
        public static void FillFromMiddle(char [] array, char symbol)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[_height - 1] = symbol;
            }
        }
    }

}
