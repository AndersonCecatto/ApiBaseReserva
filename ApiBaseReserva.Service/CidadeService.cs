using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Service
{
    public class CidadeService : BaseService<Cidade>, ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository) : base(cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public IEnumerable<Cidade> BuscarPorIdUf(long estadoId)
        {
            return _cidadeRepository.BuscarPorIdUf(estadoId);
        }
    }
}
