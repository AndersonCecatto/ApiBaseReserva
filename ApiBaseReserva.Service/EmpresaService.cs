using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        public EmpresaService(IEmpresaRepository empresaRepository) : base(empresaRepository)
        {

        }

        public Empresa Add(EmpresaDto empresa)
        {
            return _baseRepository.Insert(new Empresa(empresa));
        }

        public EmpresaDto Update(EmpresaDto empresa)
        {
            _baseRepository.Update(new Empresa(empresa));

            return empresa;
        }
    }
}
