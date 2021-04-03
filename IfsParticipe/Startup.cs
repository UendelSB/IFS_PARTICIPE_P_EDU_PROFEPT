using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using IfsParticipe.Repositories;
using IfsParticipe.Repositories.Interfaces;
using IfsParticipe.Libraries.Sessao;
using IfsParticipe.Libraries;

namespace IfsParticipe
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
            services.AddHttpContextAccessor();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IPdiRepository, PdiRepository>();
            services.AddScoped<IDemandaRepository, DemandaRepository>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IComentarioRepository, ComentarioRepository>();
  

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Session  Configurações
            services.AddMemoryCache(); //GUARDAR OS DADOS DE SESSAO NA MEMORIA DO SERVIDOR
            services.AddSession(options =>
            {
                //configura aqui o tempo da sessao
            });
            services.AddScoped<Sessao>();
            services.AddScoped<LoginUsuario>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IfsParticipeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<IfsParticipeContext>(options => options.UseSqlServer(connection));
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Demanda}/{action=Index}/{id?}");
            });

            app.UseCookiePolicy();

        }
    }
}
