using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Dtos
{
    public class UsuarioDto : BaseEntity
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
