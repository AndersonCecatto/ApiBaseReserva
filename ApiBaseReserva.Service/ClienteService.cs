using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {

        }
    }
}
