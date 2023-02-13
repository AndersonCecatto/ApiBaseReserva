using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
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
            return _apiBaseContext.Set<Reserva>().Include(x => x.Usuario).Where(x => x.EmpresaId == empresaId);
        }

        public IEnumerable<Reserva> BuscarPorUsuarioId(long usuarioId)
        {
            return _apiBaseContext.Set<Reserva>().Include(x => x.Empresa).Where(x => x.UsuarioId == usuarioId);
        }

        public Reserva AlterarStatus(ReservaDto reservaDto)
        {
            var reserva = new Reserva()
            { 
                Id = reservaDto.Id, 
                Cancelada = reservaDto.Cancelada,
                Ativo = reservaDto.Ativo,
                MotivoCancelamento = reservaDto.MotivoCancelamento,
                UsuarioCancelamentoId = reservaDto.UsuarioCancelamentoId
            };

            _apiBaseContext.Attach(reserva);
            _apiBaseContext.Entry(reserva).Property(x => x.Cancelada).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.MotivoCancelamento).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.Ativo).IsModified = true;
            _apiBaseContext.Entry(reserva).Property(x => x.UsuarioCancelamentoId).IsModified = true;

            _apiBaseContext.SaveChanges();

            return reserva;
        }
    }
}
