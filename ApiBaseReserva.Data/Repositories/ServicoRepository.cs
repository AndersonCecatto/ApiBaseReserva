using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        public ServicoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        private IQueryable<Servico> BuscarTodos()
            => _apiBaseContext.Set<Servico>()
                              .Include(x => x.Empresa)
                              .Select(x => new Servico
                              {
                                  Id = x.Id,
                                  Descricao = x.Descricao,
                                  Valor = x.Valor,
                                  Ativo = x.Ativo,
                                  EmpresaId = x.EmpresaId,
                                  Empresa = new Empresa
                                  {
                                      Id = x.Empresa.Id,
                                      Nome = x.Empresa.Nome
                                  }
                              });

        public IEnumerable<Servico> BuscarPorEmpresaId(long empresaId, bool buscaCompleta) 
        {
            var consulta = BuscarTodos().Where(x => x.EmpresaId == empresaId);

            if (!buscaCompleta)
                consulta = consulta.Where(x => x.Ativo == true);

            return consulta.OrderBy(x => x.Id);
        } 
    }
}
