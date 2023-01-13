using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class Cidade : BaseEntity
    {
        public string Nome { get; set; }
        public long EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
