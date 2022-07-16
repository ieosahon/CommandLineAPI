using CommandLineApi.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Repository.Interface
{
    public interface ICommandLineRepository 
    {
        Task<bool> AddCommandAsync(Command command);
        Task<bool> DeleteCommandAsync(Command Id);
    }
}
