using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Adapter;
using Game_KampHW.Entity;

namespace Game_KampHW.Abstract
{
    public interface IGameUserManager
    {
        void Add(GameUser gameUser);
        void Delete(GameUser gameUser);
        void Update(GameUser gameUser);
        
    }
}
