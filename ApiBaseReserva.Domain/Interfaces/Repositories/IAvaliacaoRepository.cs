using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface IAvaliacaoRepository : IBaseRepository<Avaliacao>
    {
        Avaliacao BuscarAvaliacaoPorReservaId(long reservaId);
        IEnumerable<Avaliacao> BuscarAvaliacaoPorEmpresaId(long empresaId);
    }
}
