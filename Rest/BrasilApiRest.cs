using BrasilAPI.Interfaces;
using BrasilAPI.Models;
using BrasilAPI.DTO;
using System.Text.Json;
using System.Dynamic;

namespace BrasilAPI.Rest
{
  public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            
            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp); 

                if (responseBrasilApi.IsSuccessStatusCode) 
                {    
                    response.codigoHttps = responseBrasilApi.StatusCode;
                    response.dadosRetorno = objResponse;
                }
                else 
                {
                    response.codigoHttps = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
            
            var response = new ResponseGenerico<List<BancoModel>>();
            using (var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp); 

                if (responseBrasilApi.IsSuccessStatusCode) 
                {    
                    response.codigoHttps = responseBrasilApi.StatusCode;
                    response.dadosRetorno = objResponse;
                }
                else 
                {
                    response.codigoHttps = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
            
            var response = new ResponseGenerico<BancoModel>();
            using (var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp); 

                if (responseBrasilApi.IsSuccessStatusCode) 
                {    
                    response.codigoHttps = responseBrasilApi.StatusCode;
                    response.dadosRetorno = objResponse;
                }
                else 
                {
                    response.codigoHttps = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
    }
}
