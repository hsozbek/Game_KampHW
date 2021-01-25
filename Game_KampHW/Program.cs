using System;
using System.Collections.Generic;
using Game_KampHW.Abstract;
using Game_KampHW.Adapter;
using Game_KampHW.Concrete;
using Game_KampHW.Entity;

namespace Game_KampHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text_GameUserManager2();  // Oyun satın alma (GameUser property(BuyedGames) si değiştirilip güncellenmiştir 
            //Test_GameManager();       // Oyun ekleme,silme,güncelleme
            //Test_CampaignManager();   // Kampanya ekleme,silme,güncelleme.Kampanya fiyat listendiğinde istenirse uygulanır veritabanında ürün fiyatına yansımaz
            //Test_GameUserManager();   // Yeni kullanıcı ekleme(eDevlet kontrol similatörlü), silme, güncelleme
        }

        private static void Text_GameUserManager2()
        {
            GameUser gameUser1 = new GameUser() //veri tabanından çekiler kullanıcı
            {
                Id = 1, UserId = "game123", FirstName = "Selçuk", LastName = "Özbek", DateofBirth = new DateTime(1987, 1, 13),
                NationalityId = "12345678910", BuyedGames = new List<Game>() { }
            };
            IGameUserManager gameUserManager = new GameUserManager();

            gameUser1.BuyedGames.Add(new Game() {Id = 1, Name = "Counter Strike", Price = 29.90m, Type = "FPS"});
            gameUserManager.Update(gameUser1);
        }

        private static void Test_GameManager()
        {
            Game game1 = new Game() { Id = 1, Name = "Counter Strike", Type = "FPS", Price = 29.90m };
            IGameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);
        }

        private static void Test_CampaignManager()
        {
            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                Name = "BlackFriday",
                GameId = 1,
                DiscountRate = 0.2F,
                StartingDate = new DateTime(2021, 1, 25),
                ExpretionDate = new DateTime(2021, 2, 25)
            };

            ICampaignManager campaignManager = new CampaingManager();
            campaignManager.Add(campaign1);
            }

        private static void Test_GameUserManager()
        {
            GameUser gameUser1 = new GameUser()
            {
                Id = 1,
                UserId = "game123",
                FirstName = "Selçuk",
                LastName = "Özbek",
                DateofBirth = new DateTime(1987, 1, 13),
                NationalityId = "12345678910",
                BuyedGames = new List<Game>() {}
            };
             
            IGameUserManager gameUserManager = new GameUserManager(new GameUserCheckServiceEDevlet());
            gameUserManager.Add(gameUser1);
            gameUserManager.Delete(gameUser1);
            gameUserManager.Update(gameUser1);
        }
    }
}
