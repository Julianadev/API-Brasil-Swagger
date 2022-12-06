using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilAPI.DTO;
using BrasilAPI.Models;

// mapeamento do banco
namespace BrasilAPI.Mappings
{
  public class BancoMapper : Profile
  {

    public BancoMapper()
    {
    CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
    CreateMap<BancoResponse, BancoModel>();
    CreateMap<BancoModel, BancoResponse>();
    }
  }
}