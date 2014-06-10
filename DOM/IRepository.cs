using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.DOM
{
    public interface IRepository<T>
    {
        T Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(Func<T, bool> filter);
        IList<T> GetAll();
    }
}
