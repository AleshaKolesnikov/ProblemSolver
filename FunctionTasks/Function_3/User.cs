using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Function_3
{

    // a.весь адрес не должен содержать русские буквы и спецсимволы, 
    // кроме одной «собачки», знака подчеркивания, дефиса и точки
    // причем они не могут быть первыми и последними в адресе, и идти подряд
    // например: «..», «@.», «.@» или
    // «@@», «_@», «@-», «--» и т.п.

    // b.имя эл.почты (до знака @) должно быть длиной более 2 символов, причем имя

    // может содержать только буквы, цифры и точку, но не быть единственными в
    // имени;
    //upd. что блять?

    // c.после последней точки и после @, домен верхнего уровня(ru, by, com и т.п.) не
    // может быть длиной менее 2 и более 11 символов.
    public class User
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

        // длина до @ более 2 символов
        // длина домена от 2-11
        // первый символ именно буква  либо цифра
        // последний символ перед @ именно буква либо цифра


        // ^[A-z0-9]{1}
        // ([_.-]?[A-z0-9]*[_.-]?)


        [Required]
        //[RegularExpression(@"[A-z0-9]{1}\w{2,}[A-z0-9]$\@\w+\.\w{2,11}")]
        [RegularExpression(@"(\w)\1")]
        public string Email { get; set; }

    }
}
