using Main.Utils;
using System.Threading.Tasks;
using TravelExpertsData.Repository.IRepository;

namespace TravelExpertsData.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TravelExpertsContext _context;

        public UnitOfWork(TravelExpertsContext context)
        {
            _context = context;
            Packages = new PackageRepository(_context);
            Products = new ProductRepository(_context);
            Suppliers = new SupplierRepository(_context);
            ProductsSuppliers = new ProductSupplierRepository(_context);
            PackagesProductsSuppliers = new PackagesProductsSupplierRepository(_context);
        }

        public IPackageRepository Packages { get; private set; }
        public IProductRepository Products { get; private set; }
        public ISupplierRepository Suppliers { get; private set; }
        public IProductSupplierRepository ProductsSuppliers { get; private set; }
        public IPackagesProductsSupplierRepository PackagesProductsSuppliers { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
