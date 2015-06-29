using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoMapper.Demo.Models.Dominio
{
    public class Pedido
    {
         [Key]
        public int PedidoId { get; set; }
        public string NumeroPedido { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataCompra { get; set; }
        public IEnumerable<ItensPedido> LinhaPedido { get; set; }
        public bool Entregar { get; set; }
        public decimal TotalPedido()
        {
            return LinhaPedido == null ? 0 : LinhaPedido.Sum(x => x.PrecoTotal());
        }
        public Guid InternalId { get; set; }
    }
}