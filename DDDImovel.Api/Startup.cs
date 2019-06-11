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
            //AddScoped funciona como um Singleton, ou seja, uma única instância desta classe 
            services.AddScoped<DDDImovelStoreDataContext, DDDImovelStoreDataContext>();

            //AddTransient fornece instâncias de cada Interface quando forem necessitadas
            //Ex.: No ImovelController temos IImovelRepository, esta interface quando requisitada
            //será "abastecida" com uma implementação de "ImovelRepositoryPersistence2" por exemplo.
            //Ou por qualquer outra implementação do repositório que for necessário.
            services.AddTransient<IImovelRepository, ImovelRepository>();

            //Serviço básico para MVC.
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
