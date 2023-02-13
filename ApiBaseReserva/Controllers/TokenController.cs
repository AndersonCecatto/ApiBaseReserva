using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : BaseController
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost]
        public IActionResult RequestToken(UsuarioDto usuarioDto)
        {
            return Execute(() => _tokenService.RequestToken(usuarioDto));
        }

        //[HttpGet]
        //public IActionResult BuscarTodos()
        //{
        //    return Execute(() => _cidadeService.GetAll());
        //}

        //[HttpGet]
        //[Route("BuscarPorIdUf/{estadoId}")]
        //public IActionResult BuscarPorIdUf(long estadoId)
        //{
        //    return Execute(() => _cidadeService.BuscarPorIdUf(estadoId));
        //}
    }
}
