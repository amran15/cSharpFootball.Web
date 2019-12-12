using Microsoft.AspNetCore.Mvc;
using FootballCRUD.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace FootballCRUD.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly List<Team> _teamList = new List<Team>()
        {
            new Team {Id = 1, Name = "Vikings", Location = "Minnesota", Coach = "Mike Zimmer"},
            new Team {Id = 2, Name = "Cardinals", Location = "Arizona", Coach = "Kliff Kingsbury"},
            new Team {Id = 3, Name = "Seahawks", Location = "Seattle", Coach = "Pete Carroll"},
            new Team {Id = 4, Name = "Eagles", Location = "Philly", Coach = "Doug Pederson"},
            new Team {Id = 5, Name = "Raiders", Location = "San Diego", Coach = "Jon Gruden"}
        }; 
        
        //GET all teams
        [HttpGet]
        public ActionResult<List<Team>> Get()
        {
            return _teamList;
        }

        [HttpGet("{id}")]
        public ActionResult<Team> Get(int id)
        {
            var team = _teamList.FirstOrDefault(t => t.Id == id);
            return team;
        }
    }
}