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

        private void LoadData<T>(List<T> data, string dataType)
        {
            dgvView.DataSource = null;
            dgvView.DataSource = data;
            ColRename.RenameColumns(dgvView, dataType);
        }

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

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string query = txtQuery.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(query))
            {
                var results = _searchService.PerformSearch(query);
                dgvView.DataSource = results;
                dgvView.Columns["Data"].Visible = false;
            }
            else
            {
                dgvView.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string entityType = GetEntityTypeFromView();
            if (!string.IsNullOrEmpty(entityType))
            {
                _mainService.HandleAdd(entityType);
                RefreshData(entityType);
            }
            else
            {
                MessageBox.Show("Please select a view to add a new item.");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count > 0)
            {
                var selectedItem = dgvView.SelectedRows[0].DataBoundItem;
                _mainService.HandleModify(selectedItem);
                string entityType = GetEntityTypeFromItem(selectedItem);
                RefreshData(entityType);
            }
            else
            {
                MessageBox.Show("Please select an item to modify.");
            }
        }

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