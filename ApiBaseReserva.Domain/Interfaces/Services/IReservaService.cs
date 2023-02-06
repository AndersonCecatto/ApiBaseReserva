using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IReservaService : IBaseService<Reserva>
    {
        Reserva Add(ReservaDto reservaDto);
        ReservaDto Update(ReservaDto reservaDto);
        IEnumerable<Reserva> GetReservasPorUsuarioId(long UsuarioId);
    }
}
