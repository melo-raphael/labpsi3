using Microsoft.Extensions.DependencyInjection;
using System;

namespace labpsi.gerenciadora.frota.infra.crosscutting.ioc.Configurations
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services, AppSettings appSettings)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services, appSettings);
        }
    }
}
