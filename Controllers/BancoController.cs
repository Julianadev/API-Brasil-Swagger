using System.ComponentModel.DataAnnotations;
using System.Net;
using BrasilAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

// Aqui se encontra o controller de banco, que é responsável por receber as requisições e retornar os dados
namespace BrasilAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        public readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodos() 
        {
            var response = await _bancoService.BuscarTodos();

            if(response.codigoHttps == System.Net.HttpStatusCode.OK) 
            {
                return Ok(response.dadosRetorno);
            }
            else 
            {
                return StatusCode((int)response.codigoHttps, response.ErroRetorno);
            }
        }

        [HttpGet("busca/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Buscar([RegularExpression("^[0-9]*$")] string codigoBanco) 
        {
            var response = await _bancoService.BuscarBanco(codigoBanco);

            if(response.codigoHttps == HttpStatusCode.OK) 
            {
                return Ok(response.dadosRetorno);
            }
            else 
            {
                return StatusCode((int)response.codigoHttps, response.ErroRetorno);
            }
        }
    }
}