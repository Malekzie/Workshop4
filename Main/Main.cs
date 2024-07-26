using Main.Services;
using Main.Utils;
using System.ComponentModel;
using TravelExpertsData.Models;
using TravelExpertsData.Repository.IRepository;

namespace Main
{
    public partial class Main : Form
    {
        private string currentDataType = "";
        private readonly IUnitOfWork _unitOfWork;
        private readonly SearchService _searchService;

        public Main(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            _searchService = new SearchService(_unitOfWork);
        }

        // Refreshes the DataGridView
        private void LoadData<T>(List<T> data, string dataType)
        {
            // Clear the data grid view
            dgvView.DataSource = null;

            // Replace the data grid view data source with our provided list
            dgvView.DataSource = data;

            // Rename our DataGridView column using the given formatted string
            ColRename.RenameColumns(dgvView, dataType);
        }

        private async void txtQuery_TextChanged(object sender, EventArgs e)
        {
            await PerformSearch(txtQuery.Text);
        }

        private async Task PerformSearch(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                dgvView.DataSource = null; // Clear the data grid view if the query is empty
                return;
            }

            try
            {
                var results = _searchService.PerformSearch(query);

                if (results == null || !results.Any())
                {
                    MessageBox.Show("No search results found.");
                    dgvView.DataSource = null; // Clear the data grid view if no results
                    return;
                }

                var bindingList = new BindingList<SearchResult>(results);
                var bindingSource = new BindingSource(bindingList, null);

                dgvView.DataSource = bindingSource;

                dgvView.Columns["Data"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}");
            }
        }



        // If the user clicks the "Packages" button,
        private async void viewPkg_Click(object sender, EventArgs e)
        {
            // Sets current Data Type
            currentDataType = "PackageDTO";
            // Calls the util to refresh the view, reflecting changes everytime there is a change
            var data = await DataRefreshUtil.LoadPackagesDataAsync(_unitOfWork);
            // Loads the data into the view
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Products" button,
        private async void viewProd_Click(object sender, EventArgs e)
        {
            // Sets current Data Type
            currentDataType = "ProductDTO";
            var data = await DataRefreshUtil.LoadProductsDataAsync(_unitOfWork);
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Suppliers" button,
        private async void viewSup_Click(object sender, EventArgs e)
        {
            currentDataType = "SupplierDTO";
            var data = await DataRefreshUtil.LoadSuppliersDataAsync(_unitOfWork);
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Product Suppliers" button,
        private async void viewProdSup_Click(object sender, EventArgs e)
        {
            currentDataType = "ProductSupplierDTO";
            var data = await DataRefreshUtil.LoadProductSuppliersDataAsync(_unitOfWork);
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Exit" button,
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.
            Application.Exit();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentDataType == "")
            {
                MessageBox.Show("No table has been selected. Please choose one from the sidebar before adding a row.", "Cannot Add Row");
                return;
            }

            if (currentDataType == "PackageDTO")
            {
                using var form = new AddModifyPackages("Add", _unitOfWork);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
            if (currentDataType == "ProductDTO" || currentDataType == "SupplierDTO")
            {
                using var form = new AddModifySingle(_unitOfWork, currentDataType, "Add");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon(_unitOfWork, "Add");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            // Checks to prevent errors
            if (currentDataType == "")
            {
                MessageBox.Show("No table has been selected. Please choose one from the sidebar before editing a row.", "Cannot Edit Row");
                return;
            }

            if (dgvView.CurrentRow == null || dgvView.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("No row selected or the selected row ID is invalid.", "Cannot Edit Row");
                return;
            }

            if (!int.TryParse(dgvView.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("Selected row ID is invalid.", "Cannot Edit Row");
                return;
            }

            if (currentDataType == "PackageDTO")
            {
                using var form = new AddModifyPackages("Modify", _unitOfWork, id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
            if (currentDataType == "ProductDTO" || currentDataType == "SupplierDTO")
            {
                using var form = new AddModifySingle(_unitOfWork, currentDataType, "Modify", id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon(_unitOfWork, "Modify", id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvView.CurrentRow == null)
            {
                MessageBox.Show("Please select a package to delete.");
                return;
            }

            // Ensure that the selected row's cells are not null
            if (dgvView.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Selected package ID is invalid.");
                return;
            }

            // Convert the selected package ID to an integer
            if (!int.TryParse(dgvView.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("Selected package ID is invalid.");
                return;
            }

            if (currentDataType == "")
            {
                MessageBox.Show("No table has been selected. Please choose one from the sidebar before removing a row.", "Cannot Remove Row");
                return;
            }

            if (currentDataType == "PackageDTO")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this package?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {

                    await _unitOfWork.Packages.DeletePackageAsync(id);
                    await _unitOfWork.CompleteAsync();


                    MessageBox.Show("Package Deleted");
                    await RefreshData();
                }
            }
            else if (currentDataType == "ProductDTO")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    var doubleConfirm = MessageBox.Show("It will delete all all entries related, are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (doubleConfirm == DialogResult.Yes)
                    {
                        try
                        {
                            await _unitOfWork.Products.DeleteProductAsync(id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        await _unitOfWork.CompleteAsync();

                        MessageBox.Show("Product Deleted");
                        await RefreshData();
                    }
                }
            }
            else if (currentDataType == "SupplierDTO")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    var doubleConfirm = MessageBox.Show("It will delete all all entries related, are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (doubleConfirm == DialogResult.Yes)
                    {

                        try
                        {
                            await _unitOfWork.Suppliers.DeleteSupplierAsync(id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        await _unitOfWork.CompleteAsync();

                        MessageBox.Show("Supplier Deleted");
                        await RefreshData();
                    }
                }
            }
            else if (currentDataType == "ProductSupplierDTO")
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this product supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    await _unitOfWork.ProductsSuppliers.DeleteAsync(id);
                    await _unitOfWork.CompleteAsync();

                    MessageBox.Show("Product Supplier Deleted");
                    await RefreshData();
                }
            }
        }


        private async Task RefreshData()
        {
            switch (currentDataType)
            {
                case "PackageDTO":
                    var packageData = await DataRefreshUtil.LoadPackagesDataAsync(_unitOfWork);
                    LoadData(packageData, currentDataType);
                    break;
                case "ProductDTO":
                    var productData = await DataRefreshUtil.LoadProductsDataAsync(_unitOfWork);
                    LoadData(productData, currentDataType);
                    break;
                case "SupplierDTO":
                    var supplierData = await DataRefreshUtil.LoadSuppliersDataAsync(_unitOfWork);
                    LoadData(supplierData, currentDataType);
                    break;
                case "ProductSupplierDTO":
                    var productSupplierData = await DataRefreshUtil.LoadProductSuppliersDataAsync(_unitOfWork);
                    LoadData(productSupplierData, currentDataType);
                    break;
                default:
                    break;
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await _searchService.InitializeDataAsync();
        }
    }
}
