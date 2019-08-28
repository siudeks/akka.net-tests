using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
            // Add route conventions
            // https://docs.microsoft.com/en-us/aspnet/core/razor-pages/razor-pages-conventions?view=aspnetcore-2.2
            .AddRazorPagesOptions(options =>
            {
                //options
                //options. .Conventions
                //options.Conventions.AddFolderRouteModelConvention("/OtherPages", model => { ... });
                //options.Conventions.AddPageRouteModelConvention("/About", model => { ... });
                //options.Conventions.AddPageRoute("/Contact", "TheContactPage/{text?}");
                //options.Conventions.AddFolderApplicationModelConvention("/OtherPages", model => { ... });
                //options.Conventions.AddPageApplicationModelConvention("/About", model => { ... });
                //options.Conventions.ConfigureFilter(model => { ... });
                //options.Conventions.ConfigureFilter(... );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();

        }
    }
}
