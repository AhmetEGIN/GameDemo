using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
namespace GameDemo.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
        public string Country { get; set; }
    }
}
