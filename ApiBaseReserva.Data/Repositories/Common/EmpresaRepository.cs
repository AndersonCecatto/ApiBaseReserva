using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories.Common
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override IEnumerable<Empresa> GetAll()
        {
            return _apiBaseContext.Set<Empresa>().Include(x => x.Endereco).AsEnumerable();
        }
    }
}
