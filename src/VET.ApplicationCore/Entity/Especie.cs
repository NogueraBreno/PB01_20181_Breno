using System;
using System.Collections.Generic;
using System.Text;

namespace VET.ApplicationCore.Entity
{
    public class Especie
    {
        public Especie()
        {
        }

        public int EspecieId { get; set; }
        public string Descricao { get; set; }
        public Animal Animal { get; set; }

    }
}
