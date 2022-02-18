using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName.ToUpper() == "ALP" && gamer.LastName == "KURT" && gamer.DateOfBirth.Year == 2001 && gamer.NationalityId == 73123124124)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
