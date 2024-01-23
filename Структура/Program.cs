using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структура
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vector2 position = default(Vector2);
            Vector2 position;
            //position.X = 10;
            // Vector2 vertor = new Vector2(10);// вызываем конструктор с инициализацией только X
            // Console.WriteLine(vertor.X);//выведет 0
            // ошибки при работе с структорой
            //Vector2 targetPosition = new Vector2(10, 10);
            //Vector2 playerPosition = targetPosition;
            //playerPosition.X += 15;
            //Console.WriteLine(targetPosition.X);
            GameObject bullet = new GameObject();
            Console.WriteLine(bullet.Position.X);//позиция после создания пули
            Vector2 newPosition = bullet.Position;//новая позиция равно позиции пули
            newPosition.X = 50;// добавляем по X новой позиции
            bullet.Position = newPosition;//присваеваем пуле значения структуры вектора 2 
            Console.WriteLine(bullet.Position.X);
        }
    }
    class GameObject
    {
        public Vector2 Position { get; set; }
        //public Vector2 GetPosition()
        //{
        //    return new Vector2(10,10);
        //}
    }
    struct Vector2
    {
        public int X, Y;//по умолчанию все члены имеют доступ public, в классах private
                        //по умолчанию у структур есть конструкторы
                        //Класс ссылочный тип, а структура это тип значения
        public Vector2(int x, int y)// если делать конструктор то нужно проинициализировать все поля!
        {
            X = x;
            Y = y;
        }
        //public Vector2 (int x): this()
        //{
        //    X = x;
        //}
    }
}
