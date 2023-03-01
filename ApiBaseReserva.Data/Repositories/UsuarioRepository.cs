using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
        }

        public Usuario BuscarUsuario(string usuario, string senha)
        {
            return _apiBaseContext.Set<Usuario>().FirstOrDefault(x => x.Login.Trim() == usuario.Trim() && x.Senha == senha);
        }

        public Usuario BuscarUsuarioPorLogin(string usuario)
        {
            return _apiBaseContext.Set<Usuario>().FirstOrDefault(x => x.Login.Trim() == usuario.Trim());
        }

        public override IEnumerable<Usuario> GetAll()
        {
            return _apiBaseContext.Set<Usuario>().Include(x => x.Cliente).Include(x => x.Funcionario);
        }
    }
}
