using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Entity;

namespace Game_KampHW.Abstract
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
