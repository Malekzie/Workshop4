using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Models.DTO
{
    public class PackageProductSupplierDTO
    {
        public int PackageID { get; set; }
        public int ProductSupplierID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
    }
}
