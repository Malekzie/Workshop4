using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;
using TravelExpertsData.Repository.IRepository;

namespace TravelExpertsData.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TravelExpertsContext _context;

        public UnitOfWork(TravelExpertsContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Suppliers = new SupplierRepository(_context);
            ProductSuppliers = new ProductSupplierRepository(_context);
            Packages = new PackageRepository(_context);
            PackageProductSuppliers = new PackageProductSupplierRepository(_context);
        }

        public IProductRepository Products { get; private set; }
        public ISupplierRepository Suppliers { get; private set; }
        public IProductSupplierRepository ProductSuppliers { get; private set; }
        public IPackageRepository Packages { get; private set; }
        public IPackageProductSupplierRepository PackageProductSuppliers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
