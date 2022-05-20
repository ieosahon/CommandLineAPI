using CommandLineApi.Infrastructure.Models;
using CommandLineApi.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Repository.Implementation
{
    public class CommandLine : ICommandLine
    {
        public IEnumerable<Command> GetAllCommand()
        {
            var commands = new List<Command>();


            return commands;
        }

        public Command GetCommandById(int Id)
        {
            var command = new Command();


            return command;
        }
    }
}
