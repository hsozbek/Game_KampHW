using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Abstract;

namespace Game_KampHW.Entity
{
    public class Campaign:IEntity
    {
        public int Id{ get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public float DiscountRate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ExpretionDate { get; set; }
        
    }
}
