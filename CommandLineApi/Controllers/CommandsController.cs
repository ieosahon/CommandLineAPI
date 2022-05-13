
using System.Collections.Generic;
using System.Threading.Tasks;
using CommandLineApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandLineApi.Controllers
{
    [ApiController]
    [Route("api/commands")]
    public class CommandsControllers : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Command>>> GetAllCommands()
        {
            
        }

        [HttpGet]
        public async Task<ActionResult<Command>> GetCommandById(int Id)
        {
            
        }

    }
}