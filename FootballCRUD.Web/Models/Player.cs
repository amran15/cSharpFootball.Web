using System;
using FootballCRUD.Web.Models.Enums;

namespace FootballCRUD.Web.Models
{
    public class Player
    {
        public int Id { get; set; } // change back to Guid after researching it

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        public Positions Position { get; set; } //make public enum that holds all the position in FB 
    }
}