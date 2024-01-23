using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4_поиск_по_тексту
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String txt = "Итак, два плюс два и умножить на два равно шести";
            //Отображение текстового значения:
            Console.WriteLine("Исходный текст:");
            Console.WriteLine("\"{0}\"", txt);
            //Текстовая строка для поиска:
            String str = "два";
            //Отображения текстового значения:
            Console.WriteLine("Строка для поиска:");
            Console.WriteLine("\"{0}\"", str);
            //Переменная для записи индекса
            int index;
            //индекс первого вхождения строки в текст:
            index = txt.IndexOf(str);
            Console.WriteLine("Первое совпадение: {0}", index);
            //Индекс второго вхождения строки в текст:
            index = txt.IndexOf(str, index + 1);
            Console.WriteLine("Второе вхождение: {0}", index);
            //Индекс последнего вхождения строки в текст
            index = txt.LastIndexOf(str);
            Console.WriteLine("Последнее совпадение: {0}", index);
            //индекс для начала поиска и количество символов
            int a = 7, b = 9;
            Console.WriteLine("Поиск с {0}-го индекса по {1} символам", a, b);
            index = txt.IndexOf(str, a, b);
            Console.WriteLine("Совпадение на индексе: {0}", index);
            //изменяем количество символов для поиска:
            b += 3;
            Console.WriteLine("Поиск с {0}-го индекса по {1} символам", a, b);
            index = txt.IndexOf(str, a, b);
            Console.WriteLine("Совпадение на индексе: {0}", index);
            //символ для поиса:
            char symb = 'a';
            Console.WriteLine("Теперь ищем букву\'{0}\'", symb);
            //Поиск первого совпадения
            index = 0;
            index = txt.IndexOf(symb);
            Console.WriteLine("Первое совпадение: {0}", index);
            //Поиск второго совпадения:
            index = txt.IndexOf(symb, index+1);
            Console.WriteLine("Второе совпадение: {0}", index);
            //Последнее совпадение:
            index = txt.LastIndexOf(symb);
            Console.WriteLine("Последнее совпадение: {0}",index);
            //Предпоследнее совпадение:
            index = txt.LastIndexOf(symb, index+1);
            //Поиск на интервале:
            index = txt.IndexOf(symb, a, b);
            Console.WriteLine("Поиск на интервале индексов от {0} до {1}", a, a + b - 1);
            Console.WriteLine("Первое совпадение на интервале: {0}", index);
            //последнее совпадение на интервале:
            index = txt.LastIndexOf(symb, b, b + 1);
            Console.WriteLine("Поиск до индекса {0}", b);
            Console.WriteLine("Последнее совпадение на интервале: {0}", index);
            //Новый символ для поиска:
            symb = 'ы';
            Console.WriteLine("Ищем букву \'{0}\'", symb);
            //Поиск первого совпадения:
            index = txt.IndexOf(symb);
            Console.WriteLine("Первое совпадение: {0}", index);
            //Массив с буквами для поиска:
            char[] s = { 'ы', 'а', 'д' };
            //Отображение символов для поиска:
            Console.WriteLine("Ищем букву \'{0}\'", s[0]);
            for (int k = 1; k < s.Length - 1; k++)
            {
                Console.Write(", \'" + s[k] + "\'");
            }
            Console.WriteLine(" или \'" + s[s.Length - 1] + "\':");
            //Первое совпадение:
            index = txt.IndexOfAny(s);
            Console.WriteLine("Первое совпадение: {0}", index);
            //Второе совпадение
            index = txt.IndexOfAny(s, index + 1);
            Console.WriteLine("Второе совпадение: {0}", index);
            //Последнее совпадение:
            index = txt.LastIndexOfAny(s);
            Console.WriteLine("Последнее совпадение: {0}", index);
            Console.WriteLine("Поиск на интервале индексов от {0} до {1}", a, a + b - 1);
            //Первое совпадение на интервале:
            index = txt.IndexOfAny(s, a, b);
            Console.WriteLine("Первое совпадение на интервале: {0}", index);
            //Последнее совпадение на интервале:
            index = txt.LastIndexOfAny(s, a + b - 1, b);
            Console.WriteLine("Последнее совпадение на интервале: {0}", index);
        }
    }
}
