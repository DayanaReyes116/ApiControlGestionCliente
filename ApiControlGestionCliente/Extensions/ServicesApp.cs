using Application.Interfaces.Services;
using DataSql.Repositories;
using Domain.Clientes;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Extesions
{
    public static class ServicesApp
    {
        public static IServiceCollection AddServicesApp(this IServiceCollection services)
        {
            //Services Aplication
            services.AddScoped<IGestionClienteService, GestionClienteService>();

            // services Infrastructure Data 
            services.AddScoped<IGestionClienteRepository, GestionClienteRepository>();

            return services;
        }
    }
}
