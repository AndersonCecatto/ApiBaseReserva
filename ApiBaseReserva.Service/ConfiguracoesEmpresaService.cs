using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class ConfiguracoesEmpresaService : BaseService<ConfiguracoesEmpresa>, IConfiguracoesEmpresaService
    {
        public ConfiguracoesEmpresaService(IConfiguracoesEmpresaRepository configuracoesEmpresaRepository) : base(configuracoesEmpresaRepository)
        {

        }
    }
}
