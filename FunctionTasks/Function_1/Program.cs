using System;

namespace Function_1
{
        // Напишите ф-цию, запрашивающую имя, фамилия, отчество и номер телефона пользователя и
        // выводящую введённые данные в следующем виде:
        // *****************************
        // *Задание: «Функции»         *
        // *Номер телефона: +375(25).. *
        // *Иванов Иван Иванович       *
        // *****************************
        //Размер рамки должен определятся автоматически по самой длинной строке. Рамку
        // вывести в консоль.

    class Program
    {
        public static string _fullName;
        public static string _phoneNumber;
        public static string _task;
        public static int frameWidth;
        public static char frameSymbol;
        static void Main(string[] args)
        {
            _task = "Задание: \"Функции\"";
            frameSymbol = '*';

            InputName();
            InputPhone();

            frameWidth = MaxWidth();

            string upFrame = Frame();
            string downFrame = Frame();
        }
        
        public static void InputName()
        {
            Console.WriteLine("Enter your name:");
            _fullName = Console.ReadLine();
        }

        public static void InputPhone()
        {
            Console.WriteLine("Enter your phone number:");
            _phoneNumber = Console.ReadLine();
        }

        public static int MaxWidth()
        {
            int max = 0;
            int[] stringLength = { _fullName.Length, _phoneNumber.Length, _task.Length };

            for (int i = 0; i < stringLength.Length; i++)
            {
                if (max < stringLength[i])
                    max = stringLength[i];
            }
            return max;
        }

        public static string Frame()
        {
            char[] frame = new char[frameWidth];
            foreach (char i in frame)
            {
                frame[i] = frameSymbol;
            }

            return frame.ToString();
        }
    }
}
