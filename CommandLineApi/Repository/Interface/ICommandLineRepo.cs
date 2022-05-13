
using System.Collections.Generic;
using CommandLineApi.Models;

namespace CommandLineApi.Repository
{
    public interface ICommandLineRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
    }
}