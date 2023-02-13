using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : BaseController
    {
        private readonly ICidadeService _cidadeService;

        public CidadeController(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _cidadeService.GetAll());
        }

        [HttpGet]
        [Route("BuscarPorIdUf/{estadoId}")]
        public IActionResult BuscarPorIdUf(long estadoId)
        {
            return Execute(() => _cidadeService.BuscarPorIdUf(estadoId));
        }
    }
}
