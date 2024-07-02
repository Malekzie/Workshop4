using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelExpertsData.Models;

public partial class Package
{
    [Key]
    public int PackageId { get; set; }

    [StringLength(50)]
    public string PkgName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PkgStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PkgEndDate { get; set; }

    [StringLength(50)]
    public string? PkgDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal PkgBasePrice { get; set; }

    [Column(TypeName = "money")]
    public decimal? PkgAgencyCommission { get; set; }

    [InverseProperty("Package")]
    public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; } = new List<PackagesProductsSupplier>();
}

public class PackageDTO
{
    public int PackageId { get; set; }
    public string PkgName { get; set; } = null!;
    public DateTime? PkgStartDate { get; set; }
    public DateTime? PkgEndDate { get; set; }
    public string PkgDesc { get; set; } = null!;
    public decimal PkgBasePrice { get; set; }
    public decimal? PkgAgencyCommission { get; set; }
}

