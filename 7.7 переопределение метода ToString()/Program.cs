using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7_переопределение_метода_ToString__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(100, 'A');
            //новые значения полей обьекта
            obj.num = 200;
            obj.symb = 'B';
            Console.WriteLine("Новые значения полей обьекта");
            //Отображение значения полей обьекта.
            //Неявно вызывается метод ToString():
            Console.WriteLine(obj);
            //Разбивка текста с описанием обьекта на подстроки
            //Метод ToString() вызывается в явном виде:
            String[] str=obj.ToString().Split('\n');
            Console.WriteLine("Явный вызов метода ToString() ");
            //Отображение подстрок, содержащих значения
            //полей обьекта:
            for(int k=0; k<str.Length; k++)
            {
                Console.WriteLine("[* " + str[k]+" *]");
            }
        }
    }
    class MyClass
    {
        //целочисленное поле:
        public int num;
        //символьное поле:
        public char symb;
        //Конструктор
        public MyClass(int n,char s)
        {
            //присваивание значений полям:
            num = n;
            symb = s;
            //Отображение сообщения о создании обьекта.
            //Неявно вызывается метод ToString()
            Console.WriteLine("Создан новый обьект \n"+this);
        }
        public override string ToString()
        {
            //Локальная текстовая переменная:
            String txt = "Числовое поле: " + num;
            txt += "\nСимвольное поле: " + symb;
            //Результат метода
            return txt;
        }
    }
}
