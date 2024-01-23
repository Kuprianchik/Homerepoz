using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_знакомство_с_перегрузкой_операторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            int num;
            num = A + B;
            Console.WriteLine("A+B= "+num);
        }
    }
    class MyClass
    {
        public int number;
        public MyClass(int n)
        {
            //Присваивание значений полю
            number = n;
        }
        //операторный метод для перезгрузки оператора сложения:
        public static int operator+(MyClass a, MyClass b)
        {
            //локальная целочисленная переменная:
            int m=a.number+b.number;
            //результат
            return m;
        }
    }
}
