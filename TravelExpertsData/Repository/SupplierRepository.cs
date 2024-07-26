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
            // Find the supplier
            var supplier = await _context.Suppliers.FindAsync(supplierId);
            if (supplier == null)
            {
                return false;
            }

            // Delete related ProductSupplier entries
            var productSuppliers = _context.ProductsSuppliers.Where(ps => ps.SupplierId == supplierId);
            _context.ProductsSuppliers.RemoveRange(productSuppliers);

            // Delete the supplier
            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
