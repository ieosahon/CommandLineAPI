using CommandLineApi.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using FluentValidation.AspNetCore;
using CommandLineApi.Infrastructure.ModelValidationUtility;

namespace CommandLineApi.Extensions
{
    public static class ExtensionServices
    {
        public static void DbContextConfiguration(this IServiceCollection service, IConfiguration configuration) => service.AddDbContext<CommandLineDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("DbConn"), db => db.MigrationsAssembly("CommandLineApi")));

        public static void CorsConfiguration(this IServiceCollection service) => service.AddCors(
            opt =>
            {
                opt.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );
            });

        public static void AddControllerConfiguration(this IServiceCollection service) => service.AddControllers().AddFluentValidation(fv =>
        {
            //fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            fv.RegisterValidatorsFromAssemblyContaining<CommandItemValidator>();
        });
    }
}
