using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Models;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IProductSupplierRepository : IRepository<ProductsSupplier>
    {
        IEnumerable<ProductsSupplier> GetByProductId(int productId);
        IEnumerable<ProductsSupplier> GetBySupplierId(int supplierId);
    }
}
