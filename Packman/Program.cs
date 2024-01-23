using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool exitgame = true;
            char[,] map = ReadMap("Map.txt");
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);
            int packmanX = 1;
            int pacmanY = 3;
            int score = 0;
            Task.Run(() =>
            {
                while (true)
                {
                    pressedKey = Console.ReadKey();
                }
            });
            while (exitgame)
            {
                Console.Clear();
                HandleInput(pressedKey, ref packmanX, ref pacmanY, map, ref score, ref exitgame);
                Console.ForegroundColor = ConsoleColor.Blue;
                DrawMap(map);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(packmanX, pacmanY);
                Console.Write("@");
                //Thread.Sleep(1000);        
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 8);
                Console.Write($"Ваш результат: {score}");
                Console.WriteLine("\nДля выхода с игры нажмите клавишу Esc.");

                //pressedKey = Console.ReadKey();
                Thread.Sleep(1000);
            }
        }
        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int packmanX, ref int packmanY, char[,] map, ref int score, ref bool exitgame)
        {
            int[] direction = GetDirection(pressedKey, ref exitgame);
            int nextPackmanPositionX = packmanX + direction[0];
            int nextPackmanPositoinY = packmanY + direction[1];
            char nextcell = map[nextPackmanPositionX, nextPackmanPositoinY];
            if (nextcell == ' ')
            {
                packmanX = nextPackmanPositionX;
                packmanY = nextPackmanPositoinY;

            }
            else if (nextcell == '.')
            {
                packmanX = nextPackmanPositionX;
                packmanY = nextPackmanPositoinY;
                score++;
                map[nextPackmanPositionX, nextPackmanPositoinY] = ' ';
            }
            //if (pressedKey.Key == ConsoleKey.UpArrow)
            //{
            //    packmanY -= 1;
            //}
            //else if (pressedKey.Key == ConsoleKey.DownArrow)
            //{
            //    packmanY += 1;
            //}
            //else if(pressedKey.Key == ConsoleKey.LeftArrow)
            //{
            //    packmanX -= 1;
            //}
            //else if(pressedKey.Key == ConsoleKey.RightArrow)
            //{
            //    packmanX += 1;
            //}  
        }
        private static int[] GetDirection(ConsoleKeyInfo pressedKey, ref bool exitgame)
        {
            int[] direction = { 0, 0 };
            if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                direction[1] = -1;
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                direction[1] = 1;
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                direction[0] = -1;
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                direction[0] = 1;
            }
            else if (pressedKey.Key == ConsoleKey.Escape)
            {
                exitgame = false;
            }
            return direction;
        }
        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");
            }
        }
        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");
            char[,] map = new char[GetMaxLengthOfLine(file), file.Length];
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = file[y][x];
                }

            }
            return map;

        }
        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (var line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }
    }
}
