using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface ICidadeService : IBaseService<Cidade>
    {
        IEnumerable<Cidade> BuscarPorIdUf(long estadoId);
    }
}
