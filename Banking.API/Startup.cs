using Banking.API.Database;
using Banking.API.Interfaces;
using Banking.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // konfiguracja aplikaji
        public void ConfigureServices(IServiceCollection services)
        {
            // rejestracja biblioteki NewtonSoft Json
            services.AddControllers().AddNewtonsoftJson();

            services.AddAuthentication();


            // rejestracja mappera do bazy danych
            services.AddDbContext<BankContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("BankConnection"),
                    assembly => assembly.MigrationsAssembly(typeof(BankContext).Assembly.FullName));
                
            });

            // rejestracja serwisów
            services.AddScoped<IStudentService, StudentService>();



        }





        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
