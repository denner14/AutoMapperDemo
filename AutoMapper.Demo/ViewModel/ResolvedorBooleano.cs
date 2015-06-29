using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Demo.Models.Dominio;

namespace AutoMapper.Demo.ViewModel
{
    public class ResolvedorBooleano : ValueResolver<Pedido, string>
    {
        protected override string ResolveCore(Pedido source)
        {
            return source.Entregar ? "Sim" : "Não";
        }
    }
}