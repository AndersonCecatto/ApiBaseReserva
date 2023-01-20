using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : BaseController
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public IActionResult Inserir(EnderecoDto endereco)
        {
            return Execute(() => _enderecoService.Add(endereco));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _enderecoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(EnderecoDto endereco)
        {
            return Execute(() => _enderecoService.Update(endereco));
        }
    }
}
