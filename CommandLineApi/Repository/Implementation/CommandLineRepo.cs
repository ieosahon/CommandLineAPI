

using System.Collections.Generic;
using CommandLineApi.Models;

namespace CommandLineApi.Repository
{
    public class CommandLineRepo : ICommandLineRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}