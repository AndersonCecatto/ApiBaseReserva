﻿using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Enum;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
        }

        public IEnumerable<Reserva> BuscarPorEmpresaId(long empresaId)
        {
            return _apiBaseContext.Set<Reserva>()
                                  .Include(x => x.Usuario)
                                  .Include(x => x.Periodo)
                                  .Include(x => x.Servico)
                                  .Where(x => x.EmpresaId == empresaId);
        }

        public IEnumerable<Reserva> BuscarPorUsuarioId(long usuarioId, long empresaId)
        {
            var consulta = _apiBaseContext.Set<Reserva>()
                                  .Include(x => x.Empresa)
                                  .ThenInclude(x => x.EmpresaAdicional)
                                  .Include(x => x.Periodo)
                                  .Include(x => x.Servico)
                                  .Where(x => x.UsuarioId == usuarioId);

            if (empresaId > 0)
                consulta = consulta.Where(x => x.EmpresaId == empresaId);

            return consulta;
        }

        public int CapacidadeReserva(ReservaFiltrosDto reservaFiltrosDto)
        {
            var consulta = _apiBaseContext.Set<Reserva>()
                            .Where(x => x.EmpresaId == reservaFiltrosDto.EmpresaId &&
                                    x.DataReserva == reservaFiltrosDto.DataReserva && 
                                    x.Cancelada == false);
            if (reservaFiltrosDto.Horario.HasValue)
                consulta = consulta.Where(x => x.Horario >= reservaFiltrosDto.Horario.Value.AddMinutes(-30) && x.Horario < reservaFiltrosDto.Horario.Value.AddHours(1));
            else
                consulta = consulta.Where(x => x.PeriodoId == reservaFiltrosDto.PeriodoId);

            return consulta.Sum(x => x.QuantidadePessoas.Value);
        }

        public bool VerificarPossueDadosPorId(long id, ProcessoEnum processoEnum) 
        { 
            switch (processoEnum)
            {
                case ProcessoEnum.Servico:
                    return _apiBaseContext.Set<Reserva>().Any(x => x.ServicoId == id);

                case ProcessoEnum.Periodo:
                    return _apiBaseContext.Set<Reserva>().Any(x => x.PeriodoId == id);
            }

            return false;
        } 

        public Reserva AlterarStatus(ReservaDto reservaDto)
        {
            var reserva = new Reserva()
            { 
                Id = reservaDto.Id,
                Cancelada = reservaDto.Cancelada,
                Ativo = reservaDto.Ativo,
                Reservado = reservaDto.Reservado,
                MotivoCancelamento = reservaDto.MotivoCancelamento,
                UsuarioCancelamentoId = reservaDto.UsuarioCancelamentoId
            };

            _apiBaseContext.Attach(reserva);
            _apiBaseContext.Entry(reserva).Property(x => x.Cancelada).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.MotivoCancelamento).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.Ativo).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.UsuarioCancelamentoId).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.Reservado).IsModified = true;

            _apiBaseContext.SaveChanges();

            return reserva;
        }

        public void AlterarAvaliado(long id)
        {
            var reserva = new Reserva {  Id = id, Avaliado = true };

            _apiBaseContext.Attach(reserva);
            _apiBaseContext.Entry(reserva).Property(x => x.Avaliado).IsModified = true;

            _apiBaseContext.SaveChanges();
        }
    }
}
