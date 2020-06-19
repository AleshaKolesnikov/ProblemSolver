using System;

namespace Function_09
{
    class Program
    {
        // Дано число. Сложите его цифры. Если сумма получилась более 9-ти, опять сложите его цифры.
        // И так, пока сумма не станет однозначным числом(9 и менее). Исп.рекурсию.
        static void Main(string[] args)
        {
            int num = 99;
            int result = Result(num);

            Console.WriteLine(result); 
        }

        static int FindDozens(int num)
        {
                return num / 10;
        }

        static int FindUnits(int num)
        {
            
                return num % 10;
        }

        static int Result(int result)
        {
            int dozens = FindDozens(result);
            int units = FindUnits(result);

            if (dozens.Equals(0))
            {
                return units;
            }
            else
            {
                result = dozens + units;
                return Result(result);

            }
        }
    }
}
