using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Service
{
    public class ReservaService : BaseService<Reserva>, IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository) : base(reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public Reserva Add(ReservaDto reservaDto)
        {
            return _baseRepository.Insert(new Reserva(reservaDto));
        }

        public IEnumerable<Reserva> GetReservasPorUsuarioId(long usuarioId)
        {
            return _reservaRepository.GetReservasPorUsuarioId(usuarioId);
        }

        public ReservaDto Update(ReservaDto reservaDto)
        {
            _baseRepository.Update(new Reserva(reservaDto));

            return reservaDto;
        }
    }
}
