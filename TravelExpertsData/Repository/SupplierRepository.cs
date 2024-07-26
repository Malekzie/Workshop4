using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        private readonly TravelExpertsContext _context;

        public SupplierRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }
    }
}
