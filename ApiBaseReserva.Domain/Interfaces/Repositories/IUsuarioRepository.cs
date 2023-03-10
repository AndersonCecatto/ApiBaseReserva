using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario BuscarUsuario(string usuario, string senha);
        Usuario BuscarUsuarioPorLogin(string usuario);
        IEnumerable<Usuario> GetUsuarios(bool funcionario, long? empresaId = null);
    }
}
