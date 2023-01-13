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
    }
}
