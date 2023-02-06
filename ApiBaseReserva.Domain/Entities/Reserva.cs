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
            Periodo = reservaDto.Periodo;
            EmpresaId = reservaDto.EmpresaId;
            UsuarioId = reservaDto.UsuarioId;
            Ativo = reservaDto.Ativo;
            QuantidadePessoas = reservaDto.QuantidadePessoas;
            EhComemoracao = reservaDto.EhComemoracao;
            MesaId = reservaDto.MesaId;
        }

        public DateTime DataReserva { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? Horario { get; set; }
        public PeriodoEnum? Periodo { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string? DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
        public virtual Mesa Mesa { get; set; }
    }
}
