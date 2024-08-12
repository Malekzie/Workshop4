namespace TravelExpertsData.Repository
{
    public class PackageRepository : Repository<Package>, IPackageRepository
    {
        private readonly TravelExpertsContext _context;
        public PackageRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Deletes a package by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeletePackageAsync(int id)
        {
            // Begin a transaction
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Finds the package
                var package = await _context.Packages.FindAsync(id);

                // If Found, delete relations and the package
                if (package != null)
                {
                    var relatedRecords = _context.PackagesProductsSuppliers
                    .Where(p => p.PackageId == package.PackageId);

                    _context.PackagesProductsSuppliers.RemoveRange(relatedRecords);
                    _context.Packages.Remove(package);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                // e.g., _logger.LogError(ex, "An error occurred while deleting the package.");
                throw; // Optionally rethrow the exception or handle it accordingly
            }
        }

        public async Task UpdateRelations(int packageId, List<int> newProductSupplierIds)
        {
            // Remove existing associations
            var existingAssociations = _context.PackagesProductsSuppliers.Where(pps => pps.PackageId == packageId);
            _context.PackagesProductsSuppliers.RemoveRange(existingAssociations);

            // Add new associations
            foreach (var newId in newProductSupplierIds)
            {
                var newAssociation = new PackagesProductsSupplierDTO
                {
                    PackageId = packageId,
                    ProductSupplierId = newId
                };
                await _context.PackagesProductsSuppliers.AddAsync(newAssociation);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PackageProdSupDTO>> GetProdSupAsync(int packageId)
        {
            var result = await (from pps in _context.PackagesProductsSuppliers
                                join ps in _context.ProductsSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                                join pr in _context.Products on ps.ProductId equals pr.ProductId
                                join s in _context.Suppliers on ps.SupplierId equals s.SupplierId
                                where pps.PackageId == packageId
                                select new PackageProdSupDTO
                                {
                                    PackageId = pps.PackageId,
                                    ProductSupplierId = pps.ProductSupplierId,
                                    ProductName = pr.ProdName,
                                    SupplierName = s.SupName
                                }).ToListAsync();

            return result;
        }


    }
}
