using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Aqui se encontra o model banco modificado
namespace BrasilAPI.DTO
{
    public class BancoResponse 
    {
        public string? Ispb { get; set; }
        public string? NomeAbreviado { get; set; }
        public int? Codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }
}