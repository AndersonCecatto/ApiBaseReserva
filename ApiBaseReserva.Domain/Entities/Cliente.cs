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
            UsuarioId = clienteDto.UsuarioId;
        }

        public string Telefone { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
