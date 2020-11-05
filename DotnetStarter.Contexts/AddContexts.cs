using DotnetStarter.Contexts;
using DotnetStarter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HEC.EasyProfile.Backend
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration Configuration)
        {

            DatabaseSettings Databasesettings = new DatabaseSettings();
            Configuration.GetSection("ConnectionString").Bind(Databasesettings);

            /*
             * Hier die Contexte hinzufügen
             *
             * services.AddDbContext<CHANGEMEContext>(options => options.UseSqlServer(Databasesettings.DatabaseString));
             *
             **/

            return services;
        }
    }
}
