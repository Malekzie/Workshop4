using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly TravelExpertsContext _context;

        public ProductRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
