using CommandLineApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Context
{
    public class CommandLineDbContext : DbContext
    {
        public CommandLineDbContext(DbContextOptions<CommandLineDbContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
