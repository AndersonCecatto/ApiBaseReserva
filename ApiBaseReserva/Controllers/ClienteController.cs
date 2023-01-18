using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : BaseController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Inserir(ClienteDto cliente)
        {
            return Execute(() => _clienteService.Add(cliente));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _clienteService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(ClienteDto cliente)
        {
            return Execute(() => _clienteService.Update(cliente));
        }
    }
}
