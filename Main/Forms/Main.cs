using Main.Utils;
using Main.Services;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        private readonly SearchService _searchService;
        private readonly AddModifyService _mainService;

        public Main()
        {
            InitializeComponent();
            _searchService = new SearchService();
            _mainService = new AddModifyService();
        }

        // Loads Data into form
        private void LoadData<T>(List<T> data, string dataType)
        {
            // Clear existing data
            dgvView.DataSource = null;
            // Load new data
            dgvView.DataSource = data;
            // Utility to rename columns
            ColRename.RenameColumns(dgvView, dataType);
        }

        // Event Handlers to view data
        private void viewPkg_Click(object sender, EventArgs e)
        {
            LoadData(DataCache.Instance.Packages, "PackageDTO");
        }

        private void viewProd_Click(object sender, EventArgs e)
        {
            LoadData(DataCache.Instance.Products, "ProductDTO");
        }

        private void viewSup_Click(object sender, EventArgs e)
        {
            LoadData(DataCache.Instance.Suppliers, "SupplierDTO");
        }

        private void viewProdSup_Click(object sender, EventArgs e)
        {
            LoadData(DataCache.Instance.DisplayProductSuppliers, "ProductSupplierDTO");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event Handler for search functionality
        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // Search functionality
        private void PerformSearch()
        {
            // Extracts search query
            string query = txtQuery.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(query))
            {
                // Perform search using query
                var results = _searchService.PerformSearch(query);
                // Display search results
                dgvView.DataSource = results;
                // Hide Data column
                dgvView.Columns["Data"].Visible = false;
            }
            else
            {
                // Clear search results
                dgvView.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get entity type from view
            string entityType = GetEntityTypeFromView();
            if (!string.IsNullOrEmpty(entityType))
            {
                // Handle Add operation
                _mainService.HandleAdd(entityType);
                // Refresh data
                RefreshData(entityType);
            }
            else
            {
                MessageBox.Show("Please select a view to add a new item.");
            }
        }

        // Event Handler for Modify operation
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count > 0)
            {
                // Get selected item
                var selectedItem = dgvView.SelectedRows[0].DataBoundItem;
                // Handle Modify operation
                _mainService.HandleModify(selectedItem);
                // Get entity type from selected item
                string entityType = GetEntityTypeFromItem(selectedItem);
                // Refresh data
                RefreshData(entityType);
            }
            else
            {
                MessageBox.Show("Please select an item to modify.");
            }
        }

        // Event Handler to extract entity from DataGridView
        private string GetEntityTypeFromView()
        {
            if (dgvView.DataSource is List<PackageDTO>)
            {
                return "Package";
            }
            else if (dgvView.DataSource is List<ProductDTO>)
            {
                return "Product";
            }
            else if (dgvView.DataSource is List<SupplierDTO>)
            {
                return "Supplier";
            }
            else if (dgvView.DataSource is List<ProductsSupplierDTO>)
            {
                return "ProductSupplier";
            }
            return null;
        }

        // Event Handler to extract entity from selected item
        private string GetEntityTypeFromItem(object item)
        {
            if (item is PackageDTO)
            {
                return "Package";
            }
            else if (item is ProductDTO)
            {
                return "Product";
            }
            else if (item is SupplierDTO)
            {
                return "Supplier";
            }
            else if (item is ProductsSupplierDTO)
            {
                return "ProductSupplier";
            }
            return null;
        }

        // Refresh data
        private void RefreshData(string entityType)
        {
            if (entityType == "Package")
            {
                LoadData(DataCache.Instance.Packages, "PackageDTO");
            }
            else if (entityType == "Product")
            {
                LoadData(DataCache.Instance.Products, "ProductDTO");
            }
            else if (entityType == "Supplier")
            {
                LoadData(DataCache.Instance.Suppliers, "SupplierDTO");
            }
            else if (entityType == "ProductSupplier")
            {
                LoadData(DataCache.Instance.ProductSuppliers, "ProductSupplierDTO");
            }
        }
    }
}
