using Game_KampHW.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_KampHW.Adapter
{
    public class GameUserCheckServiceEDevlet : IGameUserCheckService
    {
        public bool Check(GameUser gameUser)
        {
            return true;    //eDevletten bilgilerin doğruluğu kontrol edilip true değeri dönmüştür.
            //return true;  //eDevletten bilgilerin doğruluğu kontrol edilip false değeri dönmüştür.
        }
    }
}
