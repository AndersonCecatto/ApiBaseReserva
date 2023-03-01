using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeriodoController : BaseController
    {
        private readonly IPeriodoService _periodoService;

        public PeriodoController(IPeriodoService periodoService)
        {
            _periodoService = periodoService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _periodoService.GetAll());
        }

        [HttpPost]
        public IActionResult Inserir(PeriodoDto periodo)
        {
            return Execute(() => _periodoService.Add(periodo));
        }

        [HttpPut]
        public IActionResult Alterar(PeriodoDto periodo)
        {
            return Execute(() => _periodoService.Update(periodo));
        }

        [HttpGet]
        [Route("{empresaId}")]
        public IActionResult BuscarPorEmpresaId(long empresaId)
        {
            return Execute(() => _periodoService.BuscarPorEmpresaId(empresaId));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(long id)
        {
            return Execute(() => { _periodoService.Delete(id); return id; });
        }

    }
}
