using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testnorthwind.Models;

namespace testnorthwind.Interfaces
{
    public interface IProductRepository:IRepository<Product>
    {
        IEnumerable<Product> GetByCategoryId(int id);
    }
}
