using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейсы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movable car = new car();
            Movable human = new Human();
            human.Move(2);
            car.Move(5);
        }
    }
    interface Movable// при наследовании должны реализовать все методы
    {
        void Move(int speed);
        void ShowMoveSpeed();
    }
    interface Iburnable
    {
        void Burn();
    }
    class car : Vehicle, Movable, Iburnable //наследование от класса и интерфейсов
    {
        public void Move(int speed)
        {
            Console.WriteLine($"Я двигаюсь {speed}");
        }
        public void ShowMoveSpeed() { }
        public void Burn() { }
    }
    class Vehicle
    {

    }
    class Human : Movable
    {
        private string _тame;
        public string Name { get; private set; }


        public void Move(int speed)
        {
            Console.WriteLine($"Я двигаюсь {speed}");

        }
        public void ShowMoveSpeed()
        {
            Console.WriteLine("Я двигаюсь");
        }
    }
}
