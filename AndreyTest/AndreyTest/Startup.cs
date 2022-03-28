using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AndreyTest
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddControllers();
            services.AddMvc();
            services.AddDbContext<ProjectDbContext>(
                o => o.UseSqlite($"Filename={Configuration["DbName"]};"),
                ServiceLifetime.Transient);
            services.AddTransient<DbManager>();
        }

        public void Configure(IConfiguration configuration, IApplicationBuilder app, IWebHostEnvironment env)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine("ProjectSettings.json")).AddConfiguration(configuration).Build();
            Configuration = builder.Build();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}