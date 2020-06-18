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
            frameWidth = GetMaxWidth();

            FrameStart();
        }

        public static void InputName()
        {
            Console.WriteLine("Enter your name:");
            _fullName = "Имя: ";
            _fullName = _fullName.Insert(5, Console.ReadLine());
        }
        public static void InputPhone()
        {
            Console.WriteLine("Enter your phone number:");
            _phoneNumber = "Телефонный номер: ";
            _phoneNumber = _phoneNumber.Insert(18,Console.ReadLine());
        }
        public static int GetMaxWidth()
        {
            int max = 0;
            int[] stringLength = { _fullName.Length, _phoneNumber.Length, _task.Length };

            for (int i = 0; i < stringLength.Length; i++)
            {
                if (max < stringLength[i])
                    max = stringLength[i];
            }
            return max + 4;
        }
        public static void UpAndDownFrame()
        {
            char[] frame = new char[frameWidth];
            for (int i = 0; i < frame.Length; i++)
            {
                frame[i] = frameSymbol;
            }

            Console.WriteLine(frame);
        }
        public static void SideFrame(string str)
        {
            char[] result = new char[frameWidth];
            result[0] = frameSymbol;
            result[result.Length - 1] = frameSymbol;

            char[] incomming = str.ToCharArray();

            for(int i = 2; i< incomming.Length + 2; i++)
            {
                result[i] = incomming[i - 2];
            }
            Console.WriteLine(result);
        }
        public static void FrameStart()
        {
            UpAndDownFrame();
            SideFrame(_task);
            SideFrame(_phoneNumber);
            SideFrame(_fullName);
            UpAndDownFrame();
        }
    }
}
