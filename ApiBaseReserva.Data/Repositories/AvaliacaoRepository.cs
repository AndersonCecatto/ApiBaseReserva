using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class AvaliacaoRepository : BaseRepository<Avaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public IEnumerable<Avaliacao> BuscarAvaliacaoPorEmpresaId(long empresaId)
        {
            return _apiBaseContext.Set<Avaliacao>().Where(x => x.EmpresaId == empresaId);
        }

        public Avaliacao BuscarAvaliacaoPorReservaId(long reservaId)
        {
            return _apiBaseContext.Set<Avaliacao>().FirstOrDefault(x => x.ReservaId == reservaId);
        }
    }
}
