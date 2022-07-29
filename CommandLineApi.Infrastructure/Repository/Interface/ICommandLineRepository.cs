﻿using CommandLineApi.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Repository.Interface
{
    public interface ICommandLineRepository 
    {
        Task AddCommandAsync(Command command);
        Task<bool> DeleteCommandAsync(string Id);
        Task<IEnumerable<Command>> GetCommandByNameAsync(string Name);
    }
}
