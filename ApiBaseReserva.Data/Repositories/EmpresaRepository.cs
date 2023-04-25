using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override IEnumerable<Empresa> GetAll()
        {
            return _apiBaseContext.Set<Empresa>()
                                  .AsNoTracking()
                                  .Include(x => x.Endereco)
                                  .ThenInclude(x => x.Cidade)
                                  .Include(x => x.EmpresaAdicional)
                                  .Include(x => x.ConfiguracoesEmpresa).AsEnumerable();
        }

        public override Empresa Find(long id)
        {
            return _apiBaseContext.Set<Empresa>().AsNoTracking()
                .Include(x => x.ConfiguracoesEmpresa)
                .Include(x => x.Endereco)
                    .ThenInclude(x => x.Cidade)
                    .ThenInclude(x => x.Estado)
                .Include(x => x.EmpresaAdicional)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
