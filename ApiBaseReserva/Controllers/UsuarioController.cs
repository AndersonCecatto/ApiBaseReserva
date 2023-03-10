using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Inserir(Usuario usuario)
        {
            return Execute(() => _usuarioService.Add(usuario));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _usuarioService.GetAll());
        }

        [HttpGet]
        [Route("Funcionarios/{empresaId}")]
        public IActionResult BuscarFuncionarios(long empresaId)
        {
            return Execute(() => _usuarioService.BuscarFuncionarios(empresaId));
        }

        [HttpGet]
        [Route("Clientes")]
        public IActionResult BuscarCliente()
        {
            return Execute(() => _usuarioService.BuscarCliente());
        }

        [HttpPut]
        public IActionResult Alterar(UsuarioDto usuarioDto)
        {
            return Execute(() => _usuarioService.Atulizar(usuarioDto));
        }

        [HttpGet]
        [Route("GetUsuario/usuario/{usuario}/senha/{senha}")]
        public IActionResult BuscarUsuario(string usuario, string senha)
        {
            return Execute(() => _usuarioService.GetUsuario(usuario, senha));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("InserirCliente")]
        public IActionResult InserirCliente(UsuarioDto usuarioDto)
        {
            return Execute(() => _usuarioService.Add(usuarioDto));
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(long id)
        {
            return Execute(() => _usuarioService.GetById(id));
        }
    }
}
