using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);

        TEntity Get(int id);

        IEnumerable<TEntity> Get(int[] id);

        IEnumerable<TEntity> Get();

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
