using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Adapter;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class CampaignManager : IBaseService<Campaign>
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added: " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted: " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated: " + campaign.CampaignName);
        }
    }
}