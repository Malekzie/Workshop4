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

        public class SearchResult
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public object Data { get; set; }
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
                btnAdd.Enabled = false;

                var productResults = DataCache.Instance.Products
                                                     .Where(p => p.ProdName.ToLower().Contains(query))
                                                     .Select(p => new SearchResult { Type = "Product", Name = p.ProdName, Data = p })
                                                     .ToList();

                var packageResults = DataCache.Instance.Packages
                                                    .Where(p => p.PkgName.ToLower().Contains(query))
                                                    .Select(p => new SearchResult { Type = "Package", Name = p.PkgName, Data = p })
                                                    .ToList();

                var supplierResults = DataCache.Instance.Suppliers
                                                    .Where(s => s.SupName.ToLower().Contains(query))
                                                    .Select(s => new SearchResult { Type = "Supplier", Name = s.SupName, Data = s })
                                                    .ToList();

                var productSupplierResults = DataCache.Instance.ProductSuppliers
                                                               .Where(ps => ps.ProductId.ToString().Contains(query) || ps.SupplierId.ToString().Contains(query))
                                                               .Select(ps => new SearchResult { Type = "ProductSupplier", Name = $"ProductID: {ps.ProductId}, SupplierID: {ps.SupplierId}", Data = ps })
                                                               .ToList();

                // Combine all results
                var results = productResults
                                  .Union(packageResults)
                                  .Union(supplierResults)
                                  .Union(productSupplierResults)
                                  .ToList();

                dgvView.DataSource = results;
                dgvView.Columns["Data"].Visible = false;
            }
            else
            {
                btnAdd.Enabled = true;
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
            if (dgvView.SelectedRows.Count > 0)
            {
                var selectedItem = dgvView.SelectedRows[0].DataBoundItem;

                if (selectedItem is PackageDTO selectedPackage)
                {
                    // Item is directly a PackageDTO
                    using (var form = new AddModifyPackages(selectedPackage))
                    {
                        form.Text= "Modify Package";
                        form.ShowDialog();
                    }
                }
                else if (selectedItem is SearchResult searchResult && searchResult.Type == "Package")
                {
                    // Item is a SearchResult and of type "Package"
                    var package = (PackageDTO)searchResult.Data;
                    using (var form = new AddModifyPackages(package))
                    {
                        form.Text = "Modify Package";
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Selected item is not a package.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to modify.");
            }
        }
    }
}
