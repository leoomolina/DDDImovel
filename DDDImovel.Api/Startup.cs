using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDImovel.Domain.Repositories;
using DDDImovel.Infra.Contexts;
using DDDImovel.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DDDImovel.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // única instância desta classe 
            services.AddScoped<DDDImovelStoreDataContext, DDDImovelStoreDataContext>();

            services.AddTransient<IImovelRepository, ImovelRepository>();
            services.AddTransient<ICompradorRepository, CompradorRepository>();
            services.AddTransient<IVendedorRepository, VendedorRepository>();
            services.AddTransient<IVendaRepository, VendaRepository>();

            // Serviço básico para MVC.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
