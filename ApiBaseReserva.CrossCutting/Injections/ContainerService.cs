using ApiBaseReserva.Data.Repositories;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBaseReserva.CrossCutting.Injections
{
    public static class ContainerService
    {
        public static IServiceCollection AddApplicationServicesCollections(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddServices();
            services.AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IClienteService, ClienteService>();

            return services;
        }
    }
}
