using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelExpertsData.Repository.IRepository;
using TravelExpertsData.Models.DTO;
using TravelExpertsData.Models;

namespace Main.Services
{
    public class SearchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private List<Product> _productList;
        private List<Package> _packageList;
        private List<Supplier> _supplierList;
        private List<ProductsSupplier> _productSupplierList;

        public SearchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task InitializeDataAsync()
        {
            _productList = (await _unitOfWork.Products.GetAllAsync()).ToList();
            _packageList = (await _unitOfWork.Packages.GetAllAsync()).ToList();
            _supplierList = (await _unitOfWork.Suppliers.GetAllAsync()).ToList();
            _productSupplierList = (await _unitOfWork.ProductsSuppliers.GetAllAsync(ps => ps.Product, ps => ps.Supplier)).ToList();
        }

        public List<SearchResult> PerformSearch(string query)
        {
            query = query.Trim().ToLower();

            var productResults = _productList
                .Where(p => p.ProdName != null && (p.ProdName.ToLower().Contains(query) || "product".Contains(query)))
                .Select(p => new SearchResult { Type = "Product", Name = p.ProdName, Data = p })
                .ToList();

            var packageResults = _packageList
                .Where(p => p.PkgName != null && (p.PkgName.ToLower().Contains(query) || "package".Contains(query)))
                .Select(p => new SearchResult { Type = "Package", Name = p.PkgName, Data = p })
                .ToList();

            var supplierResults = _supplierList
                .Where(s => s.SupName != null && (s.SupName.ToLower().Contains(query) || "supplier".Contains(query)))
                .Select(s => new SearchResult { Type = "Supplier", Name = s.SupName, Data = s })
                .ToList();

            var productSupplierResults = _productSupplierList
                .Where(ps => ps.Product != null && ps.Supplier != null &&
                             (ps.Product.ProdName.ToLower().Contains(query) ||
                              ps.Supplier.SupName.ToLower().Contains(query) ||
                              "productsupplier".Contains(query) ||
                              $"productid: {ps.ProductId}".ToLower().Contains(query) ||
                              $"supplierid: {ps.SupplierId}".ToLower().Contains(query)))
                .Select(ps => new SearchResult 
                { 
                    Type = "ProductSupplier", 
                    Name = $"Product: {ps.Product.ProdName}, " +
                    $"Supplier: {ps.Supplier.SupName}", 
                    Data = ps,
                })
                .ToList();

            return productResults
                .Union(packageResults)
                .Union(supplierResults)
                .Union(productSupplierResults)
                .ToList();
        }
    }
}
