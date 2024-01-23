using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();
            games.Add(new Game("Black & White",Gentre.Strategy));
            games.Add(new Game("The Witcher 3: Wild Hunt",Gentre.RPG));
            games.Add(new Game("Sid Miser`s Civilization 6", Gentre.Strategy));
            games.Add(new Game("Ori and whe Will of the Wisps",Gentre.Action));
        foreach(var game in games)
            {
                game.ShowInfo();
            }
        }
    }

 enum Gentre //это тип-значение именнованных констант enum
    {
        Strategy,
        RPG,
        Action
    }
    
    class Game
    {
        private string _title;
        private  Gentre _genre;
        public Game(string title, Gentre gentre)
        {
            _title = title;
            _genre = gentre;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Это игра {_title}, и её жар: {_genre}.");
        }
    }
}
