using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Entities;
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
        public IActionResult Inserir(Cliente cliente)
        {
            return Execute(() => _clienteService.Add(cliente));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _clienteService.GetAll());
        }
    }
}
