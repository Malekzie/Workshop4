namespace TravelExpertsData.Repository
{
    public class PackagesProductsSupplierRepository : Repository<PackagesProductsSupplierDTO>, IPackagesProductsSupplierRepository
    {
        private readonly TravelExpertsContext _context;

        public PackagesProductsSupplierRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddPackagesProductsSupplierAsync(int packageId, int productSupplierId)
        {
            var packagesProductsSupplier = new PackagesProductsSupplierDTO
            {
                PackageId = packageId,
                ProductSupplierId = productSupplierId
            };

            await _context.PackagesProductsSuppliers.AddAsync(packagesProductsSupplier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePackagesProductsSuppliersAsync(int packageId, List<int> productSupplierIds)
        {
            var existingRelations = await _context.PackagesProductsSuppliers
                .Where(p => p.PackageId == packageId)
                .ToListAsync();

            _context.PackagesProductsSuppliers.RemoveRange(existingRelations);

            var newRelations = productSupplierIds.Select(id => new PackagesProductsSupplierDTO
            {
                PackageId = packageId,
                ProductSupplierId = id
            });

            await _context.PackagesProductsSuppliers.AddRangeAsync(newRelations);
            await _context.SaveChangesAsync();
        }
    }
}
