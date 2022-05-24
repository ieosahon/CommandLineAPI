using AutoMapper;
using CommandLineApi.Core.DTO;
using CommandLineApi.Core.Services.Interfaces;
using CommandLineApi.Core.Utilities;
using CommandLineApi.Infrastructure.Models;
using CommandLineApi.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Core.Services.Implementations
{

    public class CommandService : ICommandService
    {
        private readonly IGenericCommandLineRepo<Command> _genericCommandLineRepo;
        private readonly IMapper _mapper;

        public CommandService(IGenericCommandLineRepo<Command> genericCommandLineRepo, IMapper mapper)
        {
            _genericCommandLineRepo = genericCommandLineRepo;
            _mapper = mapper;
        }
        public Task<Response<CommandResponseDto>> GetAllCommandAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Response<CommandResponseDto>> GetCommandByIdAsync(string commandId)
        {
            var command = await _genericCommandLineRepo.GetCommandById(commandId);
            if (command == null)
            {
                throw new ArgumentException($"Command with {commandId} is not found");
            }
            var response = _mapper.Map<CommandResponseDto>(command);
            return new Response<CommandResponseDto>
            {
                Data = response,
                IsSuccess = true,
                Message = "Request is successful"

            };

        }

        public Task<Response<CommandResponseDto>> GetCommandByNameAsync(string commandName)
        {
            throw new NotImplementedException();
        }
    }
}
