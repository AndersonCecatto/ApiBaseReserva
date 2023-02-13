using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface ITokenService : IBaseService<Usuario>
    {
        UserToken RequestToken(UsuarioDto usuario);
    }
}
