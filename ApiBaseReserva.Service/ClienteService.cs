using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public ClienteService(IClienteRepository clienteRepository, IUsuarioRepository usuarioRepository) : base(clienteRepository)
        {
            _usuarioRepository = usuarioRepository;
        }



        public Cliente Add(ClienteDto clienteDto)
        {
            var entity = _usuarioRepository.Insert(new Usuario(clienteDto));

            var retorno = _baseRepository.Insert(new Cliente
            {
                Telefone = clienteDto.Telefone,
                UsuarioId = entity.Id
            });

            return retorno;
        }

        public ClienteDto Update(ClienteDto clienteDto)
        {
            _usuarioRepository.Update(new Usuario(clienteDto));

            _baseRepository.Update(new Cliente
            {
                Telefone = clienteDto.Telefone,
                UsuarioId = clienteDto.Id
            });

            return clienteDto;
        }
    }
}
