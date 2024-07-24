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
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DbContext context) : base(context)
        {
        }

        public Supplier GetSupplierByName(string name)
        {
            return Context.Set<Supplier>().SingleOrDefault(s => s.SupName == name);
        }

        public IEnumerable<Supplier> GetSuppliersByProductId(int productId)
        {
            return Context.Set<ProductsSupplier>()
                .Where(ps => ps.ProductId == productId)
                .Select(ps => ps.Supplier)
                .ToList();
        }
    }
}
