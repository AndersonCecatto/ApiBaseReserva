using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : BaseController
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost]
        public IActionResult Inserir(FuncionarioDto funcionario)
        {
            return Execute(() => _funcionarioService.Add(funcionario));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _funcionarioService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(FuncionarioDto funcionario)
        {
            return Execute(() => _funcionarioService.Update(funcionario));
        }
    }
}
