using BrasilAPI.DTO;
using System.Threading.Tasks;
using BrasilAPI.Interfaces;

// Aqui se encontra a interface do serviço de endereço, que é implementada no serviço de endereço
namespace BrasilAPI.Interfaces
{

    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}