using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Cidade> BuscarPorIdUf(long estadoId)
        {
            return _apiBaseContext.Set<Cidade>().Include(x => x.Estado).Where(x => x.Estado.Id == estadoId);
        }
    }
}
