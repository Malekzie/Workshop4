using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData.Models;

namespace TravelExpertsData.Repository.IRepository
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Supplier GetSupplierByName(string name);
        IEnumerable<Supplier> GetSuppliersByProductId(int productId);
    }
}
