using ApiBaseReserva.Domain.Common;

namespace ApiBaseReserva.Domain.Dtos
{
    public class FuncionarioDto : BaseEntity
    {
        public string Funcao { get; set; }
        public bool Administrador { get; set; }
        public long EmpresaId { get; set; }
    }
}
