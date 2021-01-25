using System;
using System.Collections.Generic;
using System.Text;
using Game_KampHW.Abstract;
using Game_KampHW.Entity;

namespace Game_KampHW.Concrete
{
    class CampaingManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has added !");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has deleted !");
        }

        public void Uptade(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " has updated !");
        }
    }
}
