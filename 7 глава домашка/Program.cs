using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_глава_домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Ovverride("Александра")); 1 задание
            //Nazad("Саша мыла раму, а рама мыла кошку"); 2 задание
            //Console.WriteLine(sravnenie("А","В")); 3 задание
            //Console.WriteLine((int)'Б');
        }
        static string Ovverride(string txt)
        {
            string text="";
            for(int k=0;k < txt.Length;k++)
            {
                text += txt[k] + " ";
            }
            return text;
        }
        static void Nazad(string txt) 
        {
            string text = "";
            string[] str = txt.Split(' ');
            for(int k= str.Length; k >0;k--) 
            {
                Console.WriteLine(str[k-1]);
            }

        }
        static string sravnenie(string str1,string str2)
        {
            int i = 0;
            if(str1.Length == str2.Length)
            {
                for(int k=0;k < str1.Length;k++) 
                {
                    if ((int)str1[k] == (int)str2[k] | (int)str1[k] == (int)str2[k]+1 | (int)str1[k] == (int)str2[k]-1)
                    {
                        i++;
                    }
                }
            }
            if(str1.Length == i)
            {
                return "Строки совпадают";
            }
            else
            {
                return "Строки не совпадают";
            }
               
        }
    }
}
