using System;
using FootballCRUD.Web.Models.Enums;

namespace FootballCRUD.Web.Models
{
    public class Player
    {
        public int Id { get; set; } // change to Guid instead of Id

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        public Positions Position { get; set; } 
    }
}