using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        IEnumerable<Reserva> BuscarPorUsuarioId(long usuarioId);
        IEnumerable<Reserva> BuscarPorEmpresaId(long empresaId);
        Reserva AlterarStatus(ReservaDto reservaDto);
    }
}
