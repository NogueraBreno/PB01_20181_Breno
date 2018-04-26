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


            var animais = new Animal[]
            {
                new Animal
                {
                    Idade = 2,
                    Genero = "M",
                    Nome = "Shaman",
                    Cliente = clientes[0]
                },

                new Animal
                {
                    Idade = 1,
                    Genero = "F",
                    Nome = "Lyria",
                    Cliente = clientes[1]
                }

            };

            context.AddRange(animais);

            var especies = new Especie[]
            {

                new Especie
                {
                    Descricao = "Pastor Alemão"

                },

                new Especie
                {

                    Descricao = "RedHeeler"
                }


            };

            context.AddRange(especies);

            var consultas = new Consulta[]
            {
                new Consulta
                {
                    Data  = "01/04/2018",
                    Observacao = "Vacina anti rabica"
                },

                new Consulta
                {
                    Data  = "02/04/2018",
                    Observacao = "Ressonancia magnetica"

                }

            };

            context.AddRange(consultas);

            context.SaveChanges();


        }
    }
}
