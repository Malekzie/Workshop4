﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IProductSupplierRepository : IRepository<ProductsSupplier>
    {
        Task<ProductsSupplier> GetByIdAsync(int productId, int supplierId);
    }
}
