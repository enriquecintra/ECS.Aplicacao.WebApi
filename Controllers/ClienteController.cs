using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using ECS.Aplicacao.WebApi.Services;
using ECS.Aplicacao.WebApi.Models;

namespace ECS.Aplicacao.WebApi.Controllers
{
    [EnableCors]
    public class ClienteController : Controller
    {
        protected readonly ILogger<ClienteController> _log;

        protected readonly ClienteService _service;


        public ClienteController(ILogger<ClienteController> logger,
            ClienteService service)
        {
            _service = service;
            _log = logger;

        }

        [HttpGet]
        [Route("Cliente")]
        public async Task<IActionResult> ListarTodos()
        {
            try
            {
                var retorno = await _service.ListarTodosAsync();
                return Ok(retorno);
            }
            catch (Exception e)
            {
                _log.LogError($"Excepion: { e.Message } | { e.StackTrace }");
                return BadRequest(e);
            }
        }


        [HttpPost]
        [Route("Cliente")]
        public async Task<IActionResult> Salvar([FromBody] Cliente request)
        {
            try
            {
                request.Id = Guid.NewGuid();
                await _service.SalvarAsync(request);
                return Ok(request);
            }
            catch (Exception e)
            {
                _log.LogError($"Excepion: { e.Message } | { e.StackTrace }");
                return BadRequest(e);
            }
        }

        [HttpPut]
        [Route("Cliente/{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Cliente request)
        {
            try
            {
                var cliente = await _service.ObterPeloIdAsync(Guid.Parse(id));
                if (cliente == null)
                    throw new Exception("Cliente não encontrado!");

                cliente.Nome = request.Nome;
                cliente.Idade = request.Idade;
                await _service.SalvarAsync(cliente);
                return Ok(cliente);
            }
            catch (Exception e)
            {
                _log.LogError($"Excepion: { e.Message } | { e.StackTrace }");
                return BadRequest(e);
            }
        }

        [HttpDelete]
        [Route("Cliente/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _service.DeletarAsync(Guid.Parse(id));
                return Ok();
            }
            catch (Exception e)
            {
                _log.LogError($"Excepion: { e.Message } | { e.StackTrace }");
                return BadRequest(e);
            }
        }

    }
}
