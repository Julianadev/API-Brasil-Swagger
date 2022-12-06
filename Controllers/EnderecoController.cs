using System.Net;
using BrasilAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

// Aqui se encontra o controller de endereço, que é responsável por receber as requisições e retornar os dados
namespace BrasilAPI.Controllers
{
  [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep) 
        {
            var response = await _enderecoService.BuscarEndereco(cep);

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