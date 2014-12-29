using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BaseService
{
    public interface IClassifierService<T> where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(int[] id);
        T Get(int id);
    }
}
