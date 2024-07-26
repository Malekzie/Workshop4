using Main.Utils;
using System;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IPackageRepository Packages { get; }
        IProductRepository Products { get; }
        ISupplierRepository Suppliers { get; }
        IProductSupplierRepository ProductsSuppliers { get; }
        IPackagesProductsSupplierRepository PackagesProductsSuppliers { get; }
        Task<int> CompleteAsync();
    }
}
