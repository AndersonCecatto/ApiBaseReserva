using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Dtos.Response;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IServicoService : IBaseService<Servico>
    { 
        IEnumerable<Servico> BuscarPorEmpresaId(long empresaId, bool buscaCompleta);
        Servico Add(ServicoDto servicoDto);
        ServicoDto Update(ServicoDto servicoDto);
        ResponseDto<ServicoDto> Deletar(long id);
    }
}
