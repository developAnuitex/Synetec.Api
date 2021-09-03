using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Synetec.Api.Extensions;
using Synetec.Core.MappingProfiles;
using Synetec.Core.Services;
using Synetec.Core.Services.Interfaces;
using Synetec.DataAccess;
using Synetec.DataAccess.Repositories;
using Synetec.DataAccess.Repositories.Interfaces;
using System.Reflection;

namespace Synetec.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Synetec.Api", Version = "v1" });
            });

            services.AddDbContext<AppDbContext>(options =>
               options.UseInMemoryDatabase(databaseName: "HrDb"));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddScoped<IEmployeeService, EmployeeService>();

            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddMaps(Assembly.GetAssembly(typeof(EmployeeProfile)));
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Synetec.Api v1"));
            }

            app.UseErrorHandler();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
