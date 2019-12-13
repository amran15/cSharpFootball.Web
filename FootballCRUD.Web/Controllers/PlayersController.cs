using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using FootballCRUD.Web.Models.Enums;
using FootballCRUD.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//using System.Runtime.InteropServices;

namespace FootballCRUD.Web.Controllers
{
//    [Guid("9245fe4a-d402-451c-b9ed-9c1a04247482")]
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly List<Player> _playerList = new List<Player>
        {
            new Player {Id = 1, FirstName = "Aaron", LastName = "Rogers", Position = Positions.Qb},
            new Player {Id = 2, FirstName = "Pharaoh", LastName = "Cooper", Position = Positions.Wr},
            new Player {Id = 3, FirstName = "Charles", LastName = "Clay", Position = Positions.Rb},
            new Player {Id = 4, FirstName = "Darren", LastName = "Waller", Position = Positions.Te},
            new Player {Id = 5, FirstName = "Rodney", LastName = "Smith", Position = Positions.K},
            new Player {Id = 6, FirstName = "William", LastName = "Bill", Position = Positions.Def},
        };

         
        [HttpGet] //Gets all players
        public ActionResult<List<Player>> GetPlayers()
        {
            return _playerList;
        }

        [HttpGet("{id}")] // use id to get single player 
        public ActionResult<Player> GetPlayer(int id)
        {
            var player = _playerList.FirstOrDefault(p => p.Id == id); //Linq -- map 
            return player;
        }

        [HttpPost]
        public ActionResult<List<Player>> AddNewPlayer(Player player) // add paras to add a new player to the list
        {
            _playerList.Add(player);

            return Ok(_playerList); // return a status code of either 200 or 400
        }

        [HttpDelete("{id}")] public ActionResult<List<Player>> DeletePlayer(int id) // use id to remove a particular player
        {
            var playerToRemove = _playerList.SingleOrDefault(p => p.Id == id);
            _playerList.Remove(playerToRemove);
            // return statusCode of 204 ?
            return Ok(_playerList);
        }
    }
}