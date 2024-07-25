using System.ComponentModel.DataAnnotations;

namespace TravelExpertsData.Models.ViewModel
{
    public class ProductsSupplierDTO
    {
        [Display(Name = "Product Supplier ID")]
        public int ProductSupplierId { get; set; }

        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [Display(Name = "Supplier Name")]
        public string? SupplierName { get; set; }

    }
}
