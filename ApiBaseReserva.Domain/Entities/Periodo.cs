﻿using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class Periodo : BaseEntity
    {
        public Periodo()
        {
        }

        public Periodo(PeriodoDto periodoDto)
        {
            Id = periodoDto.Id;
            Descricao = periodoDto.Descricao;
            Ativo = periodoDto.Ativo;
            EmpresaId = periodoDto.EmpresaId;
        }

        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
