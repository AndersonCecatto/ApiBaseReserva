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
    public class ServicoService : BaseService<Servico>, IServicoService
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IReservaRepository _reservaRepository;

        public ServicoService(IServicoRepository servicoRepository, IReservaRepository reservaRepository) : base(servicoRepository)
        {
            _servicoRepository = servicoRepository;
            _reservaRepository = reservaRepository;
        }

        public Servico Add(ServicoDto servicoDto)
        {
            return _baseRepository.Insert(new Servico(servicoDto));
        }

        public IEnumerable<Servico> BuscarPorEmpresaId(long empresaId, bool buscaCompleta)
        {
            return _servicoRepository.BuscarPorEmpresaId(empresaId, buscaCompleta);
        }

        public ResponseDto<ServicoDto> Deletar(long id)
        {
            if (_reservaRepository.VerificarPossueDadosPorId(id, ProcessoEnum.Servico))
                return new ResponseDto<ServicoDto>
                {
                    Dados = null,
                    Mensagem = "Servico esta sendo utilizado em alguma reserva cadastrada."
                };

            _baseRepository.Delete(id);

            return new ResponseDto<ServicoDto> { Dados = new ServicoDto { Id = id } };
        }

        public ServicoDto Update(ServicoDto servicoDto)
        {
            _baseRepository.Update(new Servico(servicoDto));

            return servicoDto;
        }
    }
}
