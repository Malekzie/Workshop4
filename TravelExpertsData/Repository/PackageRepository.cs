using Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Models;

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
    }
}
