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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public Product GetProductByName(string name)
        {
            return Context.Set<Product>().SingleOrDefault(p => p.ProdName == name);
        }

        public IEnumerable<Product> GetProductsBySupplierId(int supplierId)
        {
            return Context.Set<ProductsSupplier>()
                .Where(ps => ps.SupplierId == supplierId)
                .Select(ps => ps.Product)
                .ToList();
        }
    }
}
