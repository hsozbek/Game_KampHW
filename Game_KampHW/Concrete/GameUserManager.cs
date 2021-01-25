using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using Game_KampHW.Abstract;
using Game_KampHW.Adapter;
using Game_KampHW.Entity;

namespace Game_KampHW.Concrete
{
    public class GameUserManager : IGameUserManager
    {
        private IGameUserCheckService _gameUserCheckService;
        public GameUserManager(IGameUserCheckService gameUserCheckService)
        {
            _gameUserCheckService = gameUserCheckService;
        }

        public GameUserManager()
        {
            
        }
        public void Add(GameUser gameUser)
        {


            if (_gameUserCheckService.Check(gameUser))
            {
                Console.WriteLine("Game user added");
                Console.WriteLine("Id : " + gameUser.Id);
                Console.WriteLine("UserId : " + gameUser.UserId);
                Console.WriteLine("FirstName : " + gameUser.FirstName);
                Console.WriteLine("LastName : " + gameUser.LastName);
                Console.WriteLine("DateofBirth : " + gameUser.DateofBirth);
                Console.WriteLine("NationalityId : " + gameUser.NationalityId);
                Console.WriteLine("\n*****BUYED GAMES*****\n");
                foreach (Game game in gameUser.BuyedGames)
                {
                    Console.WriteLine("*  " + game.Name);
                }

            }
            else
            {
                throw new Exception("Not found person");
            }


        }



        public void Delete(GameUser gameUser)
        {
            Console.WriteLine(gameUser.FirstName + " " + gameUser.LastName + " deleted !\n");

        }

        public void Update(GameUser gameUser)
        {

            Console.WriteLine("Game user updated !");
            Console.WriteLine("Id : " + gameUser.Id);
            Console.WriteLine("UserId : " + gameUser.UserId);
            Console.WriteLine("FirstName : " + gameUser.FirstName);
            Console.WriteLine("LastName : " + gameUser.LastName);
            Console.WriteLine("DateofBirth : " + gameUser.DateofBirth);
            Console.WriteLine("NationalityId : " + gameUser.NationalityId);
            Console.WriteLine("\n*****BUYED GAMES*****\n");
            foreach (Game game in gameUser.BuyedGames)
            {
                Console.WriteLine("*  " + game.Name);
            }
        }
    }
}
