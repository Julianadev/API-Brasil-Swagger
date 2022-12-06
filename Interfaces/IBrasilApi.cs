using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilAPI.DTO;
using BrasilAPI.Models;

// Aqui se encontra a interface da api, que é implementada no serviço da api
namespace BrasilAPI.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco( string codigoBanco);
    }
}