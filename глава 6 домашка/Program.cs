using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace глава_6_домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass A = new MyClass(); 1 задание
            //A.Set('b');
            //Console.WriteLine(A.GetNumber());
            //A.Show();

            //MyClass2 A = new MyClass2(); 2 задание
            //A.Show();

            //MyClass3 A = new MyClass3(); 3 задание
            //MyClass3 B = new MyClass3(500);
            //MyClass3 C = new MyClass3(300, 400);

            //MyClass4 A = new MyClass4(4.960); 4 задание
            //MyClass4 B = new MyClass4(5, 'r');

            //Myclass5 A = new Myclass5('f'); 5 задание

            //MyClass6 A = new MyClass6(100); 6 задание
            //A.Show();
            //A.SetValue(300);
            //A.Show();

            //MyClass7 A = new MyClass7(); 7  задание
            //A.SetValue('r');
            //A.Show();
            //A.SetValue("Строка");
            //A.Show();
            //char[] c = new char[] { 'с', 'а', 'ш', 'а' };
            //A.SetValue(c);
            //A.Show();
            
            //MyClass8.SetValue(); 8 задание
            //MyClass8.SetValue();
        }
    }
    class MyClass
    {
        private char symbol='a';
      
        public void Set(char symbol)
        {
            Console.WriteLine(this.symbol);
            this.symbol = symbol;
            Console.WriteLine(this.symbol);
        }
        public int GetNumber()
        {
            int n;
            n=(int)this.symbol;
            return n; 
        }
        public void Show()
        {
            Console.WriteLine($"Значение поля = {symbol}, его код = {(int)symbol}");
        }
    }
    class MyClass2
    {
        public char a='a', g='g';
        public void Show()
        {
          
            for(int i =(int)a;i<=(int)g;i++)
            {
                Console.Write(i+"\t");
            }
        }
    }
    class MyClass3
    {
        private int a, b;
        public  MyClass3()
        {
            a = 100;
            b = 200;
            Console.WriteLine("Без передачи аргументов");
            Console.WriteLine(this.a + " " + this.b);
        }
        public  MyClass3(int a)
        {
            this.a = a;
            b = 200;
            Console.WriteLine("Передали 1 аргумент");
            Console.WriteLine(this.a  +" "+ this.b);
        }
        public MyClass3(int a,int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Передали 2 аргумента");
            Console.WriteLine(this.a + " " + this.b);
        }
    }
    class MyClass4
    {
        private int a;
        private char b;
        public MyClass4(int a, char b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine($"При передаче 2х аргументов: {this.a} {this.b}");
        }
        public MyClass4(double a)
        {
            
            this.a = (int)a;
            double c = a % this.a;
            c *= 100;
            this.b = (char)((int)c);
            //this.b = Convert.ToChar((a % this.a));
            Console.WriteLine($"При передаче 1 аргумента типа double: {this.a} {this.b}");

        }
    }
    class Myclass5
    {
        private int a;
        public Myclass5(int a)
        {
            int c = Proverka(a);
            switch (c)
                {
                case 1:
                    {
                        if (a >= 100)
                        {
                            this.a = 100;
                            Console.WriteLine(this.a);
                        }
                        else
                        {
                            this.a = a;
                            Console.WriteLine(this.a);
                        }
                        break;
                    }
                    case 0:
                    {
                        break;
                    }
            }
        
        }
        public Myclass5()
        {
            this.a = 0;
            Console.WriteLine(this.a);
        }
        public int Proverka(int? a)
        {
            if (a is int)
            {
                return 1;
            }
            else
                return 0;
        }
    }
    class MyClass6
    {
        private int max, min;
        public MyClass6(int max, int min)
        {
            SetValue(max,min);
        }
        public MyClass6(int max)
        {
            SetValue(max);
        }
        public void SetValue(int max, int min)
        {
            if (max > min)
            {
                this.max = max;
                this.min = min;
            }
            else
            {
                this.max = min;
                this.min = max;
            }
        }
            public void SetValue(int max)
            {             
                    this.max = max+1;
                    this.min = max;  
            }
        public void Show()
        {
            Console.WriteLine($"Максимум: {max}, минимум: {min}");
        }
       
    }
    class MyClass7
    {
        private char a;
        private string b;
        public void SetValue(char a)
        {
            this.a = a;
        }
        public void SetValue(string b)
        {
            this.b = b;
        }
        public void SetValue(char[] c)
        {
            if( c.Length == 1)
            {
                this.a = c[0];
            }
            else
            {
               for(int i = 0;i< c.Length;i++)
                {
                    this.b += c[i];
                }
            }
        }
        public void Show()
        {
            Console.WriteLine("Символьное значение = "+a);
            Console.WriteLine("Строковое значение = "+b);
        }
    }
    class MyClass8
    {
        static int a = 0;
       public static void SetValue()
        {
            Console.WriteLine($"Текущее значение = {a}");
            a++;
        }
    }
}
