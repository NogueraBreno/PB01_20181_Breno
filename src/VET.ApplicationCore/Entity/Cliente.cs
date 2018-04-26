using System;
using System.Collections.Generic;
using System.Text;

namespace VET.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Animal> animais { get; set; }



    }
}
