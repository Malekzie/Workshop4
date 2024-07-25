using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Models;
using TravelExpertsData.Repositories;
using TravelExpertsData.Repository.IRepository;

namespace TravelExpertsData.Repository
{
    public class ProductSupplierRepository : Repository<ProductsSupplier>, IProductSupplierRepository
    {
        public ProductSupplierRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<ProductsSupplier> GetByProductId(int productId)
        {
            return Context.Set<ProductsSupplier>()
                .Where(ps => ps.ProductId == productId)
                .ToList();
        }

        public IEnumerable<ProductsSupplier> GetBySupplierId(int supplierId)
        {
            return Context.Set<ProductsSupplier>()
                .Where(ps => ps.SupplierId == supplierId)
                .ToList();
        }
    }
}
