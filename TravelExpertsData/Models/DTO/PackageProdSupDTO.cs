using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Models.DTO
{
    public class PackageProdSupDTO
    {
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
    }
}
