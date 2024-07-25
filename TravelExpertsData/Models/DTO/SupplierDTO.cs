namespace TravelExpertsData.Models.DTO
{
    public class SupplierDTO
    {
        [Display(Name = "Supplier ID")]
        public int SupplierId { get; set; }

        [Display(Name = "Supplier Name")]
        public string SupName { get; set; } = null!;

    }
}
