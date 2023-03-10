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
            Administrador = funcionarioDto.Administrador;
        }

        public string Funcao { get; set; }
        public bool Administrador { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
