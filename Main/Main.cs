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

        //private async void txtQuery_TextChanged(object sender, EventArgs e)
        //{
        //    await PerformSearch(txtQuery.Text);
        //}

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


        //AG - The DTO DataTypes allow the recieving form to be choosen based on the table being acted upon
        //For the add/modify form, the type of operation is also passed. In the future I would use a better
        //method of passing the operation type, as using a verbose string is wasteful and potentially error prone. 

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

        //Checks the current table loaded when the user presses add and opens the relevant form
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

        //AG - Checks the current table loaded and opens the relevant table while sending the selected row's
        //ID to the next form. This method is hardcoded to read the first column and would break if the
        //columns were reorganized. In the future I should determine the value by detecting the primary key column. 
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

        //Checks the current table loaded and deletes the selected row.
        private async void btnRemove_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected
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

            // Check the current data type
            if (currentDataType == "")
            {
                MessageBox.Show("No table has been selected. Please choose one from the sidebar before removing a row.", "Cannot Remove Row");
                return;
            }

            // Check the current data type and delete the selected row
            if (currentDataType == "PackageDTO")
            {
                // Confirm the deletion
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this package?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    // Delete the package
                    await _unitOfWork.Packages.DeletePackageAsync(id);
                    await _unitOfWork.CompleteAsync();

                    // Display a message box to confirm the deletion
                    MessageBox.Show("Package Deleted");
                    await RefreshData();
                }
            }

            // Check the current data type and delete the selected row
            else if (currentDataType == "ProductDTO")
            {
                // Confirm the deletion
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    // Confirm the deletion
                    var doubleConfirm = MessageBox.Show("It will delete all all entries related, are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (doubleConfirm == DialogResult.Yes)
                    {
                        // Delete the product
                        try
                        {
                            await _unitOfWork.Products.DeleteProductAsync(id);
                        }
                        // Catch any exceptions and display an error message
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        await _unitOfWork.CompleteAsync();

                        // Display a message box to confirm the deletion
                        MessageBox.Show("Product Deleted");
                        await RefreshData();
                    }
                }
            }
            // Check the current data type and delete the selected row
            else if (currentDataType == "SupplierDTO")
            {
                // Confirm the deletion
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    // Confirm the deletion
                    var doubleConfirm = MessageBox.Show("It will delete all all entries related, are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (doubleConfirm == DialogResult.Yes)
                    {
                        // Delete the supplier
                        try
                        {
                            await _unitOfWork.Suppliers.DeleteSupplierAsync(id);
                        }
                        // Catch any exceptions and display an error message
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        await _unitOfWork.CompleteAsync();

                        // Display a message box to confirm the deletion
                        MessageBox.Show("Supplier Deleted");
                        await RefreshData();
                    }
                }
            }
            // Check the current data type and delete the selected row
            else if (currentDataType == "ProductSupplierDTO")
            {
                // Confirm the deletion
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this product supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    // Delete the product supplier
                    await _unitOfWork.ProductsSuppliers.DeleteAsync(id);
                    await _unitOfWork.CompleteAsync();

                    // Display a message box to confirm the deletion
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
