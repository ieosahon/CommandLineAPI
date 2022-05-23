using CommandLineApi.Core.DTO;
using CommandLineApi.Core.Services.Interfaces;
using CommandLineApi.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Core.Services.Implementations
{
    public class CommandService : ICommandService
    {
        public Task<Response<CommandResponseDto>> GetAllCommandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<CommandResponseDto>> GetCommandByIdAsync(string commandId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CommandResponseDto>> GetCommandByNameAsync(string commandName)
        {
            throw new NotImplementedException();
        }
    }
}
