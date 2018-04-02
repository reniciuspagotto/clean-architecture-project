using ArquiteturaPadrao.Api.DI;
using ArquiteturaPadrao.Infra.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace ArquiteturaPadrao.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("cnstr");

            services.AddEntityFrameworkSqlServer().AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            services.AddMvc();
            services.AddApiVersioning();

            DependencyInjection.Resolve(services);

            services.AddResponseCompression();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "APIs",
                    Description = "Available Web APIs",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Arquitetura Padrão", Email = "arquitetura@teste.com", Url = "www.arquitetura.com" }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseResponseCompression();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });
        }
    }
}
