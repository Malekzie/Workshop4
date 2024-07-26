﻿using Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IPackageRepository Packages { get; }
        IProductRepository Products { get; }
        ISupplierRepository Suppliers { get; }
        IProductSupplierRepository ProductSuppliers { get; }
        IPackagesProductsSupplierRepository PackagesProductsSuppliers { get; }
        Task<int> CompleteAsync();
    }
}
