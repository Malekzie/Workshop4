using TravelExpertsData.Models.DTO;

namespace Main.Utils
{
    public interface IPackageRepository : IRepository<Package>
    {
        Task DeletePackageAsync(int id);
        Task <IEnumerable<PackageProductSupplierDTO>> GetProdSupAsync(int packageId);
        Task UpdateRelations(int packageId, List<int> prodSupId);
    }
}
