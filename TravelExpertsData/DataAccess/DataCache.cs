using System.Collections.Generic;
using System.Linq;
using TravelExpertsData.Models;
using TravelExpertsData.Repositories;
using TravelExpertsData.Repository.IRepository;
using TravelExpertsData.Repository;

namespace TravelExpertsData.DataAccess
{
    public class DataCache
    {
        private static DataCache instance = null;
        private static readonly object padlock = new object();
        private readonly IUnitOfWork _unitOfWork;

        public List<PackageDTO> Packages { get; set; }
        public List<ProductDTO> Products { get; set; }
        public List<SupplierDTO> Suppliers { get; set; }
        public List<ProductsSupplierDTO> ProductSuppliers { get; set; }

        DataCache(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            LoadData();
        }

        public static DataCache Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataCache(new UnitOfWork(new TravelExpertsContext()));
                    }
                    return instance;
                }
            }
        }

        private void LoadData()
        {
            Packages = _unitOfWork.Packages.GetAll().Select(p => new PackageDTO
            {
                PackageId = p.PackageId,
                PkgName = p.PkgName,
                PkgStartDate = p.PkgStartDate,
                PkgEndDate = p.PkgEndDate,
                PkgDesc = p.PkgDesc,
                PkgBasePrice = p.PkgBasePrice,
                PkgAgencyCommission = p.PkgAgencyCommission
            }).ToList();

            Products = _unitOfWork.Products.GetAll().Select(p => new ProductDTO
            {
                ProductId = p.ProductId,
                ProdName = p.ProdName
            }).ToList();

            Suppliers = _unitOfWork.Suppliers.GetAll().Select(s => new SupplierDTO
            {
                SupplierId = s.SupplierId,
                SupName = s.SupName
            }).ToList();

            ProductSuppliers = _unitOfWork.ProductSuppliers.GetAll().Select(ps => new ProductsSupplierDTO
            {
                ProductSupplierId = ps.ProductSupplierId,
                ProductId = ps.ProductId,
                SupplierId = ps.SupplierId,
                ProductName = ps.Product.ProdName,
                SupplierName = ps.Supplier.SupName
            }).ToList();
        }

        public void ReloadPackages()
        {
            Packages = _unitOfWork.Packages.GetAll().Select(p => new PackageDTO
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

        public void ReloadProducts()
        {
            Products = _unitOfWork.Products.GetAll().Select(p => new ProductDTO
            {
                ProductId = p.ProductId,
                ProdName = p.ProdName
            }).ToList();
        }

        public void ReloadSuppliers()
        {
            Suppliers = _unitOfWork.Suppliers.GetAll().Select(s => new SupplierDTO
            {
                SupplierId = s.SupplierId,
                SupName = s.SupName
            }).ToList();
        }

        public void ReloadProductSuppliers()
        {
            ProductSuppliers = _unitOfWork.ProductSuppliers.GetAll().Select(ps => new ProductsSupplierDTO
            {
                ProductSupplierId = ps.ProductSupplierId,
                ProductId = ps.ProductId,
                SupplierId = ps.SupplierId,
                ProductName = ps.Product.ProdName,
                SupplierName = ps.Supplier.SupName
            }).ToList();
        }
    }
}
