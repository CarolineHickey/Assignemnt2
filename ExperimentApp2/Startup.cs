using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExperimentApp2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //Create a nice little page 
            }

                app.UseDeveloperExceptionPage();

                app.UseNodeModules();

                app.UseStaticFiles();

                app.UseRouting(); //turns on routing in MVC

                app.UseEndpoints(cfg =>

            {
                cfg.MapControllerRoute("Default", //This is a name 
                    "{controller}/{action}/{id?}",
                     new { controller = "Home", action = "Index" }); // This is our default if the above does not work. //coding in convention. It already knows
            }

            ); //what are we going to do in the end. What are we eventually going to serve
        }
    }
}
