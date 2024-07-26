namespace TravelExpertsData.Repository.IRepository
{
    public interface IProductSupplierRepository : IRepository<ProductsSupplier>
    {
        // Gets a single ProductsSupplier by its primary key
        Task<ProductsSupplier> GetByIdAsync(int productId, int supplierId);
        // Adds a new ProductsSupplier if it does not exist, otherwise returns the existing one
        Task<ProductsSupplier> AddOrGetAsync(int productId, int supplierId);
        // Checks if a ProductsSupplier exists
        Task<bool> HasRelationsAsync(Expression<Func<ProductsSupplier, bool>> predicate);
        // Gets all ProductsSupplier that match the predicate
        Task<IEnumerable<ProductsSupplier>> GetRelationsAsync(Expression<Func<ProductsSupplier, bool>> predicate);

        // Add new methods here
    }
}

