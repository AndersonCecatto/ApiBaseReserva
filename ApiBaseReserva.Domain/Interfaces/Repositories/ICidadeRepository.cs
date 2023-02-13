﻿using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IBaseRepository<Cidade>
    {
        IEnumerable<Cidade> BuscarPorIdUf(long estadoId);
    }
}
