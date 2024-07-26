namespace TravelExpertsData.Repository.IRepository
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
        Task<bool> DeleteSupplierAsync(int supplierId);
    }
}
