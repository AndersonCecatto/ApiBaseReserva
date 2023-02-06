using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        IEnumerable<Reserva> GetReservasPorUsuarioId(long usuarioId);
    }
}
