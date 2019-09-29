﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {

            routes.MapRoute(
                name: "plusTen",
                template: "{controller}/addTenToNumber/{*number}",
                defaults: new {controller = "Calc", action = "PlusTen"});

            routes.MapRoute(
                name: "messages",
                template: "say/{*messages}",
                defaults: new {controller="Messages", action="ShowMessage" });

            routes.MapRoute(
                name: "default",
                template: "{controller=Hello}/{action=Index}/{id?}");
                    
            });

            app.UseStaticFiles();
        }
    }
}
