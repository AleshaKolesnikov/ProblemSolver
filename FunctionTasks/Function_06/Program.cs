using System;

namespace Function_06
{
    //Напишите ф-цию, в которую передается массив с целыми числами. Верните новый
    //массив, где останутся лежать только четные из этих чисел.Для этого используйте
    //вспомогательную функцию isEven из предыдущей задачи.
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = OnlyEven(new int []{ 12, 14, 16, 10, 9, 5, 12 });

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] OnlyEven(int [] array)
        {
            int length = array.Length;
            int[] onlyEvenArray = new int[length];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (IsEven(array[i]))
                {
                    onlyEvenArray[j] = array[i];
                    j++;
                }
                else
                    length--;
            }
            int[] ar = new int[length];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = onlyEvenArray[i];
            }
            return ar;
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
