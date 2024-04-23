using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace System.API.Configuration
{
    public static class ConsulConfiguration
    {
        public static void AddConsulConfiguration(this IServiceCollection services)
        {
            var _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            services.Configure<ServiceSettings>(_config.GetSection(nameof(ServiceSettings)));

            
            var serviceProviderOption = services.BuildServiceProvider().GetService<IOptions<ServiceSettings>>();
            var serviceSettings = serviceProviderOption.Value;



            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                consulConfig.Address = new Uri(serviceSettings.ServiceDiscoveryAddress);
            }));

          
        }

        public static void UseConsul(this IApplicationBuilder app)
        {
            var _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();            
            var serviceSettings = new ServiceSettings();
            _config.Bind("ServiceSettings", serviceSettings);


            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtensions");
            var lifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();

            //var uri = new Uri(address);
            var registration = new AgentServiceRegistration()
            {
                ID = serviceSettings.ServiceName, //{uri.Port}",                
                Name = serviceSettings.ServiceName,
                Address = serviceSettings.ServiceHost, //$"{uri.Host}",
                Port = serviceSettings.ServicePort  // uri.Port
            };

            logger.LogInformation("Inicio registro servicos consul");
            consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            consulClient.Agent.ServiceRegister(registration).ConfigureAwait(true);

            lifetime.ApplicationStopping.Register(() =>
            {
                logger.LogInformation("Unregistering from Consul");
            });


        }
    }
}
