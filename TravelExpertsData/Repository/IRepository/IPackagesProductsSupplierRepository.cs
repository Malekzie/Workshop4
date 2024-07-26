namespace TravelExpertsData.Repository.IRepository
{
    public interface IPackagesProductsSupplierRepository : IRepository<PackagesProductsSupplierDTO>
    {
        Task AddPackagesProductsSupplierAsync(int packageId, int productSupplierId);
        Task UpdatePackagesProductsSuppliersAsync(int packageId, List<int> productSupplierIds);
    }
}
