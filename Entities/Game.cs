using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Game : IEntity
    {
        public string NameOfGame { get; set; }
        public int UnitPrice { get; set; }
    }
}
