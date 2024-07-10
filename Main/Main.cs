using Main.Utils;
using Main.Services;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;
using System.Linq;

namespace Main
{
    public partial class Main : Form
    {
        private readonly SearchService _searchService;

        public Main()
        {
            InitializeComponent();
            _searchService = new SearchService();
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
            LoadData(DataCache.Instance.ProductSuppliers, "ProductSupplierDTO");
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
                btnAdd.Enabled = false;
                var results = _searchService.PerformSearch(query);
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
            OpenAddModifyPackagesForm();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count > 0)
            {
                var selectedItem = dgvView.SelectedRows[0].DataBoundItem;
                HandleModifyPackage(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to modify.");
            }
        }

        private void HandleModifyPackage(object selectedItem)
        {
            if (selectedItem is PackageDTO selectedPackage)
            {
                OpenAddModifyPackagesForm(selectedPackage, "Modify Package");
            }
            else if (selectedItem is SearchResult searchResult && searchResult.Type == "Package")
            {
                var package = (PackageDTO)searchResult.Data;
                OpenAddModifyPackagesForm(package, "Modify Package");
            }
            else
            {
                MessageBox.Show("Selected item is not a package.");
            }
        }

        private void OpenAddModifyPackagesForm(PackageDTO package = null, string formTitle = "Add Package")
        {
            using (var form = new AddModifyPackages(package))
            {
                form.Text = formTitle;
                form.ShowDialog();
            }
        }
    }
}
