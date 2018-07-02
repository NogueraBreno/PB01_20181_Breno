using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VET.ApplicationCore.Entity;

namespace VET.ApplicationCore.Interfaces.Services
{
    public interface IClienteServices
    {

        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        void Remover(Cliente entity);
    }
}
