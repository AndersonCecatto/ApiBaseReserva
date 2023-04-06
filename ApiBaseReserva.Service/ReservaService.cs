using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System;
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

        public IEnumerable<Reserva> BuscarPorEmpresaId(long empresaId)
        {
            return _reservaRepository.BuscarPorEmpresaId(empresaId);
        }

        public IEnumerable<Reserva> BuscarPorUsuarioId(long usuarioId, long empresaId)
        {
            return _reservaRepository.BuscarPorUsuarioId(usuarioId, empresaId);
        }

        public Reserva AlterarStatus(ReservaDto reservaDto)
        {
            return _reservaRepository.AlterarStatus(reservaDto);
        }

        public ReservaDto Update(ReservaDto reservaDto)
        {
            _baseRepository.Update(new Reserva(reservaDto));

            return reservaDto;
        }

        public int CapacidadeReserva(ReservaFiltrosDto reservaFiltrosDto)
        {
            return _reservaRepository.CapacidadeReserva(reservaFiltrosDto);
        }
    }
}
