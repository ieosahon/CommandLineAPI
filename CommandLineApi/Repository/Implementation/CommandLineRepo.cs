

using System.Collections.Generic;
using CommandLineApi.Models;

namespace CommandLineApi.Repository
{
    public class CommandLineRepo : ICommandLineRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command 
                {
                    CommandId      = 1,
                    CommandCode    = "world",
                    CommandUsage   = "hello world",
                    UseEnvironment = "hello",
                    OS             = "all" 
                },

                new Command 
                {
                    CommandId      = 2,
                    CommandCode    = "osi",
                    CommandUsage   = "hello osi",
                    UseEnvironment = "hello",
                    OS             = "all"
                }
            };
        }

        public Command GetCommandById(int Id)
        {
            return new Command
            {
                CommandId      = 1,
                CommandCode    = "world",
                CommandUsage   = "hello world",
                UseEnvironment = "hello",
                OS             = "all" 
            };
        }
    }
}