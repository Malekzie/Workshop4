// Threaded Project 2 Workshop 4 
// Created by Robbie Soriano
// Modified by Ryan Medeiros
// Defines our primary form as called my main() in Program.cs

//Application dependencies
using Main.Utils;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Repository.IRepository;

namespace Main
{
    public partial class Main : Form
    {

        private string currentDataType = "";
        private readonly IUnitOfWork _unitOfWork;

        public Main(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            context = new TravelExpertsContext();
        }

        //Refreshes the DataGridView
        private void LoadData<T>(List<T> data, string dataType)
        {
            // Clear the data grid view
            dgvView.DataSource = null;

            // Replace the data grid view data source with our provided list
            dgvView.DataSource = data;

            //Rename our DataGridView column using the given formatted string
            ColRename.RenameColumns(dgvView, dataType);
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // Handles cell click events if necessary
        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //If the user clicks the "Packages" button, 
        private void viewPkg_Click(object sender, EventArgs e)
        {
            lastViewAction = "Package"; // Set the last view action
            var data = DataCache.Instance.Packages;
            currentDataType = "PackageDTO";
            LoadData(data, currentDataType);
            MessageBox.Show("Packages Loaded");
        }

        //If the user clicks the "Products" button, 
        private void viewProd_Click(object sender, EventArgs e)
        {
            lastViewAction = "Product"; // Set the last view action
            var data = DataCache.Instance.Products;
            currentDataType = "ProductDTO";
            LoadData(data, currentDataType);
        }

        //If the user clicks the "Suppliers" button, 
        private void viewSup_Click(object sender, EventArgs e)
        {
            lastViewAction = "Supplier"; // Set the last view action
            var data = DataCache.Instance.Suppliers;
            currentDataType = "SupplierDTO";
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Product Suppliers" button,
        private void viewProdSup_Click(object sender, EventArgs e)
        {
            lastViewAction = "ProductSupplier"; // Set the last view action
            var data = DataCache.Instance.ProductSuppliers;
            currentDataType = "ProductSupplierDTO";
            LoadData(data, currentDataType); // Adjust as needed
        }

        // If the user clicks the "Exit" button,
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentDataType == "")
            {
                MessageBox.Show("No table has been selected. Please choose one from the sidebar before adding a row.", "Cannot Add Row");
                return;
            }
            if (currentDataType == "PackageDTO")
            {
                using var form = new AddModifyPackages("Add");
                form.ShowDialog();
            }
            if (currentDataType == "ProductDTO" | currentDataType == "SupplierDTO")
            {
                using var form = new AddModifySingle(currentDataType, "Add");
                form.ShowDialog();
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon("Add");
                form.ShowDialog();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (currentDataType == "")
            {
                MessageBox.Show("No table has been selected. Please choose one from the sidebar before editing a row.", "Cannot Edit Row");
                return;
            }
            if (currentDataType == "PackageDTO")
            {
                using var form = new AddModifyPackages("Modify", Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value));
                form.ShowDialog(); //Reminder, change from arbitray DGV value to datasource value
            }
            if (currentDataType == "ProductDTO" | currentDataType == "SupplierDTO")
            {
                using var form = new AddModifySingle(currentDataType, "Modify", Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value));
                form.ShowDialog(); //Reminder, change from arbitray DGV value to datasource value
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon("Modify", Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value));
                form.ShowDialog();
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
            if (!int.TryParse(dgvView.CurrentRow.Cells[0].Value.ToString(), out int packageId))
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
                    try
                    {

                        await _unitOfWork.Packages.DeletePackageAsync(packageId);
                        await _unitOfWork.CompleteAsync();

                        DataCache.Instance.Refresh();

                        MessageBox.Show("Package Deleted");
                        dgvView.DataSource = DataCache.Instance.Packages;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the package. Please try again. { ex.Message }");
                    }
                }
            }
        }
    }
}
