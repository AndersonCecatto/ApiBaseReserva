using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpPost]
        public IActionResult Inserir(EmpresaDto empresa)
        {
            return Execute(() => _empresaService.Add(empresa));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _empresaService.BuscarTodas());
        }

        [HttpPut]
        public IActionResult Alterar(EmpresaDto empresa)
        {
            return Execute(() => _empresaService.Update(empresa));
        }

        [HttpGet]
        [Route("{empresaId}/BuscarAvaliacoes/{buscarAvaliacoes}")]
        public IActionResult GetById(long empresaId, bool buscarAvaliacoes)
        {
            return Execute(() => _empresaService.BuscarPorId(empresaId, buscarAvaliacoes));
        }
    }
}
