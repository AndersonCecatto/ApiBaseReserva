using System;

namespace ApiBaseReserva.Domain.Dtos
{
    public class ReservaFiltrosDto
    {
        public long EmpresaId { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime? Horario { get; set; }
        public long? PeriodoId { get; set; }
    }
}
