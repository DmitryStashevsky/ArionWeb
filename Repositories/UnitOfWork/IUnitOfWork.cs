using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SaveChanges();

        void DetectChanges();

        TEntity Get<TEntity>(int id) where TEntity : class;

        TEntity Create<TEntity>(TEntity entity) where TEntity : class;

        void Update<TEntity>(TEntity entity) where TEntity : class;

        void Delete<TEntity>(TEntity entity) where TEntity : class;

        IQueryable<TEntity> AsQueryableFor<TEntity>() where TEntity : class;

        IQueryable<TEntity> AsQueryableForWithTracking<TEntity>() where TEntity : class;
    }
}
