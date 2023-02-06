using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {

        }

        public Cliente(ClienteDto clienteDto)
        {
            Id = clienteDto.Id;
            Telefone = clienteDto.Telefone;
        }

        public string Telefone { get; set; }
    }
}
