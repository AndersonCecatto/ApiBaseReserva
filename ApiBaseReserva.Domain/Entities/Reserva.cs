using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Enum;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class Reserva : BaseEntity
    {
        public Reserva()
        {

        }

        public Reserva(ReservaDto reservaDto)
        {
            Id = reservaDto.Id;
            DataReserva = reservaDto.DataReserva;
            DataCadastro = reservaDto.DataCadastro;
            Horario = reservaDto.Horario;
            PeriodoId = reservaDto.PeriodoId;
            EmpresaId = reservaDto.EmpresaId;
            UsuarioId = reservaDto.UsuarioId;
            Ativo = reservaDto.Ativo;
            QuantidadePessoas = reservaDto.QuantidadePessoas;
            EhComemoracao = reservaDto.EhComemoracao;
            MesaId = reservaDto.MesaId;
            Cancelada = reservaDto.Cancelada;
            MotivoCancelamento = reservaDto.MotivoCancelamento;
            UsuarioCancelamentoId = reservaDto.UsuarioCancelamentoId;
        }

        public DateTime DataReserva { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? Horario { get; set; }
        public long? PeriodoId { get; set; }
        public virtual Periodo Periodo { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
        public virtual Mesa Mesa { get; set; }
        public bool? Cancelada { get; set; }
        public string MotivoCancelamento { get; set; }
        public int? UsuarioCancelamentoId { get; set; }
    }
}
