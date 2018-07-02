﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace VET.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<TEndity> where TEndity:class
    {
        TEndity Adicionar(TEndity endity);
        void Atualizar(TEndity endity);
        IEnumerable<TEndity> ObterTodos();
        TEndity ObterPorId(int id);
        IEnumerable<TEndity> Buscar(Expression<Func<TEndity, bool>> predicado);
        void Remover(TEndity endity);
    }
}
