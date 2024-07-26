using TravelExpertsData.Models;

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

        public async Task<bool> DeleteProductAsync(int productId)
        {

            // Check if there are related ProductSupplier entries
            bool hasRelations = await _context.ProductsSuppliers.AnyAsync(ps => ps.ProductId == productId);
            if (hasRelations)
            {
                return false;
            }

            // Proceed with deletion if there are no relations
            var supplier = await _context.Suppliers.FindAsync(productId);
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
