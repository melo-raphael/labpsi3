using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using labpsi.gerenciadora.frota.domain.SeedWork;
using labpsi.gerenciadora.frota.infra.data;
using labpsi.gerenciadora.frota.infra.data.Context;
using labpsi.gerenciadora.frota.infra.data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace labpsi.gerenciadora.frota.infra.crosscutting.ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, AppSettings appSettings)
        {
            RegisterData(services);
            RegisterEnvironment(services, appSettings);
            RegisterMediatR(services);
        }


        private static void RegisterData(IServiceCollection services)
        {
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ApplicationDbContext>();
        }

        private static void RegisterMediatR(IServiceCollection services)
        {
            //services.AddScoped<IRequestHandler<RegisterNewUserCommand, UserResponseDto>, RegisterNewUserCommandHandler>();
        }

        private static void RegisterEnvironment(IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton(x => appSettings);
        }


    }
}
