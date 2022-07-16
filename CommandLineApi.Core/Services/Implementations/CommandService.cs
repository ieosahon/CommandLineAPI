using AutoMapper;
using CommandLineApi.Core.DTO;
using CommandLineApi.Core.Services.Interfaces;
using CommandLineApi.Core.Utilities;
using CommandLineApi.Infrastructure.Models;
using CommandLineApi.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CommandLineApi.Core.Services.Implementations
{

    public class CommandService : ICommandService
    {
        private readonly IGenericCommandLineRepo<Command> _genericCommandLineRepo;
        private readonly IMapper _mapper;
        private readonly ICommandLineRepository _commandLineRepository;

        public CommandService(IGenericCommandLineRepo<Command> genericCommandLineRepo, IMapper mapper, ICommandLineRepository commandLineRepository)
        {
            _genericCommandLineRepo = genericCommandLineRepo;
            _mapper = mapper;
            _commandLineRepository = commandLineRepository;
        }
       

        public async Task<Response<string>> AddCommand(CommandRequestDto commandReq)
        {
            
                var newCommand = _mapper.Map<Command>(commandReq);
                var command = await _commandLineRepository.AddCommandAsync(newCommand);
                if (command)
                {
                    return new Response<string>
                    {
                        IsSuccess = true,
                        Message = "Command added successfully",
                        ResponseCode = HttpStatusCode.OK
                    };
                }
                return new Response<string>
                {
                    IsSuccess = false,
                    Message = "Command not added",
                    ResponseCode = HttpStatusCode.BadRequest
                };
            
           
        }

        public async Task<Response<string>> DeleteCommand(Command commandId)
        {
            var command = await _genericCommandLineRepo.GetCommandById(commandId);
            if (command == null)
            {
                return new Response<string>
                {
                    IsSuccess = false,
                    Message = "Command not found",
                    ResponseCode = HttpStatusCode.BadRequest
                };
            }

            var commandDeleted = await _genericCommandLineRepo.DeleteCommand(command);
            if (commandDeleted)
            {
                return new Response<string>
                {
                    IsSuccess = true,
                    Message = "Command deleted successfully",
                    ResponseCode = HttpStatusCode.OK
                };
            }
            return new Response<string>
            {
                IsSuccess = false,
                Message = "Command not deleted",
                ResponseCode = HttpStatusCode.BadRequest
            };
        }

        public async Task<Response<IEnumerable<CommandResponseDto>>> GetAllCommandAsync()
        {
            var commands = await _genericCommandLineRepo.GetAllCommand();
            if (commands != null)
            {
                var response = _mapper.Map<IEnumerable<CommandResponseDto>>(commands);
                return new Response<IEnumerable<CommandResponseDto>>
                {
                    Data = response,
                    IsSuccess = true,
                    Message = "List of commands",
                    ResponseCode = HttpStatusCode.OK
                };
            }
            return new Response<IEnumerable<CommandResponseDto>>();



        }

        public async Task<Response<CommandResponseDto>> GetCommandByIdAsync(Command commandId)
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
                Message = "command",
                ResponseCode = HttpStatusCode.OK

            };

        }

        public async Task<Response<CommandResponseDto>> GetCommandByNameAsync(string commandName)
        {
            var command = await _genericCommandLineRepo.GetCommandByName(commandName);
            if (command == null)
            {
                throw new ArgumentException($"Command with {commandName} is not found");
            }
            var response = _mapper.Map<CommandResponseDto>(command);
            return new Response<CommandResponseDto>
            {
                Data = response ,
                IsSuccess = true,
                Message = "command",
                ResponseCode = HttpStatusCode.OK
            };
        }
    }
}
