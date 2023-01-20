using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IConfiguracoesReservaService : IBaseService<ConfiguracoesReserva>
    {
        ConfiguracoesReserva Add(ConfiguracoesReservaDto configuracoesReserva);
        ConfiguracoesReservaDto Update(ConfiguracoesReservaDto configuracoesReserva);
    }
}
