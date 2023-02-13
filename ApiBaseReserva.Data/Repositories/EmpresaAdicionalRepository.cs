using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;

namespace ApiBaseReserva.Data.Repositories
{
    public class EmpresaAdicionalRepository : BaseRepository<EmpresaAdicional>, IEmpresaAdicionalRepository
    {
        public EmpresaAdicionalRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }
    }
}
