using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IFuncionarioService : IBaseService<Funcionario>
    {
        Funcionario Add(FuncionarioDto funcionarioDto);
        FuncionarioDto Update(FuncionarioDto funcionarioDto);
    }
}
