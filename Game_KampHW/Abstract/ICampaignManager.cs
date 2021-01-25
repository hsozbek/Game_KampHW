using Game_KampHW.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_KampHW.Abstract
{
    public interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Uptade(Campaign campaign);
    }
}
