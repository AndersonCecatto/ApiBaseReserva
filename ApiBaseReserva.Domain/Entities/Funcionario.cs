using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Entities
{
    public class Funcionario : BaseEntity
    {
        public string Funcao { get; set; }
        public long? EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
