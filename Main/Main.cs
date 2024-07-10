using Main.Utils; // Make sure to include this namespace
using System.Diagnostics;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            var data = DataCache.Instance.Packages;
            LoadData(data, "PackageDTO");
        }

        private void viewProd_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.Products;
            LoadData(data, "ProductDTO");
        }

        private void viewSup_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.Suppliers;
            LoadData(data, "SupplierDTO");
        }

        private void viewProdSup_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.ProductSuppliers;
            LoadData(data, "ProductSupplierDTO"); // Adjust as needed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            // Performs the search based on the text in the search box
            PerformSearch();
        }

        private void PerformSearch()
        {
            string query = txtQuery.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(query))
            {
                // Search in Products
                var productResults = DataCache.Instance.Products
                                                     .Where(p => p.ProdName.ToLower().Contains(query))
                                                     .Select(p => new { Type = "Product", Name = p.ProdName })
                                                     .ToList();

                // Search in Packages
                var packageResults = DataCache.Instance.Packages
                                                .Where(p => p.PkgName.ToLower().Contains(query))
                                                .Select(p => new { Type = "Package", Name = p.PkgName })
                                                .ToList();

                // Search in Suppliers
                var supplierResults = DataCache.Instance.Suppliers
                                                  .Where(s => s.SupName.ToLower().Contains(query))
                                                  .Select(s => new { Type = "Supplier", Name = s.SupName })
                                                  .ToList();

                // Search in ProductSuppliers
                var productSupplierResults = DataCache.Instance.ProductSuppliers
                                                           .Where(ps => ps.ProductId.ToString().Contains(query) || ps.SupplierId.ToString().Contains(query))
                                                           .Select(ps => new { Type = "ProductSupplier", Name = $"ProductID: {ps.ProductId}, SupplierID: {ps.SupplierId}" })
                                                           .ToList();

                // Combine all results
                var results = productResults
                              .Union(packageResults)
                              .Union(supplierResults)
                              .Union(productSupplierResults)
                              .ToList();

                dgvView.DataSource = results;
            }
            else
            {
                dgvView.DataSource = null;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            using (var form = new AddModifyPackages())
            {
                form.ShowDialog();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("btnModify_Click triggered");
            if (dgvView.SelectedRows.Count > 0)
            {
                Debug.WriteLine("SelectedRows count: " + dgvView.SelectedRows.Count);
                // Assuming the DataGridView is bound to a list of PackageDTO
                var selectedPackage = (PackageDTO)dgvView.SelectedRows[0].DataBoundItem;

                // Pass the selected package to the AddModifyPackages form
                using (var form = new AddModifyPackages(selectedPackage))
                {
                    form.ShowDialog();
                }
            }
            else
            {
                Debug.WriteLine("No row selected");
                MessageBox.Show("Please select a package to modify.");
            }
        }
    }
}
