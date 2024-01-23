using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_пузырька_сортировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s;
            char[] symbs = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };
            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < symbs.Length; i++)
            {
                Console.Write($"{symbs[i]} ");
            }
            Console.WriteLine();
            for (int i = 1; i < symbs.Length; i++)
            {
                for (int j = 0; j < symbs.Length - i; j++)
                {
                    if (symbs[j] > symbs[j + 1])
                    {
                        s = symbs[j + 1];
                        symbs[j + 1] = symbs[j];
                        symbs[j] = s;
                    }
                }
            }
            Console.WriteLine("Массив после сортировки");
            for (int i = 0; i < symbs.Length; i++)
            {
                Console.Write($"{symbs[i]} ");
            }
        }
    }
}
