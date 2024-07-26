namespace TravelExpertsData.Models;

[Table("Packages_Products_Suppliers")]
[Index("PackageId", Name = "PackagesPackages_Products_Suppliers")]
[Index("ProductSupplierId", Name = "ProductSupplierId")]
[Index("ProductSupplierId", Name = "Products_SuppliersPackages_Products_Suppliers")]
[Index("PackageId", "ProductSupplierId", Name = "UQ__Packages__29CA8E9589C9A9DF", IsUnique = true)]
public partial class PackagesProductsSupplierDTO
{
    [Key]
    public int PackageProductSupplierId { get; set; }

    public int PackageId { get; set; }

    public int ProductSupplierId { get; set; }

    public int ProductId { get; set; }
    public int ProductName { get; set; }
    public int SupplierId { get; set; }
    public int SupplierName { get; set; }

    [ForeignKey("PackageId")]
    [InverseProperty("PackagesProductsSuppliers")]
    public virtual Package Package { get; set; } = null!;

    [ForeignKey("ProductSupplierId")]
    [InverseProperty("PackagesProductsSuppliers")]
    public virtual ProductsSupplier ProductSupplier { get; set; } = null!;
}
