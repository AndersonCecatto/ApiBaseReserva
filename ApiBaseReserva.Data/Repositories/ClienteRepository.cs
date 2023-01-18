using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override IEnumerable<Cliente> GetAll()
        {
            return _apiBaseContext.Set<Cliente>().Include(x => x.Usuario).AsEnumerable();
        }
    }
}
