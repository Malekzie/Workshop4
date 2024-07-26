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

        public async Task<bool> DeleteSupplierAsync(int supplierId)
        {
            // Check if there are related ProductSupplier entries
            bool hasRelations = await _context.ProductsSuppliers.AnyAsync(ps => ps.SupplierId == supplierId);
            if (hasRelations)
            {
                return false;
            }

            // Proceed with deletion if there are no relations
            var supplier = await _context.Suppliers.FindAsync(supplierId);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
