namespace TravelExpertsData.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<bool> DeleteProductAsync(int productId);
    }
}
