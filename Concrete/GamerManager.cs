using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;
using GameDemo.Adapter;

namespace GameDemo.Concrete
{
    public class GamerManager : IBaseService<Gamer>
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
