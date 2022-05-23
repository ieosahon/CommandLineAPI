using CommandLineApi.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Repository.Interface
{
    public interface IGenericCommandLineRepo<T> where T : class
    {
        Task<T> GetCommandById(string Id);

        Task<IEnumerable<T>> GetAllCommand();
    }
}
