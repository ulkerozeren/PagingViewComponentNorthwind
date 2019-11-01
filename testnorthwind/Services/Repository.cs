using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testnorthwind.Interfaces;

namespace testnorthwind.Services
{
    public class Repository<T>:IRepository<T> where T:class
    {
        private readonly DbSet<T> _repository; 
        public Repository(DataContext dataContext)
        {
            _repository = dataContext.Set<T>();
        }

        public T Add(T model)
        {
            _repository.Add(model);
            return model;
        }

        public void Delete(int id)
        {
            T model = Find(id);
            if (model!=null)
            {
                _repository.Remove(model);
            }
        }

        public T Find(int id)
        {
            return _repository.Find(id);
        }

        public IEnumerable<T> List()
        {
            return _repository.ToList();
        }

        public T Update(T model)
        {
            _repository.Update(model);
            return model;
        }
    }
}
