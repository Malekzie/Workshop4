using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository
{
    public class ProductSupplierRepository : Repository<ProductsSupplier>, IProductSupplierRepository
    {
        public ProductSupplierRepository(TravelExpertsContext context) : base(context)
        {
        }
    }
}
