using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Service
{
    public class PeriodoService : BaseService<Periodo>, IPeriodoService
    {
        private readonly IPeriodoRepository _periodoRepository;

        public PeriodoService(IPeriodoRepository periodoRepository) : base(periodoRepository)
        {
            _periodoRepository = periodoRepository;
        }

        public IEnumerable<Periodo> BuscarPorEmpresaId(long empresaId)
        {
            return _periodoRepository.BuscarPorEmpresaId(empresaId);
        }

        public Periodo Add(PeriodoDto periodoDto)
        {
            return _baseRepository.Insert(new Periodo(periodoDto));
        }

        public PeriodoDto Update(PeriodoDto periodoDto)
        {
            _baseRepository.Update(new Periodo(periodoDto));

            return periodoDto;
        }
    }
}
