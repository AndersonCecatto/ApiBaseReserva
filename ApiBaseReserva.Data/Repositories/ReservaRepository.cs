using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Reserva> GetReservasPorUsuarioId(long usuarioId)
        {
            return _apiBaseContext.Set<Reserva>().Include(x => x.Empresa).Where(x => x.UsuarioId == usuarioId);
        }
    }
}
