using System.API.Application;
using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SecurityAPI.configuration
{
    public static class MediatorConfiguration
    {
        public static void AddMediatorConfiguration(this IServiceCollection services)
        {      
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AuthenticateUserRequest).Assembly));
//            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(InsertPlataformRequest).Assembly));

            //  services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(InsertUserRequest).Assembly));


        }

    }
}

