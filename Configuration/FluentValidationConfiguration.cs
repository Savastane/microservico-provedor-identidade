using System.API.Application;
using System.API.Configuration;
using System.Reflection;
using FluentValidation;
using MediatR;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SecurityAPI.configuration
{
    public static class FluentValidationConfiguration
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {

            // usuario
            services.AddScoped<IValidator<AuthenticateUserRequest>, AuthenticateUserValidator>();
            services.AddScoped<IValidator<InsertUserRequest>, InsertUserValidator>();           
            
            services.AddScoped<IValidator<InsertPlatformRequest>, InsertPlatformValidator>();


            // systema
            services.AddScoped<IValidator<RoleRequest>, RoleValidator>();
            // ambiente
            services.AddScoped<IValidator<AmbienteRequest>, AmbienteValidator>();
            

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
            services.AddFluentValidationRulesToSwagger();
        }

    }
}

