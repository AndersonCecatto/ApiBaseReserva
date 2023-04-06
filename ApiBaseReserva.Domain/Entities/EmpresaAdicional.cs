using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class EmpresaAdicional : BaseEntity
    {
        public bool BloqueiaReserva { get; set; }
        public bool AceitaReservaAutomaticamente { get; set; }
        public bool PermiteReagendarReserva { get; set; }
        public bool ExibirMensagemRapida { get; set; }
        public int TempoPermitidoCancelamento { get; set; }
        public int? TempoToleranciaCancelamento { get; set; }
        public string MensagemRapida { get; set; }
    }
}
