using System.Collections.Generic;
using System.Threading.Tasks;
using TravelExpertsData.Models.DTO;
using TravelExpertsData.Models.ViewModel;
using TravelExpertsData.Repository.IRepository;

namespace Main.Utils
{
    public static class DataRefreshUtil
    {
        public static async Task<List<PackageDTO>> LoadPackagesDataAsync(IUnitOfWork unitOfWork)
        {
            return (await unitOfWork.Packages.GetAllAsync()).Select(p => new PackageDTO
            {
                PackageId = p.PackageId,
                PkgName = p.PkgName,
                PkgStartDate = p.PkgStartDate,
                PkgEndDate = p.PkgEndDate,
                PkgDesc = p.PkgDesc,
                PkgBasePrice = p.PkgBasePrice,
                PkgAgencyCommission = p.PkgAgencyCommission
            }).ToList();
        }

        public static async Task<List<ProductDTO>> LoadProductsDataAsync(IUnitOfWork unitOfWork)
        {
            return (await unitOfWork.Products.GetAllAsync()).Select(p => new ProductDTO
            {
                ProductId = p.ProductId,
                ProdName = p.ProdName
            }).ToList();
        }

        public static async Task<List<SupplierDTO>> LoadSuppliersDataAsync(IUnitOfWork unitOfWork)
        {
            return (await unitOfWork.Suppliers.GetAllAsync()).Select(s => new SupplierDTO
            {
                SupplierId = s.SupplierId,
                SupName = s.SupName
            }).ToList();
        }

        public static async Task<List<ProductsSupplierDTO>> LoadProductSuppliersDataAsync(IUnitOfWork unitOfWork)
        {
            return (await unitOfWork.ProductsSuppliers.GetAllAsync(ps => ps.Product, ps => ps.Supplier)).Select(ps => new ProductsSupplierDTO
            {
                ProductSupplierId = ps.ProductSupplierId,
                ProductName = ps.Product?.ProdName,
                SupplierName = ps.Supplier?.SupName
            }).ToList();
        }
    }
}
