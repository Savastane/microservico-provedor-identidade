using Academico.Domain.Interface;
using Academico.Repository;
using Application.Library.Security.Jwt;
using Service.Seguranca;
using system.Security.API.Domain.Abstracts;
using system.Security.API.Repository;
using System.API.Service.Interface;
using systemsecurity.domain;

namespace SecurityAPI.configuration
{
    public static class InjectConfiguration
    {
        public static void AddInjectConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<JwtHandler>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPlatformRepository, PlatformRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            
            
//            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}

