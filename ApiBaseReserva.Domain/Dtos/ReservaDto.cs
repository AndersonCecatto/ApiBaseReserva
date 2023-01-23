using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Enum;
using System;

namespace ApiBaseReserva.Domain.Dtos
{
    public class ReservaDto : BaseEntity
    {
        public DateTime DataCadastro { get; set; }
        public DateTime? Horario { get; set; }
        public PeriodoEnum? Periodo { get; set; }
        public long EmpresaId { get; set; }
        public long ClienteId { get; set; }
        public bool Ativo { get; set; }
        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string? DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
    }
}
