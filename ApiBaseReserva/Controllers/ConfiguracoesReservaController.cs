using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfiguracoesReservaController : BaseController
    {
        private readonly IConfiguracoesReservaService _configuracoesReservaService;

        public ConfiguracoesReservaController(IConfiguracoesReservaService configuracoesReservaService)
        {
            _configuracoesReservaService = configuracoesReservaService;
        }

        [HttpPost]
        public IActionResult Inserir(ConfiguracoesReservaDto configuracoesReserva)
        {
            return Execute(() => _configuracoesReservaService.Add(configuracoesReserva));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _configuracoesReservaService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(ConfiguracoesReservaDto configuracoesReserva)
        {
            return Execute(() => _configuracoesReservaService.Update(configuracoesReserva));
        }
    }
}
