using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class Empresa : BaseEntity
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
