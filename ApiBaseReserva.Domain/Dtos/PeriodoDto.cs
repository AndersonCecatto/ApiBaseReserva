using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Entities;

namespace ApiBaseReserva.Domain.Dtos
{
    public class PeriodoDto : BaseEntity
    {
        public string Descricao { get; set; }
        public long EmpresaId { get; set; }
    }
}
