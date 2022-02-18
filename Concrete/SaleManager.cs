using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        private IGamerCheckService _gamerCheckService;

        public SaleManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        private double Cost(Game game, Campaign campaign)
        {
            return Math.Round(game.UnitPrice * campaign.CampaignRate, 2);
        }
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("{0} {1} bought {2} with campaign {3}. Cost: {4} $", gamer.FirstName, gamer.LastName, game.NameOfGame, campaign.CampaignName, Cost(game, campaign));
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }

        }

        public void ToReturn(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Refund has been made.");
        }
    }
}
