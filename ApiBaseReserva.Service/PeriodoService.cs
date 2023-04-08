using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Dtos.Response;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Enum;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Service
{
    public class PeriodoService : BaseService<Periodo>, IPeriodoService
    {
        private readonly IPeriodoRepository _periodoRepository;
        private readonly IReservaRepository _reservaRepository;

        public PeriodoService(IPeriodoRepository periodoRepository, IReservaRepository reservaRepository) : base(periodoRepository)
        {
            _periodoRepository = periodoRepository;
            _reservaRepository = reservaRepository;
        }

        public IEnumerable<Periodo> BuscarPorEmpresaId(long empresaId, bool buscaCompleta)
        {
            return _periodoRepository.BuscarPorEmpresaId(empresaId, buscaCompleta);
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

        public override Periodo GetById(long id)
        {
            return _baseRepository.Find(id);
        }

        public ResponseDto<PeriodoDto> Deletar(long id)
        {
            if (_reservaRepository.VerificarPossueDadosPorId(id, ProcessoEnum.Periodo))
                return new ResponseDto<PeriodoDto>
                {
                    Dados = null,
                    Mensagem = "Periodo esta sendo utilizado em alguma reserva cadastrada."
                };

                _baseRepository.Delete(id);

            return new ResponseDto<PeriodoDto> { Dados = new PeriodoDto { Id = id } };
        }
    }
}
