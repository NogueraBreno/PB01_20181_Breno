using System;
using System.Collections.Generic;
using System.Text;

namespace VET.ApplicationCore.Entity
{
    class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }

    }
}
