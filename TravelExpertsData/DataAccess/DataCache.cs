using TravelExpertsData.Models;

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
                    .Select(ps => new ProductsSupplierDTO
                    {
                        ProductSupplierId = ps.ProductSupplierId,
                        ProductId = ps.ProductId,
                        SupplierId = ps.SupplierId
                    }).ToList();

                PackageProductSuppliers = context.PackagesProductsSuppliers.ToList();
            }
        }
    }
}
