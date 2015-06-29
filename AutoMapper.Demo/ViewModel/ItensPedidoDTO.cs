using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper.Demo.ViewModel
{
    public class ItensPedidoDTO
    {
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}