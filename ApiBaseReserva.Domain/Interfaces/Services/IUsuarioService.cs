using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Usuario GetUsuario(string usuario, string senha);
        Usuario Add(UsuarioDto usuarioDto);
        UsuarioDto Atulizar(UsuarioDto usuarioDto);
        IEnumerable<Usuario> BuscarCliente();
        IEnumerable<Usuario> BuscarFuncionarios(long empresaId);
    }
}
