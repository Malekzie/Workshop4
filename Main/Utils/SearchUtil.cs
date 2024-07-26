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

        public SearchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<SearchResult>> PerformSearchAsync(string query)
        {
            query = query.Trim().ToLower();

            var productResults = (await _unitOfWork.Products.GetAllAsync())
                .Where(p => p.ProdName != null && (p.ProdName.ToLower().Contains(query) || "product".Contains(query)))
                .Select(p => new SearchResult { Type = "Product", Name = p.ProdName, Data = p })
                .ToList();

            var packageResults = (await _unitOfWork.Packages.GetAllAsync())
                .Where(p => p.PkgName != null && (p.PkgName.ToLower().Contains(query) || "package".Contains(query)))
                .Select(p => new SearchResult { Type = "Package", Name = p.PkgName, Data = p })
                .ToList();

            var supplierResults = (await _unitOfWork.Suppliers.GetAllAsync())
                .Where(s => s.SupName != null && (s.SupName.ToLower().Contains(query) || "supplier".Contains(query)))
                .Select(s => new SearchResult { Type = "Supplier", Name = s.SupName, Data = s })
                .ToList();

            var productSupplierResults = (await _unitOfWork.ProductsSuppliers.GetAllAsync(ps => ps.Product, ps => ps.Supplier))
                .Where(ps => ps.Product != null && ps.Supplier != null &&
                             (ps.Product.ProdName.ToLower().Contains(query) ||
                              ps.Supplier.SupName.ToLower().Contains(query) ||
                              "productsupplier".Contains(query) ||
                              $"productid: {ps.ProductId}".ToLower().Contains(query) ||
                              $"supplierid: {ps.SupplierId}".ToLower().Contains(query)))
                .Select(ps => new SearchResult { Type = "ProductSupplier", Name = $"Product: {ps.Product.ProdName}, Supplier: {ps.Supplier.SupName}", Data = ps })
                .ToList();

            return productResults
                .Union(packageResults)
                .Union(supplierResults)
                .Union(productSupplierResults)
                .ToList();
        }

    }
}
