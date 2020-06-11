using System;
using labpsi.gerenciadora.frota.infra.crosscutting.ioc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using labpsi.gerenciadora.frota.infra.crosscutting.ioc.Configurations;
using labpsi.gerenciadora.frota.application.CommandHandlers;
using MediatR;

namespace labpsi.gerenciadora.frota.api
{
    public class Startup
    {
        public Startup(IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true);

            if (env.IsDevelopment())
            {
                //TODO
                //builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettings = Configuration.GetSection("Configuracoes").Get<AppSettings>();

            services.AddCors();

            services.AddDatabaseSetup();
            services.AddDependencyInjectionSetup(appSettings);
            services.AddSwaggerSetup();
            services.AddMemoryCache();
            services.AddMediatR(typeof(CriarNovoVeiculoCommandHandler));

            services.AddControllers();

            //services.AddControllers().AddNewtonsoftJson(options =>
            //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //);



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(option => option.AllowAnyOrigin().AllowAnyHeader());
        

            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerSetup();
        }
    }
}
