using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
namespace GameDemo.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignRate { get; set; }
    }
}
