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
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IConfiguracoesEmpresaRepository, ConfiguracoesEmpresaRepository>();
            services.AddScoped<IMesaRepository, MesaRepository>();
            services.AddScoped<IConfiguracoesReservaRepository, ConfiguracoesReservaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IFuncionarioService, FuncionarioService>();
            services.AddScoped<IConfiguracoesEmpresaService, ConfiguracoesEmpresaService>();
            services.AddScoped<IMesaService, MesaService>();
            services.AddScoped<IConfiguracoesReservaService, ConfiguracoesReservaService>();
            services.AddScoped<IEnderecoService, EnderecoService>();

            return services;
        }
    }
}
