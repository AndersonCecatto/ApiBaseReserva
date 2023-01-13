using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : BaseController
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _empresaService.GetAll());
        }

    }
}
