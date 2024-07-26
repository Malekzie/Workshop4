using Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TravelExpertsContext _context;

        public IPackageRepository Packages { get; private set; }
        public IProductRepository Products { get; private set; }
        public ISupplierRepository Suppliers { get; private set; }
        public IProductSupplierRepository ProductSuppliers { get; private set; }
        public IRepository<PackagesProductsSupplierDTO> PackagesProductsSuppliers { get; private set; }

        public UnitOfWork(TravelExpertsContext context)
        {
            _context = context;
            Packages = new PackageRepository(_context);
            Products = new ProductRepository(_context);
            Suppliers = new SupplierRepository(_context);
            ProductSuppliers = new ProductSupplierRepository(_context);
            PackagesProductsSuppliers = new Repository<PackagesProductsSupplierDTO>(_context);
        }

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
