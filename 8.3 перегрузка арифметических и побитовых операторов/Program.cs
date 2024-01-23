using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_перегрузка_арифметических_и_побитовых_операторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData A = new MyData(100, 'A', "Alpha");
            MyData B = new MyData(200, 'B', "Bravo");
            //Новый обьект:
            MyData C = A ^ B;
            //Проверка результата
            //112
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            C = B ^ A;
            Console.WriteLine(C);
            //переменные"
            int n = +A;
            char s = -A;
            string t = ~A;
            //Проверка
            Console.WriteLine("Обьект А: поля {0}, \'{1}\' и \'{2}\'\n",n,s,t);
            A++;
            //проверка
            Console.WriteLine(A);
            //Увелечения значения поля code Обьекта A и проверка результата
            Console.WriteLine(++A);
            //Уменьшение значеня поля code обьекта B и проверка результата
            Console.WriteLine(--B);
            --B;
            //проверка результата
            Console.WriteLine(B);
            //К обьекту прибавляется число
            C = A + 1000;
            //проверка
            Console.WriteLine(C);
            //Сумма и разность числа и обьекта
            Console.WriteLine("Сумма и разность: {0} и {1}\n",2000+A,1000-A);
            //Прибавление к обьекту текстовой строки:
            C = A + "Charlie";
            Console.WriteLine(C);
            //Посимвольное отображение значения текстового поля обьекта C
            for(int k=0;k<(~C).Length;k++)
            {
                Console.Write((C>>k)+" ");
            }
            Console.WriteLine();
            //Символы из текстового поля обьекта C
            //Отображаются в обратном порядке:
            for(int k=0;k<(~C).Length;k++)
            {
                Console.Write((C<<k)+" ");
            }
            Console.WriteLine();
            //Прибавление обьекта к текстовой строке:
            t = "Обьект C. " + C;
            Console.WriteLine(t);
        }
    }
    //Класс с перегрузкой арифметических и побитовых операторов
    class MyData
    {
        private int code;
        private char symb;
        private string text;
        public MyData(int n,char s,string t)
        {
            code = n;
            symb = s;
            text = t;
        }
        public override string ToString() 
        {
            string txt = "Поля обьекта:\n";
            txt += "Числовое поле: " + code + "\n";
            txt += "Символьное поле: \'" + symb + "\'\n";
            txt += "Числовое поле: \'" + text + "\'\n";
            txt += "--------------------------";
            return txt;
        }
        //Операторный метод для вычисления суммы обьекта
       //и целого числа:
       public static MyData operator+(MyData obj,int n)
        {
            return new MyData(+obj + n, -obj, ~obj);
        }
        //операторный метод для вычисления разности обьекта и целого числа
        public static MyData operator-(MyData obj,int n)
        {
            return new MyData(+obj - n, -obj, ~obj);
        }
        //Операторный метод для вычилсения суммы целого числа и обьекта:
        public static int operator+(int n,MyData obj)
        {
            return n + (+obj);
        }
        //Операторный метод для вычисления разности целого числа и обьекта
        public static int operator-(int n,MyData obj)
        {
            return n - (+obj);
        }
        //Операторный метод для вычисления суммы обьекта и текстовой строки
        public static MyData operator+(MyData obj, string t)
        {
            return new MyData(+obj, -obj, t);
        }
        //операторный метод возвращает результатом текст
        public static string operator~(MyData obj)
        {
            return obj.text;
        }
        //операторный метод возвращает результатом число:
        public static int operator+(MyData obj)
        {
            return obj.code;
        }
        //операторный метод возвращает результатом символ
        public static char operator-(MyData obj)
        {
            return obj.symb;
        }
        //операторный метод возвращает результатом символ из текста:
        public static char operator>>(MyData obj, int k)
        {
            return (~obj)[k];
        }
        //операторный метод возвращает результатом символ из текста
        public static char operator<<(MyData obj,int k)
        {
            return (~obj)[(~obj).Length - k - 1];
        }
        //Операторный метод возвращает результатом обьект
        public static MyData operator^(MyData a,MyData b)
        {
            string txt = ~a + " & " + ~b;
            return new MyData(+a, -b, txt);
        }
        //операторный метод для увелечения значения 
        //целочисленного поля обьекта:
        public static MyData operator++(MyData obj)
        {
            obj.code += 10;
            return obj;
        }
        //операторный метод для уменьшения значения 
        //целочисленного поля обьекта:
        public static MyData operator --(MyData obj)
        {
            obj.code -= 10;
            return obj;
        }
    }
}
