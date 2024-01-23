using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace многомерные_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Передано {0} параметров",args.Length);
            for(int i=0;i<args.Length;i++)
            {
                Console.WriteLine("{0}-й параметр: {1}", (i + 1), args[i]);
            }
            Console.WriteLine("Выполнение завершено!");
            Обьект objs = new Обьект();
            objs.ShowObjs();
            //символьные массив из переменных массива
            char[][] symbs = new char[5][];
            int[][] nums = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };
            char s = 'А';
            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = new char[i + 3];
                //перебор элементов во внутреннем массиве:
                for (int j = 0; j < symbs[i].Length; j++)
                {
                    symbs[i][j] = s;
                    //Значение следующего элемента:
                    s++;
                }
            }
            Console.WriteLine("Целочисленный массив:");
            //отображение целочисленного массива:
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write("{0,3}", nums[i][j]);/*Первый О в инструкции
{ О , 2 } означает, что вместо нее подставляется значение первого
аргумента после текстовой строки 11 { О , 2 } 11 (то есть значение переменной
р ), а число 2 в инструкции { О , 2 } означает, что для отображения значения
выделяется не меньше двух позиций.*/
                }
                Console.WriteLine();
            }
            Console.WriteLine("Символьный массив:");
            //отображение целочисленного массива:
            foreach (char[] q in symbs)
            {
                foreach (char p in q)
                {
                    Console.Write("{0,2}", p);
                }
                Console.WriteLine();
            }
        }
    }

    class Обьект
    {
        //Массив из трех переменных типа Object:
        object[] objs = new object[3];
        //Элементам массива присваиваются значения разных типов:
        public Обьект()
        {
            objs[0] = 123; //Целое число
            objs[1] = 'A'; //Символ
            objs[2] = "Трейтий элемент"; //Текст
        }
        public void ShowObjs()
        {
            Console.WriteLine("Создан такой массив:");
            //Проверка содержимого массива:
            for (int k = 0; k < objs.Length; k++)
            {
                Console.WriteLine(k+": " + objs[k]);
            }
            //Новые значения элементов:
            objs[0] = (int)objs[0] + 111;//Целое число
            objs[1] = "Второй элемент";//Текст
            objs[2] = 3.141592;//Действительное число
            Console.WriteLine("После присваивания значений:");
            //Проверка содержимого массива:
            for(int k=0; k < objs.Length; k++)
            {
                Console.WriteLine(k+": " + objs[k]);
            }
            //Целочисленный массив:
            int[] nums = { 10, 20, 30 };
            //Переменная массива присваивается как значение элементу массива
            objs[2] = nums;
            Console.WriteLine("Целочисленный массив");
    //Отображение элементов целочисленного массива
    for(int i = 0; i < ((int[])objs[2]).Length; i++)
            {
                Console.Write("{0,3}", ((int[])objs[2])[i]);
            }
            Console.WriteLine();
        ((int[]) objs[2])[1]=0;
            //Новое значение элемента в числовом массиве:
            Console.WriteLine("Ещё раз тот же массив:");
            //Отображение элементов целочисленного массива
            for(int i=0;i<nums.Length;i++) 
            {
                Console.Write("{0,3}", nums[i]);
            }
            Console.WriteLine();
        }

    }
}
