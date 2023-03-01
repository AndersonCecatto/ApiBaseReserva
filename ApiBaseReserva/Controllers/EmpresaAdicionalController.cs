using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaAdicionalController : BaseController
    {
        private readonly IEmpresaAdicionalService _empresaAdicionalService;

        public EmpresaAdicionalController(IEmpresaAdicionalService empresaAdicional)
        {
            _empresaAdicionalService = empresaAdicional;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _empresaAdicionalService.GetAll());
        }

        [HttpPost]
        public IActionResult Inserir(EmpresaAdicional empresaAdicional)
        {
            return Execute(() => _empresaAdicionalService.Add(empresaAdicional));
        }

        [HttpPut]
        public IActionResult Alterar(EmpresaAdicional empresaAdicional)
        {
            return Execute(() => _empresaAdicionalService.Update(empresaAdicional));
        }
    }
}
