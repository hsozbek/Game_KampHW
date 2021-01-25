using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Abstract;
using Game_KampHW.Entity;

namespace Game_KampHW.Concrete
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " has added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " has deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " has updated");
        }
    }
}
