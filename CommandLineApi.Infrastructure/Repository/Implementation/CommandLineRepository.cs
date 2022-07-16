using CommandLineApi.Infrastructure.Context;
using CommandLineApi.Infrastructure.Models;
using CommandLineApi.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Repository.Implementation
{
    public class CommandLineRepository : GenericCommandLineRepo<Command>, ICommandLineRepository
    { 
        public CommandLineRepository(CommandLineDbContext commandLineDbContext) : base(commandLineDbContext)
        {
        }

        public async Task<bool> AddCommandAsync(Command command)
        {
            return await AddCommand(command);
        }

        public async Task<bool> DeleteCommandAsync(Command Id)
        {
            var command =await GetCommandById(Id);
            if (command == null)
            {
                throw new Exception("Command not found");
            }
            return await DeleteCommand(command);
        }
    }

}
