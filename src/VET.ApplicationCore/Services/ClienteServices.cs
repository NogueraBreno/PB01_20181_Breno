using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VET.ApplicationCore.Entity;
using VET.ApplicationCore.Interfaces.Repository;
using VET.ApplicationCore.Interfaces.Services;

namespace VET.ApplicationCore.Services
{
    public class ClienteServices : IClienteServices
    {

        protected readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Cliente Adicionar(Cliente endity)
        {
          return  _clienteRepository.Adicionar(endity);
        }

        public void Atualizar(Cliente endity)
        {
            _clienteRepository.Atualizar(endity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
            
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}
