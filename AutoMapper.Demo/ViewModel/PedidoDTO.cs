using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Demo.Models.Dominio;

namespace AutoMapper.Demo.ViewModel
{
    public class PedidoDTO
    {
        public string NomeCliente { get; set; }
        public decimal Total { get; set; }
        public string NumeroPedido { get; set; }
        public IEnumerable<ItensPedido> LinhaPedido { get; set; }
    }
}