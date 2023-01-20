using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class ConfiguracoesReserva : BaseEntity
    {
        public ConfiguracoesReserva()
        {

        }

        public ConfiguracoesReserva(ConfiguracoesReservaDto configuracoesReserva)
        {
            QuantidadePessoas = configuracoesReserva.QuantidadePessoas;
            EhComemoracao = configuracoesReserva.EhComemoracao;
            DescricaoComemoracao = configuracoesReserva.DescricaoComemoracao;
            MesaId = configuracoesReserva.MesaId;
        }

        public int? QuantidadePessoas { get; set; }
        public bool EhComemoracao { get; set; }
        public string DescricaoComemoracao { get; set; }
        public long? MesaId { get; set; }
        public virtual Mesa Mesa { get; set; }
    }
}
