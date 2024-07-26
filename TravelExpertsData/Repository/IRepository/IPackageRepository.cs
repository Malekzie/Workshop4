using TravelExpertsData.Models.DTO;

namespace Main.Utils
{
    public interface IPackageRepository : IRepository<Package>
    {
        Task DeletePackageAsync(int id);
        Task <IEnumerable<PackageProdSupDTO>> GetProdSupAsync(int packageId);
        Task UpdateRelations(int packageId, List<int> productSupplierIds);
    }
}
