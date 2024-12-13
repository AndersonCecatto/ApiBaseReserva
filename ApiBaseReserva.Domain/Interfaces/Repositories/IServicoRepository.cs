﻿using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories
{
    public interface IServicoRepository : IBaseRepository<Servico>
    {
        IEnumerable<Servico> BuscarPorEmpresaId(long empresaId, bool buscaCompleta);
    }
}