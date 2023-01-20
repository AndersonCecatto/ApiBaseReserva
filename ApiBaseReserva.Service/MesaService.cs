using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class MesaService : BaseService<Mesa>, IMesaService
    {
        public MesaService(IMesaRepository mesaRepository) : base(mesaRepository)
        {
        }
    }
}
