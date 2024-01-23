using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6_разбиение_строк_и_регистр_символов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //исходная текстовая строка
            String txt = "Дорогу осилит идущий";
            //Отображение исходного текста
            Console.WriteLine(txt);
            //текстовая строка
            String str;
            //Текст с символами в верхнем регистре
            str=txt.ToUpper();
            Console.WriteLine(str);
            //текст с символами в нижнем регистре
            str=txt.ToLower();
            Console.WriteLine(str);
            //Переменная для текстового массива
            String[] words;
            //Разбивка текста на подстроки
            words = txt.Split();
            //отображение подстрок
            for(int k=0;k<words.Length; k++)
            {
                Console.WriteLine((k+1)+": " + words[k]);
            }
            Console.WriteLine();
            //разбивка текста на подстроки
            words = txt.Split('y', 'и');
            //отображение
            for(int k=0;k<words.Length;k++)
            {
                Console.WriteLine((k+1)+": " + words[k]);
            }
            Console.WriteLine();
            //разбивка текста на подстроки
            words = txt.Split(new char[] { 'y', 'и' }, 3);
            for(int k=0;k< words.Length;k++) 
            {
                Console.WriteLine((k + 1) + ": " + words[k]);
            }
            //переменная для символьного массива
            char[] symbs;
            symbs = txt.ToCharArray();
            for (int k = 0; k < words.Length; k++)
            {
                Console.Write(symbs[k]+" ");
            }
            Console.WriteLine();
        }
    }
}
