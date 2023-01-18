using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(IFuncionarioRepository funcionarioRepository) : base(funcionarioRepository)
        {
        }
        public Funcionario Add(FuncionarioDto funcionarioDto)
        {
            return _baseRepository.Insert(new Funcionario(funcionarioDto));
        }

        public FuncionarioDto Update(FuncionarioDto funcionarioDto)
        {
            _baseRepository.Update(new Funcionario(funcionarioDto));

            return funcionarioDto;
        }
    }
}
