using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VET.ApplicationCore.Entity;

namespace VET.Infrastructure.Data
{
   public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {

            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente {
                    Nome = "Fulano da Silva",
                    Email = "Fulano@fulanice.com"
                },

                 new Cliente {
                    Nome = "Beltrano da Silva",
                    Email = "Beltrano@fulanice.com"
                }
            };

            context.AddRange(clientes);

            var enderecos = new Endereco[]
            {
                new Endereco {
                    CEP = "00000000",
                    Bairro = "Aquele lá",
                    Logradouro = "Rua cabulosa",
                    Numero = "771",
                    Cliente = clientes[0]
                },

                new Endereco {
                     CEP = "00000000",
                    Bairro = "Aquele lá",
                    Logradouro = "Rua cabulosa",
                    Numero = "771",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(enderecos);

            context.SaveChanges();


        }
    }
}
