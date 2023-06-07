using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using finalMVC.Models;

namespace finalMVC
{
    public class Startup
    {
        /*  public void ConfigureServices(IServiceCollection services)
         {
            services.AddDbContext<SchoolCoreDBContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase")));
         }
         public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<SchoolCoreDBContext>();*/
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<SchoolCoreDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               // app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
        /*    app.MapControllerRoute(
          name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");*/
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
