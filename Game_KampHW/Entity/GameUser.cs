using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Abstract;

namespace Game_KampHW.Entity
{
    public class GameUser:IEntity
    {
        public int Id { get; set; }
        public List<Game> BuyedGames { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateofBirth { get; set; }
        

    }
}
