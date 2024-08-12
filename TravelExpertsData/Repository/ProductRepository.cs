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

        /// <summary>
        /// Delete a product and its related ProductSupplier entries
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Bool true if product gets deleted, false if product is not found</returns>
        public async Task<bool> DeleteProductAsync(int productId)
        {
            // Find the product
            var product = await _context.Products.FindAsync(productId);
            // If product is not found, return false
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
