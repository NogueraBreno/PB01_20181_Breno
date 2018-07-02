using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using VET.ApplicationCore.Interfaces.Repository;
using VET.Infrastructure.Data;

namespace VET.Infrastructure.Repository
{
    public class EFRepository<TEndity> : IRepository<TEndity> where TEndity : class
    {
        protected readonly ClienteContext _dbContext;

        public EFRepository (ClienteContext dbContext)
        {
            _dbContext = dbContext;
        }


        public virtual TEndity Adicionar(TEndity entity)
        {

            _dbContext.Set<TEndity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;

        }

        public void Atualizar(TEndity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
                    }

        public IEnumerable<TEndity> Buscar(Expression<Func<TEndity, bool>> predicado)
        {
            return _dbContext.Set<TEndity>().Where(predicado).AsEnumerable();
        }

        public virtual TEndity ObterPorId(int id)
        {
            return _dbContext.Set<TEndity>().Find(id);
        }

        public IEnumerable<TEndity> ObterTodos()
        {
            return _dbContext.Set<TEndity>().AsEnumerable();
        }

        public void Remover(TEndity entity)
        {
            _dbContext.Set<TEndity>().Remove(entity);
            _dbContext.SaveChanges();

        }
    }
}
