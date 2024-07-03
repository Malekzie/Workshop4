using Main.Utils; // Make sure to include this namespace
using TravelExpertsData.DataAccess;

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


        private void OpenAddModifyForm(string dataType)
        {
            using (var form = new AddModifyPackages())
            {
                form.ShowDialog();
            }
        }

    }
}
