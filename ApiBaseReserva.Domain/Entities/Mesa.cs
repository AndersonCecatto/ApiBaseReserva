using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class Mesa : BaseEntity
    {
        public int Numero { get; set; }
        public int QuantidadePessoas { get; set; }
        public bool Reservada { get; set; }
    }
}
