using System;
using System.Collections.Generic;
using System.Text;

namespace VET.ApplicationCore.Entity
{
    public class Consulta
    {
        public Consulta()
        {
        }

        public int ConsultaId { get; set; }
        //Não consegui adicionar a data pelo  initializer
        public string Data { get; set; }
        public string Observacao { get; set; }
        public Animal Animal { get; set; }

    }
}
