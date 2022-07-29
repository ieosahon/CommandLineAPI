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
        private readonly CommandLineDbContext _commandLineDbContext;
        public CommandLineRepository(CommandLineDbContext commandLineDbContext) : base(commandLineDbContext)
        {
            _commandLineDbContext = commandLineDbContext;
        }

        public async Task AddCommandAsync(Command command)
        {
            await AddCommand(command);
            //await _commandLineDbContext.SaveChangesAsync();
            //await _commandLineDbContext.AddAsync(command);
            await _commandLineDbContext.SaveChangesAsync();
        }
        
        public async Task<bool> DeleteCommandAsync(string Id)
        {
            var command =await GetCommandById(Id);
            if (command == null)
            {
                throw new Exception("Command not found");
            }
            return await DeleteCommand(command);
        }

        public async Task<IEnumerable<Command>> GetCommandByNameAsync(string Name)
        {
            /*var command = await GetCommandByName(Name);
            if (command == null)
            {
                throw new Exception("Command not found");
            }
            return command;*/

            var command = await _commandLineDbContext.Commands.FindAsync(Name);
            if (command == null)
            {
                throw new Exception("Command not found");
            }
            return (IEnumerable<Command>)command;
        }
    }

}
