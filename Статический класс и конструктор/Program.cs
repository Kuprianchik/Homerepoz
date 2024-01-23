using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статический_класс_и_конструктор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, мир!");//вызовется первым
            MyClass instance = new MyClass();
            Console.WriteLine(MyClass.StaticField);// выозовется статический конструктор, после обычный и после значение переменной.

        }
    }
    class MyClass
    {
        public static float StaticField;
        static MyClass()
        {
            StaticField = 10f;
            Console.WriteLine("Статический конструктор.");
        }
        public MyClass()
        {
            Console.WriteLine("Обычный конструктор");
        }
    }
}
