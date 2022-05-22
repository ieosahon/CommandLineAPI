using CommandLineApi.Infrastructure.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<CommandLineDbContext>();

            // check to see if there ia data in the DB

            if (!context.Commands.Any())
            {
                context.Commands.AddRange(new Command()
                {
                    CommandId = Guid.NewGuid().ToString(),
                    CommandName = "Add Migration",
                    CommandSnippet = "Add-Migration [Migration_Name]",
                    OS = "All",
                    TargetEnvironment = "Entity FrameWork Core"
                },
                new Command()
                {
                    CommandId = Guid.NewGuid().ToString(),
                    CommandName = "Update Database",
                    CommandSnippet = "Update-Migration",
                    TargetEnvironment = "Entity Framework Core",
                    OS = "All"
                },
                new Command()
                {
                    CommandId = Guid.NewGuid().ToString(),
                    CommandName = "Drop database",
                    CommandSnippet = "Drop-Databse",
                    TargetEnvironment = "Entity Framework Core",
                    OS = "All"
                });
                context.SaveChanges();
            }
        }
    }
}
