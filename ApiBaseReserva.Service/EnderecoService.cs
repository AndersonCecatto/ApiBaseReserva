using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
        }

        public Endereco Add(EnderecoDto endereco)
        {
            return _baseRepository.Insert(new Endereco(endereco));
        }

        public EnderecoDto Update(EnderecoDto endereco)
        {
            _baseRepository.Update(new Endereco(endereco));

            return endereco;
        }
    }
}
