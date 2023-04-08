using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class PeriodoRepository : BaseRepository<Periodo>, IPeriodoRepository
    {
        public PeriodoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        private IQueryable<Periodo> BuscarTodos()
            => _apiBaseContext.Set<Periodo>()
                                  .Include(x => x.Empresa)
                                  .Select(x => new Periodo
                                  {
                                      Id = x.Id,
                                      Descricao = x.Descricao,
                                      Ativo = x.Ativo,
                                      EmpresaId = x.EmpresaId,
                                      Empresa = new Empresa
                                      {
                                          Id = x.Empresa.Id,
                                          Nome = x.Empresa.Nome
                                      }
                                  });

        public override IEnumerable<Periodo> GetAll() => BuscarTodos();

        public IEnumerable<Periodo> BuscarPorEmpresaId(long empresaId, bool buscaCompleta)
        {
            var consulta = BuscarTodos().Where(x => x.EmpresaId == empresaId);

            if (!buscaCompleta)
                consulta = consulta.Where(x => x.Ativo == true);

            return consulta.OrderBy(x => x.Id);
        }
    }
}
