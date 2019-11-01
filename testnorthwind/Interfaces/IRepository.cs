using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testnorthwind.Interfaces
{
    public interface IRepository<T> where T:class
    {
        T Find(int id);
        IEnumerable<T> List();
        T Add(T model);
        T Update(T model);
        void Delete(int id);
    }
}
