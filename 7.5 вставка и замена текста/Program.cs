using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5_вставка_и_замена_текста
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String txt = "Мы изучаем C#";
            Console.WriteLine(txt);
            //Текстовая переменная:
            String str;
            //Вставка слова в текст:
            str = txt.Insert(11, "язык ");
            //Проверка
            Console.WriteLine(str);
            //Вставка в текст слова с последующим замещением
            //другого текстового блока
            str = str.Insert(3, "не ").Replace("C#", "Java");
            //Проверка текста:
            Console.WriteLine(str);
            //Замена пробелов на подчеркивая:
            str = str.Replace(' ', '_');
            //проверка текста:
            Console.WriteLine(str);
            //Извлечение подстроки:
            str = str.Substring(2, 12);
            //проверка
            Console.WriteLine(str);
            str = txt.Substring(3);
            //проверка
            Console.WriteLine(str);
            Console.WriteLine(txt);
        }
    }
}
