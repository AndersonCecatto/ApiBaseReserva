using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Dtos.Response;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IPeriodoService : IBaseService<Periodo>
    {
        IEnumerable<Periodo> BuscarPorEmpresaId(long empresaId, bool buscaCompleta);
        Periodo Add(PeriodoDto periodoDto);
        PeriodoDto Update(PeriodoDto periodoDto);
        ResponseDto<PeriodoDto> Deletar(long id);
    }
}
