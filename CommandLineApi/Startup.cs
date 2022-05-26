using CommandLineApi.Core.Profiles;
using CommandLineApi.Core.Services.Implementations;
using CommandLineApi.Core.Services.Interfaces;
using CommandLineApi.Extensions;
using CommandLineApi.Infrastructure.Models;
using CommandLineApi.Infrastructure.Repository.Implementation;
using CommandLineApi.Infrastructure.Repository.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandLineApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // injecting the db connection string
            services.DbContextConfiguration(Configuration);
            services.CorsConfiguration();

            //services.AddControllers();
            services.AddControllerConfiguration();

            services.SwaggerConfiguration();

            services.AddScoped<ICommandService, CommandService>();

            services.AddScoped(typeof(IGenericCommandLineRepo<>), typeof(GenericCommandLineRepo<>));

            services.AddAutoMapper(typeof(CommandLineProfile));
            /* services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1", new OpenApiInfo { Title = "CommandLineApi", Version = "v1" });
             });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CommandLineApi v1");
                //c.RoutePrefix = String.Empty;
            });

            app.UseHttpsRedirection();

            app.UseCors("CorsPolicy");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            SeedData.Seed(app);
        }
    }
}
