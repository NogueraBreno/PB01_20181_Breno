using System;
using System.Collections.Generic;
using System.Text;

namespace VET.ApplicationCore.Entity
{
    public class Animal
    {
        public Animal()
        {
        }

        public int AnimalId { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Nome { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
        public Especie Especie { get; set; }

    }
}
