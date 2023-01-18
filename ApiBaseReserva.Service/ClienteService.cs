using ApiBaseReserva.Domain.Dtos;
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

        public Cliente Add(ClienteDto clienteDto)
        {
            return _baseRepository.Insert(new Cliente(clienteDto));
        }

        public ClienteDto Update(ClienteDto clienteDto)
        {
            _baseRepository.Update(new Cliente(clienteDto));

            return clienteDto;
        }
    }
}
