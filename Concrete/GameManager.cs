using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GameManager : IBaseService<Game>
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added:  " + game.NameOfGame);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted: " + game.NameOfGame);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated: " + game.NameOfGame);
        }
    }
}
