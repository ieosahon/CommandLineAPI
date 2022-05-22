using CommandLineApi.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using FluentValidation.AspNetCore;
using CommandLineApi.Infrastructure.ModelValidationUtility;
using Microsoft.OpenApi.Models;

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

        public static void SwaggerConfiguration(this IServiceCollection service)
        {
            service.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CommandLineApi",
                    Description = "Command Line API",
                    Contact = new OpenApiContact
                    {
                        Name = "Osahon Ighodaro",
                        Email = "ieosahon@gmail.com"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Osahon open License"
                    }
                });
            });
        }
    }
}
