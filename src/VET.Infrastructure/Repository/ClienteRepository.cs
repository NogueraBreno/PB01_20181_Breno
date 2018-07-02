using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VET.ApplicationCore.Entity;
using VET.ApplicationCore.Interfaces.Repository;
using VET.Infrastructure.Data;

namespace VET.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(ClienteContext dbContext):base(dbContext)

        {


        }       


        public override Cliente Adicionar(Cliente endity)
        {
            var verificarResultado = "";
            _dbContext.Set<Cliente>().Add(endity);
            _dbContext.SaveChanges();
            return endity;
        }

        public Cliente ObterPorAnimais(int clienteId)
        {
            return Buscar(x => x.Animais.Any(p => p.ClienteId == clienteId)).FirstOrDefault();


        }
    }
}
