using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_ещё_перегрузка_оператора_плюс
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            //Вычисление суммы обьектов
            MyClass C = A + B;
            //проверка результата
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            //Вычисление суммы обьекта и целого числа:
            C = A + 1;
            Console.WriteLine(C);
            //Вычисление суммы челого числа и обьекта:
            C = 10 + A;
            Console.WriteLine(C);
            Console.Write("Унарный оператор: ");
            //Используется унарный "плюс"
            Console.WriteLine(+C);
            int num = (+A) + (+B);
            Console.WriteLine("Сумма чисел: "+num);
        }
    }
    class MyClass
    {
        public int number;
        //Конструктор
        public MyClass(int n)
        {
            number = n;
        }
        //Переопределение метода ToString
        public override string ToString() 
        {
            return "Поле number: " + number;
        }
        //операторный метод для вычисления суммы двух обьектов
        public static MyClass operator+(MyClass a, MyClass b) 
        {
            int m = a.number + b.number;
            //Создание обьекта класса
            MyClass t = new MyClass(m);
            return t;
        }
        //операторный метод для вычисления суммы обьекта и целого числа
        public static MyClass operator+(MyClass a,int x)
        {
            int m = a.number + x;
            return new MyClass(m);
        }
        public static MyClass operator+(int x,MyClass a)
        {
            return a+x;
        }
        public static int operator+(MyClass a)
        {
            //результат
            return a.number;
        }
    }
}
