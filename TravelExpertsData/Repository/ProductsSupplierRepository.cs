using TravelExpertsData.Models;

namespace TravelExpertsData.Repository
{
    public class ProductSupplierRepository : Repository<ProductsSupplier>, IProductSupplierRepository
    {
        private readonly TravelExpertsContext _context;

        public ProductSupplierRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

        // Get all ProductsSupplier
        public async Task<ProductsSupplier> GetByIdAsync(int productId, int supplierId)
        {
            return await _context.ProductsSuppliers
                .FirstOrDefaultAsync(ps => ps.ProductId == productId && ps.SupplierId == supplierId);
        }

        // Add a new ProductsSupplier if it does not exist, otherwise return the existing one
        public async Task<ProductsSupplier> AddOrGetAsync(int productId, int supplierId)
        {
            var productSupplier = await GetByIdAsync(productId, supplierId);
            if (productSupplier == null)
            {
                productSupplier = new ProductsSupplier
                {
                    ProductId = productId,
                    SupplierId = supplierId
                };
                await _context.ProductsSuppliers.AddAsync(productSupplier);
                await _context.SaveChangesAsync(); // Ensure ProductSupplier is saved to get its ID
            }
            return productSupplier;
        }

        // Check if a ProductsSupplier exists
        public async Task<bool> HasRelationsAsync(Expression<Func<ProductsSupplier, bool>> predicate)
        {
            return await _context.ProductsSuppliers.AnyAsync(predicate);
        }

        // Get all ProductsSupplier that match the predicate
        public async Task<IEnumerable<ProductsSupplier>> GetRelationsAsync(Expression<Func<ProductsSupplier, bool>> predicate)
        {
            return await _context.Set<ProductsSupplier>().Where(predicate).ToListAsync();
        }
    }
}
