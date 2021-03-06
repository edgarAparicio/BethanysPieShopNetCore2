﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.BethanysPieShop.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShopNetCore2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DbContextBethanysPieShop>(opciones => opciones.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IDataBetahysPieShop, DataBethanysPieShop>();
            services.AddTransient<IDataFeedback, DataFeedback>();
            //services.AddTransient<IDataBetahysPieShop, SimuladorRepositorioBethanysPieShop>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication();  //Middleware de ASP.NET Core para la autenticacion
            app.UseMvc(routes =>
            {
                routes.MapRoute
                (
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}"
                );
            }
            );
        }
    }
}
