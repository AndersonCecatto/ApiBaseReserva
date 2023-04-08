using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class Avaliacao : BaseEntity
    {
        public Avaliacao()
        {
            
        }

        public Avaliacao(AvaliacaoDto avaliacaoDto)
        {
            Id = avaliacaoDto.Id;
            Nota = avaliacaoDto.Nota;
            Descricao = avaliacaoDto.Descricao;
            EmpresaId = avaliacaoDto.EmpresaId;
            UsuarioId = avaliacaoDto.UsuarioId;
            ReservaId = avaliacaoDto.ReservaId;
        }

        public decimal Nota { get; set; }
        public string Descricao { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public long? ReservaId { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
