using Academico.Domain.Interface;
using Academico.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Options;

namespace Academico.System.Configuration
{
    public static class SqlServerConfiguration
    {


        public static void AddSystemContextConfiguration(this IServiceCollection services)
        {
            var _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            services.AddDbContext<SystemContext>(options =>
                options.UseSqlServer(_config.GetConnectionString("SystemConnection"))
            );
        }

        //public static void AddCensoContextConfiguration(this IServiceCollection services)
        //{
        //    var _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        //    services.AddDbContext<CensoContext>(options =>
        //        options.UseSqlServer(_config.GetConnectionString("CensoConnection"))
        //    );



        //}
    }
}
