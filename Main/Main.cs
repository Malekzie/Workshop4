using Main.Utils;
using Microsoft.EntityFrameworkCore;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;

namespace Main
{
    public partial class Main : Form
    {
        private string lastViewAction = ""; // Variable to store the last view action

        private readonly TravelExpertsContext context; // Ensure context is readonly, not sure this is ok

        public Main()
        {
            InitializeComponent();
            context = new TravelExpertsContext();
        }
        

        private void LoadData<T>(List<T> data, string dataType)
        {
            // Clears the data grid view
            dgvView.DataSource = null;
            // Replaces the data grid view data source with the new data
            dgvView.DataSource = data;
            ColRename.RenameColumns(dgvView, dataType);
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if necessary
        }

        private void viewPkg_Click(object sender, EventArgs e)
        {
            lastViewAction = "Package"; // Set the last view action
            var data = DataCache.Instance.Packages;
            LoadData(data, "PackageDTO");
        }

        private void viewProd_Click(object sender, EventArgs e)
        {
            lastViewAction = "Product"; // Set the last view action
            var data = DataCache.Instance.Products;
            LoadData(data, "ProductDTO");
        }

        private void viewSup_Click(object sender, EventArgs e)
        {
            lastViewAction = "Supplier"; // Set the last view action
            var data = DataCache.Instance.Suppliers;
            LoadData(data, "SupplierDTO");
        }

        private void viewProdSup_Click(object sender, EventArgs e)
        {
            lastViewAction = "ProductSupplier"; // Set the last view action
            var data = DataCache.Instance.ProductSuppliers;
            LoadData(data, "ProductSupplierDTO"); // Adjust as needed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OpenAddModifyForm(string dataType)
        {
            using (var form = new AddModifyPackages())
            {
                form.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvView.SelectedRows[0].Cells[$"{lastViewAction}Id"].Value);

                switch (lastViewAction)
                {
                    case "Package":
                        RemovePackage(selectedId);
                        break;
                    case "Product":
                        RemoveProduct(selectedId);
                        break;
                    case "Supplier":
                        RemoveSupplier(selectedId);
                        break;
                    case "ProductSupplier":
                        RemoveProductSupplier(selectedId);
                        break;
                    // Will add cases for other entities as/if needed
                    default:
                        MessageBox.Show("Unsupported action.");
                        break;
                }
            }
            else
            {
                MessageBox.Show($"Please select a {lastViewAction.ToLower()} to remove.");
            }

        }

        private void RemovePackage(int packageId)
        {
            var packageToRemove = context.Packages.Find(packageId);
            if (packageToRemove != null)
            {
                // Manually delete related PackagesProductsSuppliers
                var relatedPackagesProductsSuppliers = context.PackagesProductsSuppliers
                    .Where(pps => pps.PackageId == packageId)
                    .ToList();

                context.PackagesProductsSuppliers.RemoveRange(relatedPackagesProductsSuppliers);

                // Now delete the Package itself
                context.Packages.Remove(packageToRemove);
                context.SaveChanges();

                //LoadPackages(); //going to update this when I can figure out what data to pass in
                //supposed to refresh the table here
                MessageBox.Show("Package removed successfully.");
            }
            else
            {
                MessageBox.Show("Package not found.");
            }
        }

        private void RemoveProduct(int productId)
        {
            var productToRemove = context.Products.Find(productId);
            if (productToRemove != null)
            {
                // First, remove any entries in ProductsSuppliers that reference this product
                var relatedProductSuppliers = context.ProductsSuppliers
                    .Where(ps => ps.ProductId == productId)
                    .ToList();

                // Now delete the Product itself
                context.Products.Remove(productToRemove);
                context.SaveChanges();

                //LoadProducts(); // Refresh the DataGridView
                MessageBox.Show("Product removed successfully.");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void RemoveSupplier(int supplierId)
        {
            var supplierToRemove = context.Suppliers.Find(supplierId);
            if (supplierToRemove != null)
            {
                // Remove related entries in SupplierContacts
                var relatedSupplierContacts = context.SupplierContacts
                    .Where(sc => sc.SupplierId == supplierId)
                    .ToList();
                context.SupplierContacts.RemoveRange(relatedSupplierContacts);

                // Remove related entries in ProductsSuppliers
                var relatedProductSuppliers = context.ProductsSuppliers
                    .Where(ps => ps.SupplierId == supplierId)
                    .ToList();
                context.ProductsSuppliers.RemoveRange(relatedProductSuppliers);

                // Now delete the Supplier itself
                context.Suppliers.Remove(supplierToRemove);
                context.SaveChanges();

                MessageBox.Show("Supplier removed successfully.");
            }
            else
            {
                MessageBox.Show("Supplier not found.");
            }
        }

        private void RemoveProductSupplier(int productSupplierId)
        {
            var productSupplierToRemove = context.ProductsSuppliers.Find(productSupplierId);
            if (productSupplierToRemove != null)
            {
                context.ProductsSuppliers.Remove(productSupplierToRemove);
                context.SaveChanges();

                //LoadProductSuppliers(); //going to update this when I can figure out what data to pass in
                //supposed to refresh the table here
                MessageBox.Show("Product-Supplier relationship removed successfully.");
            }
            else
            {
                MessageBox.Show("Product-Supplier relationship not found.");
            }
        }

    }
}
