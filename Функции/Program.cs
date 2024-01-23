using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, x = 1, y = 5;
            //1 пример
            //Console.WriteLine("Привет!");
            //Console.WriteLine("Ты здесь?");
            //WriteError("Нет соединения с интернетом.",symbol:'F');
            //Console.WriteLine("Странно...");
            //WriteError("Интернет не оплачен.", ConsoleColor.DarkYellow);
            //2 пример
            //sum = Sum(3, 5);
            //Console.WriteLine(sum);
            //Add(out sum, x, y);
            // Console.WriteLine(sum);

            //3 пример с массивами
            // int[] array = new int[5];
            //array = EditArray(array, 2, 5);
            //Console.WriteLine(array[2]);
            int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;
            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Red, 0, '-');
                DrawBar(mana, maxMana, ConsoleColor.Green, 1, '_');
                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число, на которое изменятся жизни:");
                health += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число, на которое изменится мана:");
                mana += Convert.ToInt32(Console.ReadLine());
                //Console.ReadKey();
                Console.Clear();

            }

        }
        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine($"Error:{symbol}{text}");
            Console.ForegroundColor = defaultColor;
        }
        static int Sum(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
        }
        static void Add(out int sum, int x, int y)
        {
            sum = x + y;
        }
        static int[] EditArray(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
        static void DrawBar(int value, int MaxValue, ConsoleColor color, int position, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";
            for (int i = value; i < MaxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + "]");
        }
    }
}
