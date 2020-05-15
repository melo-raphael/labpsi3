using labpsi.gerenciadora.frota.infra.data.Context;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace labpsi.gerenciadora.frota.infra.crosscutting.ioc.Configurations
{
    public static class DataBaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<ApplicationDbContext>(ServiceLifetime.Scoped);
        }
    }
}
