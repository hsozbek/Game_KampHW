using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Abstract;

namespace Game_KampHW.Entity
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
