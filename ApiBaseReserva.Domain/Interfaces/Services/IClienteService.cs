using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IClienteService : IBaseService<Cliente>
    {
        Cliente Add(ClienteDto clienteDto);
        ClienteDto Update(ClienteDto clienteDto);
    }
}
