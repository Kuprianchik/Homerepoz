using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_цикл_обновления
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Behaviour[] behaviours = new Behaviour[]
            {
            new Walker(),
            new Jumper()};
            while(true) 
            {
                foreach(var behaviour in behaviours) //Цикл обновления
                {
                    behaviour.Update();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
    class Behaviour
    {
        public virtual void Update()
        {

        }
    }
    class Walker : Behaviour
    {
        public override void Update()
        {
            Console.WriteLine("Иду");
        }
    }
    class Jumper : Behaviour
    {
        public override void Update()
        {
            Console.WriteLine("Прыгаю");
        }
    }
}
