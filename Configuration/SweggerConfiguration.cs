using Microsoft.OpenApi.Models;
using systemsecurity.domain;

namespace SecurityAPI.configuration
{
    public static class SweggerConfiguration
    {
        public static void AddSweggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API Segurança",
                    Description = "O objetivo é prover segurança de API, usando  JWT para diversas aplicações",
                    
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                    
                });
            });

        }
    }
}
