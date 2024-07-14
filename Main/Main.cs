// Threaded Project 2 Workshop 4 
// Created by Robbie Soriano
// Modified by Ryan Medeiros
// Defines our primary form as called my main() in Program.cs

//Application dependencies
using Main.Utils;
using TravelExpertsData.DataAccess;

namespace Main
{
    public partial class Main : Form
    {
        //Initializes our primary form. 
        public Main()
        {
            InitializeComponent();
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
        }

        // Handles cell click events if necessary
        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //If the user clicks the "Packages" button, 
        private void viewPkg_Click(object sender, EventArgs e)
        {
            //Copy the cached database entries to the DataGridView
            LoadData(DataCache.Instance.Packages, "PackageDTO");
        }

        //If the user clicks the "Products" button, 
        private void viewProd_Click(object sender, EventArgs e)
        {
            //Copy the cached database entries to the DataGridView
            LoadData(DataCache.Instance.Products, "ProductDTO");
        }

        //If the user clicks the "Suppliers" button, 
        private void viewSup_Click(object sender, EventArgs e)
        {
            //Copy the cached database entries to the DataGridView
            LoadData(DataCache.Instance.Suppliers, "SupplierDTO");
        }

        // If the user clicks the "Product Suppliers" button,
        private void viewProdSup_Click(object sender, EventArgs e)
        {
            //Copy the cached database entries to the DataGridView
            LoadData(DataCache.Instance.ProductSuppliers, "ProductSupplierDTO");
        }

        // If the user clicks the "Exit" button,
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.
            Application.Exit();
        }

        // If the user clicks either "Add" or "Modify", 
        private void OpenAddModifyForm(string dataType)
        {
            using (var form = new AddModifyPackages())
            {
                // Show the necessary modal form. 
                form.ShowDialog();
            }
        }

    }
}
