using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Repository.IRepository;

namespace TravelExpertsData.Repository
{
    public class PackagesProductsSupplierRepository : Repository<PackagesProductsSupplierDTO>, IPackagesProductsSupplierRepository
    {
        public PackagesProductsSupplierRepository(TravelExpertsContext context) : base(context)
        {
        }
    }
}
