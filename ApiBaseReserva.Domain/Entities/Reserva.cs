using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Enum;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class Reserva : BaseEntity
    {
        public DateTime DataCadastro { get; set; }
        public DateTime? Horario { get; set; }
        public PeriodoEnum? Periodo { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public long ConfiguracoesReservaId { get; set; }
        public virtual ConfiguracoesReserva ConfiguracoesReserva { get; set; }
        public long ClenteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public bool Ativo { get; set; }
    }
}
