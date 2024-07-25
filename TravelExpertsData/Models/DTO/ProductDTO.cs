namespace TravelExpertsData.Models.DTO
{
    public class ProductDTO
    {
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]
        public string ProdName { get; set; } = null!;

    }
}
