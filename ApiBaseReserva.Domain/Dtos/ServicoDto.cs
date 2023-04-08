using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Dtos
{
    public class ServicoDto : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public bool Ativo { get; set; }
        public long EmpresaId { get; set; }
    }
}
