namespace TravelExpertsData.Models;

[Index("ProductId", Name = "ProductId")]
public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [StringLength(50)]
    public string ProdName { get; set; } = null!;

    [InverseProperty("Product")]
    public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; } = new List<ProductsSupplier>();
}
