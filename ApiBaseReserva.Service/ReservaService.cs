using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class ReservaService : BaseService<Reserva>, IReservaService
    {
        public ReservaService(IReservaRepository reservaRepository) : base(reservaRepository)
        {
        }

        public Reserva Add(ReservaDto reservaDto)
        {
            return _baseRepository.Insert(new Reserva(reservaDto));
        }

        public ReservaDto Update(ReservaDto reservaDto)
        {
            _baseRepository.Update(new Reserva(reservaDto));

            return reservaDto;
        }
    }
}
