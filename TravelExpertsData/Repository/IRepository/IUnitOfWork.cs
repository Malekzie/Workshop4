using System;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ISupplierRepository Suppliers { get; }
        IProductSupplierRepository ProductSuppliers { get; }
        IPackageRepository Packages { get; }
        IPackageProductSupplierRepository PackageProductSuppliers { get; }
        int Complete();
    }
}
