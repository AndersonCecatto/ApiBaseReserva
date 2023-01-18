using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class Funcionario : BaseEntity
    {
        public Funcionario()
        {

        }

        public Funcionario(FuncionarioDto funcionarioDto)
        {
            Id = funcionarioDto.Id;
            Funcao = funcionarioDto.Funcao;
            EmpresaId = funcionarioDto.EmpresaId;
            UsuarioId = funcionarioDto.UsuarioId;
        }

        public string Funcao { get; set; }
        public long? EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public long UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
