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
using Microsoft.OpenApi.Models;
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
        readonly string CorsOrigins = "_corsOrigins";

        // konfiguracja aplikaji
        public void ConfigureServices(IServiceCollection services)
        {
            // cors => omini?cie zabezpiecznia API (pozwalamy na: ka?dy adres IP, ka?dy rodzaj requestu, ka?dy header)
            services.AddCors(options =>
            {
                options.AddPolicy(CorsOrigins,
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });

            // rejestracja biblioteki NewtonSoft Json
            services.AddControllers().AddNewtonsoftJson();

            services.AddAuthentication();


            // rejestracja mappera do bazy danych
            services.AddDbContext<BankContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("BankConnection"),
                    assembly => assembly.MigrationsAssembly(typeof(BankContext).Assembly.FullName));
                
            });


            // interfejs Swagger
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "San Bank API", Version = "v1" });
            });

            // rejestracja serwis?w
            services.AddScoped<IMainPageService, MainPageService>();
            services.AddScoped<IAuthService, AuthService>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors(CorsOrigins);
            app.UseRouting();

            // swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "San Bank API");
            });


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
