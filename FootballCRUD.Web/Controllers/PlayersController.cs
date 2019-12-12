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

namespace FootballCRUD.Web.Controllers
{
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
        };


        [HttpGet]
        public ActionResult<List<Player>> Get()
        {
            return _playerList;
        }
 
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {    
            var player = _playerList.FirstOrDefault(p => p.Id == id);
            return player;
        }
    }
}