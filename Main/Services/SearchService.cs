using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;

namespace Main.Services
{
    public class SearchService
    {
        public List<SearchResult> PerformSearch(string query)
        {
            query = query.Trim().ToLower();
            var productResults = DataCache.Instance.Products
                .Where(p => p.ProdName.ToLower().Contains(query))
                .Select(p => new SearchResult { Type = "Product", Name = p.ProdName, Data = p })
                .ToList();

            var packageResults = DataCache.Instance.Packages
                .Where(p => p.PkgName.ToLower().Contains(query))
                .Select(p => new SearchResult { Type = "Package", Name = p.PkgName, Data = p })
                .ToList();

            var supplierResults = DataCache.Instance.Suppliers
                .Where(s => s.SupName.ToLower().Contains(query))
                .Select(s => new SearchResult { Type = "Supplier", Name = s.SupName, Data = s })
                .ToList();

            var productSupplierResults = DataCache.Instance.ProductSuppliers
                .Where(ps => ps.ProductId.ToString().Contains(query) || ps.SupplierId.ToString().Contains(query))
                .Select(ps => new SearchResult { Type = "ProductSupplier", Name = $"ProductID: {ps.ProductId}, SupplierID: {ps.SupplierId}", Data = ps })
                .ToList();

            return productResults
                .Union(packageResults)
                .Union(supplierResults)
                .Union(productSupplierResults)
                .ToList();
        }
    }
}
