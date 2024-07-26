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

    }
}
