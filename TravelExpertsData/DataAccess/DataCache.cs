using TravelExpertsData.Models;
using TravelExpertsData.Models.DTO;
using TravelExpertsData.Models.ViewModel;


namespace TravelExpertsData.DataAccess
{
    public class DataCache
    {

        private static DataCache instance = null;
        private static readonly object padlock = new object();

        public List<PackageDTO> Packages { get; set; }
        public List<ProductDTO> Products { get; set; }
        public List<SupplierDTO> Suppliers { get; set; }
        public List<ProductsSupplierDTO> ProductSuppliers { get; set; }
        public List<PackagesProductsSupplier> PackageProductSuppliers { get; set; }

        DataCache()
        {
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
                        instance = new DataCache();
                    }
                    return instance;
                }
            }
        }

        // Add a method to refresh the data
        public void Refresh()
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new TravelExpertsContext())
                {
                Packages = context.Packages
                    .Select(p => new PackageDTO
                    {
                        PackageId = p.PackageId,
                        PkgName = p.PkgName,
                        PkgStartDate = p.PkgStartDate,
                        PkgEndDate = p.PkgEndDate,
                        PkgDesc = p.PkgDesc,
                        PkgBasePrice = p.PkgBasePrice,
                        PkgAgencyCommission = p.PkgAgencyCommission
                    }).ToList();

                Products = context.Products
                    .Select(p => new ProductDTO
                    {
                        ProductId = p.ProductId,
                        ProdName = p.ProdName
                    }).ToList();

                Suppliers = context.Suppliers
                    .Select(s => new SupplierDTO
                    {
                        SupplierId = s.SupplierId,
                        SupName = s.SupName
                    }).ToList();

                ProductSuppliers = context.ProductsSuppliers
                    .Join(context.Products, ps => ps.ProductId, p => p.ProductId, (ps, p) => new {ps, p})
                    .Join(context.Suppliers, ps2 => ps2.ps.SupplierId, s => s.SupplierId, (ps2, s) => new ProductsSupplierDTO
                {
                    ProductSupplierId = ps2.ps.ProductSupplierId,
                    ProductName = ps2.p.ProdName, 
                    SupplierName = s.SupName}).OrderBy(ps => ps.ProductSupplierId).ToList();         
//Todo, clean up select statement and fix column orders
                PackageProductSuppliers = context.PackagesProductsSuppliers.ToList();
            }
        }
    }
}
