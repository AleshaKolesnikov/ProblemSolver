using System;

namespace Function_08
{
    class Program
    {
        //Напишите ф-цию, которая возвращает массив заполненный числами Фибоначи от 0 до 1000
        static void Main(string[] args)
        {
            int[] fiboArr = FillArray(1000);
        }

        static int FiboMethod(int number)
        {
            if (number == 0 || number == 1)
                return number;
            else
                return FiboMethod(number - 1) + FiboMethod(number - 2);
        }

        static int FiboLoop(int number)
        {
            int current = 0;
            int next = 1;
            int previous;

            for (int i = 0; i < number; i++)
            {
                previous = current;
                current = next;
                next += previous;
            }

            return current;
        }

        static int[] FillArray(int last)
        {
            int[] tempArray = new int[47];
            int length = 0;

            for (int i = 0; FiboLoop(i) <= last && FiboLoop(i) >= 0; i++, length++)
            {
                tempArray[i] = FiboLoop(i);
            }

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = tempArray[i];
            }

            return result;
        }
    }
}
