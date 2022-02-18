using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Concrete;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
        void ToReturn(Gamer gamer, Game game, Campaign campaign);
    }
}
