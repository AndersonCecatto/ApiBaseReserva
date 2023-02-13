using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadoController : BaseController
    {
        private readonly IEstadoService _estadoService;

        public EstadoController(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _estadoService.GetAll());
        }
    }
}
