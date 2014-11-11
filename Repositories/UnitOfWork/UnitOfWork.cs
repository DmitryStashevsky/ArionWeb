using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DbContext m_Context;

        public void SaveChanges()
        {
            m_Context.SaveChanges();
        }

        public void DetectChanges()
        {
            m_Context.ChangeTracker.DetectChanges();
        }

        public TEntity Get<TEntity>(int id) where TEntity : class
        {
            return m_Context.Set<TEntity>().Find(id);
        }

        public TEntity Create<TEntity>(TEntity entity) where TEntity : class
        {
            TEntity createdEnity = m_Context.Set<TEntity>().Add(entity);
            SaveChanges();
            return createdEnity;
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            m_Context.Set<TEntity>().AddOrUpdate(entity);
            SaveChanges();
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            m_Context.Set<TEntity>().Remove(entity);
            SaveChanges();
        }

        public IQueryable<TEntity> AsQueryableFor<TEntity>() where TEntity : class
        {
            return m_Context.Set<TEntity>().AsNoTracking().AsQueryable();
        }

        public IQueryable<TEntity> AsQueryableForWithTracking<TEntity>() where TEntity : class
        {
            return m_Context.Set<TEntity>().AsQueryable();
        }
    }
}
