using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Models;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductByName(string name);
        IEnumerable<Product> GetProductsBySupplierId(int supplierId);
    }
}
