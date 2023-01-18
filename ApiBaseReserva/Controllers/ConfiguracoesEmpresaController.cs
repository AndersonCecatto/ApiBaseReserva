using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfiguracoesEmpresaController : BaseController
    {
        private readonly IConfiguracoesEmpresaService _configuracoesEmpresaService;

        public ConfiguracoesEmpresaController(IConfiguracoesEmpresaService configuracoesEmpresaService)
        {
            _configuracoesEmpresaService = configuracoesEmpresaService;
        }

        [HttpPost]
        public IActionResult Inserir(ConfiguracoesEmpresa configuracoesEmpresa)
        {
            return Execute(() => _configuracoesEmpresaService.Add(configuracoesEmpresa));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _configuracoesEmpresaService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(ConfiguracoesEmpresa configuracoesEmpresa)
        {
            return Execute(() => _configuracoesEmpresaService.Update(configuracoesEmpresa));
        }
    }
}
