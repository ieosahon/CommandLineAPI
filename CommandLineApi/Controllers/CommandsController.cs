using CommandLineApi.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using CommandLineApi.Core.DTO;
using CommandLineApi.Infrastructure.Models;

namespace CommandLineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandService _commandService;

        public CommandsController(ICommandService commandService)
        {
            _commandService = commandService;
        }
        

        [HttpGet("id")]
        public async Task<ActionResult<CommandResponseDto>> GetCommandById(string id)
        {
            try
            {
                
                var res = await _commandService.GetCommandByIdAsync(id);
                if (res == null)
                {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured we are working on it");
            }
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetCommandByName(string name)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var res = await _commandService.GetCommandByNameAsync(name);
                if (res == null)
                {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured we are working on it");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCommandAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var res = await _commandService.GetAllCommandAsync();
                if (res == null)
                {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured we are working on it");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCommand(CommandRequestDto commandRequest)
        {
            try
            {
                
                var res = await _commandService.AddCommand(commandRequest);
                if (res == null)
                {
                    return NotFound();
                }
                return Ok(res);  
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured we are working on it");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCommand(string id)
        {
            try
            {
                var res = await _commandService.DeleteCommand(id);
                if (res == null)
                {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured we are working on it");
            }
        }
    }
}
