using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Models;
using TravelExpertsData.Repositories;
using TravelExpertsData.Repository.IRepository;

namespace TravelExpertsData.Repository
{
    public class PackageProductSupplierRepository : Repository<PackagesProductsSupplier>, IPackageProductSupplierRepository
    {
        public PackageProductSupplierRepository(DbContext context) : base(context)
        {
        }

    }
}
