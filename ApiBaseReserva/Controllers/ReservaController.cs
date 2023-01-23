using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : BaseController
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpPost]
        public IActionResult Inserir(ReservaDto reserva)
        {
            return Execute(() => _reservaService.Add(reserva));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _reservaService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(ReservaDto reserva)
        {
            return Execute(() => _reservaService.Update(reserva));
        }
    }
}
