﻿using ApiBaseReserva.Controllers.Common;
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
        [Authorize]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _usuarioService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(Usuario usuario)
        {
            return Execute(() => _usuarioService.Update(usuario));
        }

        [HttpGet]
        [Route("GetUsuario/usuario/{usuario}/senha/{senha}")]
        public IActionResult BuscarUsuario(string usuario, string senha)
        {
            return Execute(() => _usuarioService.GetUsuario(usuario, senha));
        }
    }
}
