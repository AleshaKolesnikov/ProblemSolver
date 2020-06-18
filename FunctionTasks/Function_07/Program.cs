using System;

namespace Function_07
{
    // Напишите ф-цию, которая рисует следующую пирамидку (исп. вложенные циклы):
    //1
    //22
    //333
    //4444
    //55555
    //666666
    //7777777
    //88888888
    //999999999
    // Кол-во рядов должно вводиться параметром. Если пользователь ввел доп. параметр,
    // непредусмотренный ф-цией по умолчанию - один любой символ, кроме пробела, то
    // пирамида должна быть нарисована этим символом, например:
    //*
    //**
    //***
    //****
    //*****
    //******
    //*******
    //********
    //*********
    class Program
    {
        public static int height;
        public static int[] array;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height:");
            height = Convert.ToInt32(Console.ReadLine());
            Func(height, ' ');
            Func(height);
            Func(height, '*');
        }
        public static void Func(int height)
        {
            array = new int[height];
            int iterator = 1;

            for (int i = 0; i < array.Length; i++, iterator++)
            {
                for (int j = 0; j < iterator && iterator <= array.Length; j++)
                {
                    Console.Write(i+1);
                }
                Console.WriteLine();
            }
        }
        public static void Func(int height, char symbol)
        {
            if (!symbol.Equals(' '))
            {
                array = new int[height];
                int iterator = 1;

                for (int i = 0; i < array.Length; i++, iterator++)
                {
                    for (int j = 0; j < iterator && iterator <= array.Length; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Символ не может быть пробелом");
        }
    }
}
