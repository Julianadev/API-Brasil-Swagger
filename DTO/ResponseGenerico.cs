using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Dynamic;

// Aqui se encontra o model generico para retorno de dados
namespace BrasilAPI.DTO
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode codigoHttps { get; set; }
        public T? dadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno{ get; set; }
    }
}