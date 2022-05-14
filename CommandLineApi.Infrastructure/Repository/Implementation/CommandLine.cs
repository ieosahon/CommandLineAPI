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
            var commands = new List<Command>()
            {
               new Command()
               {
                   CommandId = 1,
                CommandName = "Add Migration",
                CommandSnippet = "Add-Migration [Migration_Name]",
                OS = "All",
                TargetEnvironment = "Entity FrameWork Core"
               },

               new Command()
               {
                   CommandId = 2,
                   CommandName = "Update Database",
                   CommandSnippet= "Update-Migration",
                   TargetEnvironment = "Entity Framework Core",
                   OS = "All"
               },

               new Command()
               {
                   CommandId = 3,
                   CommandName = "Drop database",
                   CommandSnippet = "Drop-Databse",
                   TargetEnvironment = "Entity Framework Core",
                   OS="All"
               }
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            var command = new Command()
            {
                CommandId = 1,
                CommandName = "Add Migration",
                CommandSnippet = "Add-Migration [Migration_Name]",
                OS = "All",
                TargetEnvironment = "Entity FrameWork Core"
            };
            return command;
        }
    }
}
