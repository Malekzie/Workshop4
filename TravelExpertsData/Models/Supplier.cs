using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelExpertsData.Models;

[Index("SupplierId", Name = "SupplierId")]
public partial class Supplier
{
    [Key]
    public int SupplierId { get; set; }

    [StringLength(255)]
    public string? SupName { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<ProductsSupplier> ProductsSuppliers { get; set; } = new List<ProductsSupplier>();
}

public class SupplierDTO
{
    public int SupplierId { get; set; }
    public string SupName { get; set; } = null!;

}