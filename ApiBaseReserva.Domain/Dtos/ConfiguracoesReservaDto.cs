using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Dtos
{
    public class ConfiguracoesReservaDto : BaseEntity
    {
        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
    }
}
