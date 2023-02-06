using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
        }

        public Usuario GetUsuario(string usuario, string senha)
        {

            var teste = _apiBaseContext.Set<Usuario>().FirstOrDefault(x => x.Login == usuario && x.Senha == senha);
            return teste;
        }
    }
}
