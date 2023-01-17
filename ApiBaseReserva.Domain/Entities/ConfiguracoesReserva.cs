using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class ConfiguracoesReserva : BaseEntity
    {
        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
        public virtual Mesa Mesa { get; set; }
    }
}
