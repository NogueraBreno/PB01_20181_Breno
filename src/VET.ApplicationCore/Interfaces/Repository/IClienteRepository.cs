using System;
using System.Collections.Generic;
using System.Text;
using VET.ApplicationCore.Entity;

namespace VET.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorAnimais(int clienteId);

    }
}
