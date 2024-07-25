﻿using Main.Utils;
using TravelExpertsData.Models.DTO;

namespace TravelExpertsData.Repository
{
    public class PackageRepository : Repository<Package>, IPackageRepository
    {
        private readonly TravelExpertsContext _context;
        public PackageRepository(TravelExpertsContext context) : base(context)
        {
            _context = context;
        }

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
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                // e.g., _logger.LogError(ex, "An error occurred while deleting the package.");
                throw; // Optionally rethrow the exception or handle it accordingly
            }
        }

        public async Task<IEnumerable<PackageProductSupplierDTO>> GetProdSupAsync(int packageId)
        {
            var result = await (from pps in _context.PackagesProductsSuppliers
                                join p in _context.Packages on pps.PackageId equals p.PackageId
                                join ps in _context.ProductsSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                                join pr in _context.Products on ps.ProductId equals pr.ProductId
                                join s in _context.Suppliers on ps.SupplierId equals s.SupplierId
                                where pps.PackageId == packageId
                                select new PackageProductSupplierDTO
                                {
                                    PackageID = pps.PackageId,
                                    ProductSupplierID = pps.ProductSupplierId,
                                    ProductName = pr.ProdName,
                                    SupplierName = s.SupName
                                }).ToListAsync();

            return result;
        }
    }
}
