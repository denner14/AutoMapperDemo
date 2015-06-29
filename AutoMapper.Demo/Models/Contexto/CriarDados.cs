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


            context.SaveChanges();

            base.Seed(context);
        }
    }
}