using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Dtos
{
    public class FuncionarioDto : BaseEntity
    {
        public string Funcao { get; set; }
        public long EmpresaId { get; set; }
        public long UsuarioId { get; set; }
    }
}
