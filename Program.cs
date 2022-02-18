using System;
using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Concrete;
using GameDemo.Entities;
namespace GameDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { Id = 3, FirstName = "Ahmet", LastName = "EGİN", Country = "Turkey", DateOfBirth = new DateTime(2001, 12, 17), NationalityId = 12345678906 };
            Gamer gamer2 = new Gamer { Id = 8, FirstName = "Engin", LastName = "DEMİROĞ", Country = "Turkey", DateOfBirth = new DateTime(1985, 1, 6), NationalityId = 1234567896 };
            Gamer gamer3 = new Gamer { Id = 9, FirstName = "Alp", LastName = "KURT", Country = "Turkey", DateOfBirth = new DateTime(2001, 8, 26), NationalityId = 73123124124 };
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            GamerManager gamerManager2 = new GamerManager();
            gamerManager2.Delete(gamer2);


            Game game1 = new Game() { NameOfGame = "Grand Theft Auto:5", UnitPrice = 67 };
            Game game2 = new Game { NameOfGame = "Call of Duty", UnitPrice = 56 };
            Game game3 = new Game { NameOfGame = "Cyberpunk 2077", UnitPrice = 250 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            Campaign campaign1 = new Campaign { CampaignName = "Happy New Year", Id = 2, CampaignRate = 0.7 };
            Campaign campaign2 = new Campaign { CampaignName = "Student", Id = 1, CampaignRate = 0.5 };
            Console.WriteLine("--------------------------------");
            SaleManager saleManager = new SaleManager(new MernisServiceAdapter());
            saleManager.Sale(gamer1, game1, campaign2);
            SaleManager saleManager2 = new SaleManager(new GamerCheckManager());
            saleManager2.Sale(gamer3, game3, campaign1);
            SaleManager saleManager3 = new SaleManager(new MernisServiceAdapter());
            saleManager3.Sale(gamer2, game2, campaign2);
        }
    }
}
