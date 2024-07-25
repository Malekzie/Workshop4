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
    public class PackageRepository : Repository<Package>, IPackageRepository
    {
        public PackageRepository(DbContext context) : base(context)
        {
        }


    }
}
