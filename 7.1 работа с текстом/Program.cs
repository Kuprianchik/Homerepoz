using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_работа_с_текстом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] symbs = { 'Я', 'з', 'ы', 'к', ' ', 'C', '#' };
            Console.WriteLine("Символьный массив:");
            //отображение символьного массива
            Console.WriteLine(symbs);
            //Текстовый объект создается на основе символьного массива:
            String A = new String(symbs);
            //Проверка значение текстового объекта:
            Console.WriteLine("A: \"{0}\"",A);
            //Текстовый обьект создан на основе нескольких элементов из символьного массива:
            String B = new String(symbs,1,5);
            //Проверка значение текстового объекта:
            Console.WriteLine("B: \"{0}\"", B);
            //Текстовый обьект как последовательность одинаковых символов:
            String C = new String('ы', 7);
            //Проверка значения текстового обьекта:
            Console.WriteLine("C: \"{0}\"", C);
            //Создание текстового обьекта путем вызова
            //статического метода с двумя символьными
            //аргументами:
            A = getText('A', 'H');
            //Проверка значения текстового обьекта:
            Console.WriteLine("A: \"{0}\"", A);
            B = getText('H', 'A');
            //Проверка значения текстового обьекта:
            Console.WriteLine("B: \"{0}\"", B);
            C = getText(symbs);
            //Проверка значения текстового обьекта:
            Console.WriteLine("C: \"{0}\"", C);

        }  
        static String getText(char[] symbs)
        {
            //лок текстовая переменнная
            String txt = "";
            for(int k=0;k<symbs.Length;k++) 
            {
                txt += symbs[k];
            }
            return txt;
        }
        static String getText(char a,char b) 
        {
            String txt = "";
            char s = a;
            //Формирование текстовой строки:
            while(s<=b)
            {
                txt += s;
                s++;
            }
            return txt;
        }
    }
}
