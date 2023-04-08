using ApiBaseReserva.Controllers.Common;
using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReserva.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicoController : BaseController
    {
        private readonly IServicoService _servicoService;

        public ServicoController(IServicoService servicoService)
        {
            _servicoService = servicoService;
        }

        [HttpPost]
        public IActionResult Inserir(ServicoDto servico)
        {
            return Execute(() => _servicoService.Add(servico));
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _servicoService.GetAll());
        }

        [HttpPut]
        public IActionResult Alterar(ServicoDto servico)
        {
            return Execute(() => _servicoService.Update(servico));
        }

        [HttpGet]
        [Route("{empresaId}/{buscaCompleta}")]
        public IActionResult BuscarPorEmpresaId(long empresaId, bool buscaCompleta)
        {
            return Execute(() => _servicoService.BuscarPorEmpresaId(empresaId, buscaCompleta));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(long id)
        {
            return Execute(() => _servicoService.Deletar(id));
        }
    }
}
