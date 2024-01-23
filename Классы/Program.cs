using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car ferrari = new car("f40",4,-500,300);
            ferrari.ShowTechicalPassport();
            ferrari.BecomeOlder(5, 35);
            ferrari.ShowTechicalPassport();
        }
        public class car
        {
            public string Name;
            public int Age;
            public int HorsePower;
            public float MaxSpeed;

            public int Years = 4;
             public car(string name, int age, int horsePower, float maxSpeed)//конструктор с параметрами
            {
               if (horsePower<0)
                {
                    HorsePower = 1;
                }
               else
                {
                HorsePower = horsePower;    
                }
                Name = name;
                Age = age;
                MaxSpeed = maxSpeed;
            }
            public car() // конструктор по умолчанию
            {
                Name = "Ford";
                HorsePower = 500;
                Age = 1;
                MaxSpeed = 300;
            }
            public void ShowTechicalPassport()
            {
                Console.WriteLine($"Название авто: {Name}\nКоличество лошадиных сил: {HorsePower}" +
                    $"\nВозраст авто:{Age}\nМаксимальня скорость: {MaxSpeed} км/ч.");
            }
            public void BecomeOlder(int Years, int runAwayHorses)
            {
                Age += this.Years + Years;
                HorsePower -= runAwayHorses;
            }
        }
    }
}
