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
            new Team {Id = 4, Name = "Eagles", Location = "Philadelphia", Coach = "Doug Pederson"},
            new Team {Id = 5, Name = "Raiders", Location = "Oakland", Coach = "Jon Gruden"}
        }; 
        
        //GET all teams
        [HttpGet] //get all teams 
        public ActionResult<List<Team>> Get()
        {
            return _teamList;
        }

        [HttpGet("{id}")]
        public ActionResult<Team> Get(int id) // use id to get a particular team
        {
            var team = _teamList.FirstOrDefault(t => t.Id == id);
            return team;
        }

        [HttpPost]
        public ActionResult<List<Team>> AddNewPlayer(Team team) // adding parameters to add a new team to the team list 
        {
            _teamList.Add(team);

            return Ok(_teamList); // return a status code of either 200 or 400
        }
        
        [HttpDelete("{id}")] public ActionResult<List<Team>> DeleteTeam(int id) // use id to remove a single team 
        {
            var teamToRemove = _teamList.SingleOrDefault(t => t.Id == id);
            _teamList.Remove(teamToRemove);
            // return statusCode of 204 ?
            return Ok(_teamList); 
        }

    }
}