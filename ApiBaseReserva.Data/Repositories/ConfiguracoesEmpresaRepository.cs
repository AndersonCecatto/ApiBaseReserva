using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;

namespace ApiBaseReserva.Data.Repositories
{
    public class ConfiguracoesEmpresaRepository : BaseRepository<ConfiguracoesEmpresa>, IConfiguracoesEmpresaRepository
    {
        public ConfiguracoesEmpresaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }
    }
}
