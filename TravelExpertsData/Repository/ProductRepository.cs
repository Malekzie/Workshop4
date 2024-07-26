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
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return false;
            }

            // Delete related ProductSupplier entries
            var productSuppliers = _context.ProductsSuppliers.Where(ps => ps.ProductId == productId);
            _context.ProductsSuppliers.RemoveRange(productSuppliers);

            // Delete the product
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
