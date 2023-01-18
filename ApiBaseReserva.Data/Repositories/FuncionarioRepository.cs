using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override IEnumerable<Funcionario> GetAll()
        {
            return _apiBaseContext.Set<Funcionario>().Include(x => x.Usuario).Include(x => x.Empresa).AsEnumerable();
        }
    }
}
