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
        IEnumerable<Reserva> BuscarPorUsuarioId(long usuarioId, long empresaId);
        IEnumerable<Reserva> BuscarPorEmpresaId(long empresaId);
        Reserva AlterarStatus(ReservaDto reservaDto);
        int CapacidadeReserva(ReservaFiltrosDto reservaFiltrosDto);
        Avaliacao Avaliar(AvaliacaoDto avaliacaoDto);
        Avaliacao BuscarAvaliacaoPorReservaId(long reservaId);
    }
}
