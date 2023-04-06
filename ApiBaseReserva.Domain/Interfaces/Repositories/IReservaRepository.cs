using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        IEnumerable<Reserva> BuscarPorUsuarioId(long usuarioId, long empresaId);
        IEnumerable<Reserva> BuscarPorEmpresaId(long empresaId);
        Reserva AlterarStatus(ReservaDto reservaDto);
        int CapacidadeReserva(ReservaFiltrosDto reservaFiltrosDto);
    }
}
