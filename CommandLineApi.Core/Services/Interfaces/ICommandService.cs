using CommandLineApi.Core.DTO;
using CommandLineApi.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Core.Services.Interfaces
{
    public interface ICommandService
    {
        Task<Response<CommandResponseDto>> GetCommandByIdAsync(string commandId);
        Task<Response<CommandResponseDto>> GetCommandByNameAsync(string commandName);
        Task<Response<IEnumerable<CommandResponseDto>>> GetAllCommandAsync();
    }
}
