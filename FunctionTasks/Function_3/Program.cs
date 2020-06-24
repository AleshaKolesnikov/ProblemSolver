using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Function_3
{
    // Напишите ф-цию, которая должна проверить правильность ввода адреса эл. почты.

    // Почта верна при условии:
    // 1) Весь адрес не должен содержать русские буквы и спецсимволы;
    // 2) Разрешённые спецсимволы . _ - @
    // 3) Разрешён только 1 знак @
    // 4) Адрес должен начинаться на буквы либо цифру
    // 5) Спецсимволы не могут идти подряд
    // 5.1) Последний символ перед @ именно буква либо цифра
    // 6) Имя до @ более 2 символов
    // 7) Домен 1-го уровня от 2 до 11 букв и цифр
    // 8) Домен 2-го уровня от 1 до 6 букв и цифр
    class Program
    {
        static void Main(string[] args)
        {
            string valid = "Qwe-q_w.e12@mail.ru";               // [A-z0-9_.-]*\@[A-z]{1,11}\.[a-z]{2,11}
            string notvalid1 = "абвге@mail.ru";                 // содержит русские буквы
            string notvalid2 = "_qweqweq@mail.ru";              // первый символ "_" 
            string notvalid3 = "qweqwe_@mail.ru";               // последний символ "_" перед @
            string notvalid4 = "qwe_.qwe@mail.ru";              // два символа подряд
            string notvalid5 = "qwe@qwe@mail.ru";               // два символа @
            string notvalid6 = "a@mail.ru";                     // длина до @ менее 2 символов
            string notvalid7 = "qweqwe_qwe@mail.r";             // домен меньше 2 символов
            string notvalid8 = "qweqwe_qwe@mail.qweqweqweqwe";  // домен больше 11 символов



            Console.WriteLine("Введите Email");
            string email = Console.ReadLine();

            string pattern = "";
            string at = @"@";
            // первый символ именно буква либо цифра
            pattern += @"^[A-Za-z0-9]{1}";
            //недопускает подряд символы _ . -
            pattern += @"(?:([\w_.-])(?![_.-][_.-]))+";
            //последний символ перед @ именно буква либо цифра
            pattern += @"[A-Za-z0-9]+" + at;           
            //домен второго уровня минимум 1 максимум 6 символов
            pattern += @"[A-Za-z]{1,6}";
            //точка
            pattern += @"\.";
            //домен верхнего уровня не менее 2 и не более 11
            pattern += @"[A-Za-z0-9]{2,11}$";

            Regex regex = new Regex(pattern);

            bool result = IsValid(email, regex);
            Console.WriteLine($"{email} - {result}");
        }

        static bool IsValid(string validated, Regex regex)
        {
            MatchCollection matches = regex.Matches(validated);
            if (matches.Count > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
