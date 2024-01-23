using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace методы_с_произвольным_количеством_аргументов
{
    internal class Program
    {
        //метод для вычисления суммы чисел:
        static int sum(params int[] a)
        {
            int res = 0;
            //перебор аргументов метода:
            for (int k = 0; k < a.Length; k++)
            {
                res += a[k];
            }
            return res;
        }
        //Метод для извлечения символов из текста:
        static string getText(string t, params int[] a)
        {
            //Начальное значение формируемой текстовой строки
            string res = "";
            //Перебор аргументов метода:
            for (int k = 0; k < a.Length; k++)
            {
                //добавление символа в текст:
                res += t[a[k]];
            }
            return res;
        }
        static void show(int[] a, params char[] b)
        {
            //Количество элементов в числовом массиве:
            Console.Write("Чисел " +a.Length+" ");
            for(int k=0; k<a.Length-1; k++)
            {
                Console.Write(a[k]+ " ");
            }
            Console.WriteLine("и " + a[a.Length-1]);
            //Количество символьных аргументов:
            Console.Write("Символов"+b.Length+": ");
            //Значения символьных аргументов:
            for(int k=0;k<b.Length-1; k++)
            {
                Console.Write(b[k]+ " ");
            }
            Console.WriteLine("и " + b[b.Length-1]);
        }
        static void Main(string[] args)
        {
            //примеры вызова методов.
            //Вычисление суммы чисел:
            Console.WriteLine("Сумма чисел: "+sum(1,6,9,2,4));
            Console.WriteLine("Сумма чисел: "+sum(5,1,2));
            //Формируется текст:
            Console.WriteLine(getText("Раз два три",0,10,8,1));
            Console.WriteLine(getText("Бревно",3,5,1,5,4));
            //Отображаются аргументы
            show(new int[] { 1, 3, 5 }, 'A', 'B', 'C', 'D', 'E');
            show(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C', 'D');
        }
    }
}
