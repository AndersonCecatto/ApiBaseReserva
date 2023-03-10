using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiBaseReserva.Controllers
{
    [Authorize]
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

        [HttpGet]
        [Route("{usuarioId}")]
        public IActionResult GetReservasPorUsuarioId(long usuarioId)
        {
            return Execute(() => _reservaService.BuscarPorUsuarioId(usuarioId));
        }

        [HttpGet]
        [Route("BuscarPorEmpresaId/{empresaId}")]
        public IActionResult BuscarPorEmpresaId(long empresaId)
        {
            return Execute(() => _reservaService.BuscarPorEmpresaId(empresaId));
        }

        [HttpPost]
        [Route("AlterarStatus")]
        public IActionResult AlterarStatus(ReservaDto reservaDto)
        {
            return Execute(() => _reservaService.AlterarStatus(reservaDto));
        }

        [HttpPost]
        [Route("CapacidadeReserva")]
        public IActionResult BuscarPorEmpresaId(ReservaFiltrosDto reservaFiltrosDto)
        {
            return Execute(() => _reservaService.CapacidadeReserva(reservaFiltrosDto));
        }
    }
}
