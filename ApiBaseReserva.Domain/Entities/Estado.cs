using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class Estado : BaseEntity
    {
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
