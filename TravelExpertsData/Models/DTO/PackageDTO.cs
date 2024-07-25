namespace TravelExpertsData.Models.DTO
{
    public class PackageDTO
    {
        [Display(Name = "Package ID")]
        public int PackageId { get; set; }

        [Display(Name = "Package Name")]
        public string PkgName { get; set; } = null!;

        [Display(Name = "Start Date")]
        public DateTime? PkgStartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime? PkgEndDate { get; set; }

        [Display(Name = "Description")]
        public string PkgDesc { get; set; } = null!;

        [Display(Name ="Base Price")]
        public decimal PkgBasePrice { get; set; }

        [Display(Name = "Agency Commission")]
        public decimal? PkgAgencyCommission { get; set; }

    }
}
