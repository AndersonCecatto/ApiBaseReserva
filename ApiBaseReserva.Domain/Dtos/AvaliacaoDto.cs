using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Dtos
{
    public class AvaliacaoDto : BaseEntity
    {
        public long ReservaId { get; set; }
        public decimal Nota { get; set; }
        public string Descricao { get; set; }
        public long UsuarioId { get; set; }
        public long EmpresaId { get; set; }
    }
}
