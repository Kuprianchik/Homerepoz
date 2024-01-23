using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace слово_tihs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass obj = new MyClass(100);
            //obj.set(200);
            //Console.WriteLine($"Новое значение {obj.get()}");
           //Конструктор 1 аргумент
            MyClass1 A = new MyClass1(100);
            Console.WriteLine();
            //Конструктор 2 аргумента
            MyClass1 B = new MyClass1(200, 300);
            Console.WriteLine();
            //Конструктор 0 аргументов
            MyClass1 C = new MyClass1();
        }
    }
    class MyClass
    {
        //закрытое поле
        private int code;
        //открытый метод    
        public int get() 
        {
            return this.code;
        }
        //открытый метод
        public void set(int code) 
        {
            this.code = code;
        }
        //конструктор
        public MyClass(int code)
        {
            this.code = code;
            Console.WriteLine("Создан объект: "+this.get());
        }
    }
    class MyClass1
    {
        public int alpha;
        public int bravo;
        //конструктор с одним аргументом
        public MyClass1(int a)
        {
            Console.WriteLine("Конструктор с одним аргументом.");
            alpha = a;
            bravo = alpha;
            //отображение полей
            Console.WriteLine("Оба поля равны "+ alpha);
        }
        public MyClass1(int a,int b):this(a)
        {
            //Сообщение в консольном окне:
            Console.WriteLine("Конструктор с двумя аргументами.");
            bravo = b;
            //Отображение значений полей:
            Console.WriteLine($"Поля {alpha} и {bravo}");
        }
        public MyClass1(): this(400,500)
        {
            //Сообщение в консольном окне:
            Console.WriteLine("Конструктор без аргументов");
            //Отображение значений полей:
            Console.WriteLine($"Значения {alpha} и {bravo}");
        }
    }
}
