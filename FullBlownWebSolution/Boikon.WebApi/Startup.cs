using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boikon.Interfaces;
using Boikon.WebApi.Middleware;
using Boikon.WebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Boikon.Repository.InMemory;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Boikon.WebApi
{
    public class Startup
    {
        // Registreer hier zaken voor de DI
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddControllers(opts=> {
                opts.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            });
        }

        // Knutsel hier uw request pipeline in elkaar
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
