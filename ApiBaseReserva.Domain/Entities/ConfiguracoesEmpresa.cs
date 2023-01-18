using ApiBaseReserva.Domain.Common;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class ConfiguracoesEmpresa : BaseEntity
    {
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }
        public bool EhPorMesas { get; set; }
        public int? QuantidadeMesas { get; set; }
        public bool EhPorPessoas { get; set; }
        public int? QuantidadePessoas { get; set; }
        public int? TempoReservaMinutos { get; set; }
    }
}
