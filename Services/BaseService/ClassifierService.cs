using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Interfaces;

namespace Services.BaseService
{
    public class ClassifierService<T> : IClassifierService<T> where T : class
    {
        private IRepository<T> m_Repository;

        public ClassifierService()
        {
        }

        public ClassifierService(IRepository<T> repository)
        {
            m_Repository = repository;
        }

        public IEnumerable<T> Get()
        {
            return m_Repository.Get();
        }

        public IEnumerable<T> Get(int[] id)
        {
            return m_Repository.Get(id);
        }

        public T Get(int id)
        {
            return m_Repository.Get(id);
        }
    }
}
