using Main.Utils; // Make sure to include this namespace
using TravelExpertsData.DataAccess;

namespace Main
{
    public partial class Main : Form
    {
        private string currentDataType = "";
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
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if necessary
        }

        private void viewPkg_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.Packages;
            currentDataType = "PackageDTO";
            LoadData(data, currentDataType);
        }

        private void viewProd_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.Products;
            currentDataType = "ProductDTO";
            LoadData(data, currentDataType);
        }

        private void viewSup_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.Suppliers;
            currentDataType = "SupplierDTO";
            LoadData(data, currentDataType);
        }

        private void viewProdSup_Click(object sender, EventArgs e)
        {
            var data = DataCache.Instance.ProductSuppliers;
            currentDataType = "ProductSupplierDTO";
            LoadData(data, currentDataType); // Adjust as needed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
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
                using var form = new AddModifySingle (currentDataType, "Modify", Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value));
                form.ShowDialog(); //Reminder, change from arbitray DGV value to datasource value
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon("Modify", Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value));
                form.ShowDialog();
            }
        }
    }
}
