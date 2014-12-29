using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories.Interfaces;
using Repositories.UnitOfWork;

namespace Repositories.Implemantations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected IUnitOfWork m_UnitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            m_UnitOfWork = unitOfWork;
        }

        public TEntity Create(TEntity entity)
        {
            return m_UnitOfWork.Create(entity);
        }

        public TEntity Get(int id)
        {
            return m_UnitOfWork.Get<TEntity>(id);
        }

        public IEnumerable<TEntity> Get(int[] id)
        {
            return m_UnitOfWork.AsQueryableForWithTracking<TEntity>().Where(e => id.Contains(e.Id)).ToList();
        }


        public IEnumerable<TEntity> Get()
        {
            return m_UnitOfWork.AsQueryableForWithTracking<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            m_UnitOfWork.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            m_UnitOfWork.Delete(entity);
        }
    }
}
