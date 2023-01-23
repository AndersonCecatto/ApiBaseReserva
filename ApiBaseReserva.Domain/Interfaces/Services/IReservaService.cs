using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IReservaService : IBaseService<Reserva>
    {
        Reserva Add(ReservaDto reservaDto);
        ReservaDto Update(ReservaDto reservaDto);
    }
}
