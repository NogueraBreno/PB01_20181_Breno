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


        public override Cliente Adicionar(Cliente entity)
        {
            var verificarResultado = "";
            _dbContext.Set<Cliente>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public Cliente ObterPorAnimais(int clienteId)
        {
            return Buscar(x => x.Animais.Any(p => p.ClienteId == clienteId)).FirstOrDefault();


        }
    }
}
