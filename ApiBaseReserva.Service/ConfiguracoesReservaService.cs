using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;

namespace ApiBaseReserva.Service
{
    public class ConfiguracoesReservaService : BaseService<ConfiguracoesReserva>, IConfiguracoesReservaService
    {
        public ConfiguracoesReservaService(IConfiguracoesReservaRepository configuracoesReservaRepository) : base(configuracoesReservaRepository)
        {

        }

        public ConfiguracoesReserva Add(ConfiguracoesReservaDto configuracoesReserva)
        {
            return _baseRepository.Insert(new ConfiguracoesReserva(configuracoesReserva));
        }

        public ConfiguracoesReservaDto Update(ConfiguracoesReservaDto configuracoesReserva)
        {
            _baseRepository.Update(new ConfiguracoesReserva(configuracoesReserva));

            return configuracoesReserva;
        }
    }
}
