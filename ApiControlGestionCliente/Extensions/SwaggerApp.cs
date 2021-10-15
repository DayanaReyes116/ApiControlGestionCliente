using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.IO;
using System.Reflection;

namespace Api.Extesions
{
    public static class SwaggerApp
    {
        /// <summary>
        /// Parametrizar la inicialización del Swagger de manera personalizada.
        /// </summary>
        /// <param name="services">Colección de Servicios de la aplicación.</param>
        /// <returns>Colección de servicios con el swagger adicionado.</returns>
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Control Gestión de Clientes",
                    Version = "v1"
                });

            });

            return services;
        }

        
    }
}
