namespace TravelExpertsData.Repository
{
    public class ProductSupplierRepository : Repository<ProductsSupplier>, IProductSupplierRepository
    {
        private readonly TravelExpertsContext _context;

        public ProductSupplierRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ProductsSupplier> GetByIdAsync(int productId, int supplierId)
        {
            return await _context.ProductsSuppliers
                .FirstOrDefaultAsync(ps => ps.ProductId == productId && ps.SupplierId == supplierId);
        }

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

    }
}
