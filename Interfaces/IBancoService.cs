using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilAPI.DTO;

// Aqui se encontra a interface do serviço de banco, que é implementada no serviço de banco
namespace BrasilAPI.Interfaces
{
    public interface IBancoService 
    {
         public Task<ResponseGenerico <List<BancoResponse>>> BuscarTodos();
        
        public Task<ResponseGenerico <BancoResponse>> BuscarBanco(string codigo);
        
    }
}