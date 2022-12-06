using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilAPI.DTO;
using BrasilAPI.Models;

//mapeamento do endereço
namespace BrasilAPI.Mappings
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel , EnderecoResponse>();

        }
    }
}