using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IEmpresaService : IBaseService<Empresa>
    {
        Empresa Add(EmpresaDto empresa);
        EmpresaDto Update(EmpresaDto empresa);
        IEnumerable<Empresa> BuscarTodas();
        Empresa BuscarPorId(long empresaId, bool buscarAvaliacoes);
    }
}
