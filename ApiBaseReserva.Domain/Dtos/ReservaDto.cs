﻿using ApiBaseReserva.Domain.Common;
using System;

namespace ApiBaseReserva.Domain.Dtos
{
    public class ReservaDto : BaseEntity
    {
        public DateTime DataReserva { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? Horario { get; set; }
        public long? PeriodoId { get; set; }
        public long EmpresaId { get; set; }
        public long UsuarioId { get; set; }
        public bool Ativo { get; set; }
        public bool Reservado { get; set; }
        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
        public bool? Cancelada { get; set; }
        public string MotivoCancelamento { get; set; }
        public int? UsuarioCancelamentoId { get; set; }
        public long? ServicoId { get; set; }
    }
}
