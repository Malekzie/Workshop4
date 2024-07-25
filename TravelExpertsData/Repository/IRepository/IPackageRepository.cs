namespace Main.Utils
{
    public interface IPackageRepository : IRepository<Package>
    {
        Task DeletePackageAsync(int id);
    }
}
