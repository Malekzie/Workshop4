using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TravelExpertsData.Models;

namespace TravelExpertsData.DataAccess;

public partial class TravelExpertsContext : DbContext
{
    public TravelExpertsContext()
    {
    }

    public TravelExpertsContext(DbContextOptions<TravelExpertsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsSupplier> ProductsSuppliers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=INDROMATOV;Initial Catalog=TravelExperts;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId)
                .HasName("aaaaaPackages_PK")
                .IsClustered(false);

            entity.Property(e => e.PkgAgencyCommission).HasDefaultValue(0m);
        });

        modelBuilder.Entity<PackagesProductsSupplier>(entity =>
        {
            entity.HasKey(e => e.PackageProductSupplierId).HasName("PK__Packages__53E8ED99B65B5F2C");

            entity.HasOne(d => d.Package).WithMany(p => p.PackagesProductsSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Packages_Products_Supplie_FK00");

            entity.HasOne(d => d.ProductSupplier).WithMany(p => p.PackagesProductsSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Packages_Products_Supplie_FK01");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId)
                .HasName("aaaaaProducts_PK")
                .IsClustered(false);
        });

        modelBuilder.Entity<ProductsSupplier>(entity =>
        {
            entity.HasKey(e => e.ProductSupplierId)
                .HasName("aaaaaProducts_Suppliers_PK")
                .IsClustered(false);

            entity.Property(e => e.ProductId).HasDefaultValue(0);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsSuppliers).HasConstraintName("Products_Suppliers_FK00");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ProductsSuppliers).HasConstraintName("Products_Suppliers_FK01");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId)
                .HasName("aaaaaSuppliers_PK")
                .IsClustered(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
