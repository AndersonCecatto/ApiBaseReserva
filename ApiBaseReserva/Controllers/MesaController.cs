using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MesaController : BaseController
    {
        private readonly IMesaService _mesaService;

        public MesaController(IMesaService mesaService)
        {
            _mesaService = mesaService;
        }

        [HttpPost]
        public IActionResult Inserir(Mesa mesa)
        {
            return Execute(() => _mesaService.Add(mesa));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _mesaService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(Mesa mesa)
        {
            return Execute(() => _mesaService.Update(mesa));
        }
    }
}
