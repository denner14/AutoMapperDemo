using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AutoMapper.Demo.Models.Dominio;

namespace AutoMapper.Demo.Models.Contexto
{
    public class CriarDados : DropCreateDatabaseAlways<ContextoDB>
    {
        protected override void Seed(ContextoDB context)
        {

            new List<Cliente>
            {
                new Cliente {Nome="Donisetti",Sobrenome = "Ferreira Cosma"},
                  new Cliente {Nome="Luiz Fernando",Sobrenome = "Pientka"},
                    new Cliente {Nome="Fabiana",Sobrenome = "de Cosma Fernandes"},
                      new Cliente {Nome="Solange",Sobrenome = "Ferreira Cosma"},
                       new Cliente {Nome="Soleide",Sobrenome = "Ferreira Cosma"}
                
            }.ForEach(i => context.Clientes.Add(i));

            var cli1 = context.Clientes.Find(1);

            new List<Pedido>
            {
                new Pedido
                {
                    Cliente = cli1,
                    NumeroPedido = "000.001",
                    DataCompra = new DateTime(2015,6,28),
                    Entregar = false,
                    InternalId = new Guid(),
                    LinhaPedido = new List<ItensPedido>
                    {
                        new ItensPedido
                        {
                            Preco=5.4m,
                            Produto = "Pão de Queijo",
                            Quantidade = 3
                        
                        },
                         new ItensPedido
                        {
                            Preco=1.4m,
                            Produto = "Leite longa vida",
                            Quantidade = 12
                        
                        }
                    }
                }
            }.ForEach(i => context.Pedidos.Add(i));



            context.SaveChanges();

            base.Seed(context);
        }
    }
}