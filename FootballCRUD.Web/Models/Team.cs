using FootballCRUD.Web.Models;

namespace FootballCRUD.Web.Models
{
    public class Team
    {
        public int Id { get; set; } // use Guid instead of int for the Id
        public string Name { get; set; }
        public string Location { get; set; }
        public string Coach { get; set; }
    }
}