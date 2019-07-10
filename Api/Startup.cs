using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseApi.Aplicacao;
using BaseApi.Aplicacao.Contratos;
using BaseApi.Aplicacao.Servicos;
using BaseApi.Infra.Contratos;
using BaseApi.Infra.Servicos.ServicoDePersistencia;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseApi.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<VariaveisDeAmbiente>(this.Configuration);
            services.AddDbContext<ContextoEF>(options => { options.UseNpgsql(this.Configuration.GetValue<string>("ConnectionString")); });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // servicos da camada de infra
            services.AddScoped(typeof(IServicoDePersistencia), typeof(UnidadeDeTrabalhoEF));

            // servicos da camada de aplicacao
            services.AddScoped(typeof(IServicoDeUsuario), typeof(ServicoDeUsuario));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
