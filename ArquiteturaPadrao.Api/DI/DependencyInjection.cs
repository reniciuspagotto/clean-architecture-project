using ArquiteturaPadrao.Domain.Handlers;
using ArquiteturaPadrao.Domain.Repositories;
using ArquiteturaPadrao.Infra.Context;
using ArquiteturaPadrao.Infra.Repositories;
using ArquiteturaPadrao.Infra.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace ArquiteturaPadrao.Api.DI
{
    public static class DependencyInjection
    {
        public static void Resolve(IServiceCollection services)
        {
            services.AddScoped<DataContext, DataContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<CustomerHandler, CustomerHandler>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}