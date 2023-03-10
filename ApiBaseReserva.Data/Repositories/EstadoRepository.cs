using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override IEnumerable<Estado> GetAll()
        {
            return _apiBaseContext.Set<Estado>()
                                  .Select(x => new Estado
                                  {
                                      Id = x.Id,
                                      Nome = x.Nome + '/' + x.UF,
                                      UF = x.UF
                                  }).AsEnumerable();
        }
    }
}
