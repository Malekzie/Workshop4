using Main.Utils;
using TravelExpertsData.Repository.IRepository;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData.Models.DTO;
using TravelExpertsData.Models.ViewModel;
using Main.Services;

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
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                var results = await _searchService.PerformSearchAsync(query);

                if (results == null)
                {
                    MessageBox.Show("Search results are null.");
                    return;
                }

                if (results.Any())
                {
                    var firstResult = results.First();

                    if (firstResult == null)
                    {
                        MessageBox.Show("First search result is null.");
                        return;
                    }

                    if (firstResult.Data == null)
                    {
                        MessageBox.Show("Data in the first search result is null.");
                        return;
                    }

                    currentDataType = firstResult.Type;
                    LoadData(results.Select(r => r.Data).ToList(), currentDataType);
                }
                else
                {
                    dgvView.DataSource = null; // Clear the data grid view if no results
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}");
            }
        }


        // If the user clicks the "Packages" button,
        private async void viewPkg_Click(object sender, EventArgs e)
        {
            await LoadPackagesData();
        }

        private async Task LoadPackagesData()
        {
            var data = (await _unitOfWork.Packages.GetAllAsync()).Select(p => new PackageDTO
            {
                PackageId = p.PackageId,
                PkgName = p.PkgName,
                PkgStartDate = p.PkgStartDate,
                PkgEndDate = p.PkgEndDate,
                PkgDesc = p.PkgDesc,
                PkgBasePrice = p.PkgBasePrice,
                PkgAgencyCommission = p.PkgAgencyCommission
            }).ToList();
            currentDataType = "PackageDTO";
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Products" button,
        private async void viewProd_Click(object sender, EventArgs e)
        {
            await LoadProductsData();
        }

        private async Task LoadProductsData()
        {
            var data = (await _unitOfWork.Products.GetAllAsync()).Select(p => new ProductDTO
            {
                ProductId = p.ProductId,
                ProdName = p.ProdName
            }).ToList();
            currentDataType = "ProductDTO";
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Suppliers" button,
        private async void viewSup_Click(object sender, EventArgs e)
        {
            await LoadSuppliersData();
        }

        private async Task LoadSuppliersData()
        {
            var data = (await _unitOfWork.Suppliers.GetAllAsync()).Select(s => new SupplierDTO
            {
                SupplierId = s.SupplierId,
                SupName = s.SupName
            }).ToList();
            currentDataType = "SupplierDTO";
            LoadData(data, currentDataType);
        }

        // If the user clicks the "Product Suppliers" button,
        private async void viewProdSup_Click(object sender, EventArgs e)
        {
            await LoadProductSuppliersData();
        }

        private async Task LoadProductSuppliersData()
        {
            var data = (await _unitOfWork.ProductsSuppliers.GetAllAsync(ps => ps.Product, ps => ps.Supplier)).Select(ps => new ProductsSupplierDTO
            {
                ProductSupplierId = ps.ProductSupplierId,
                ProductName = ps.Product?.ProdName,
                SupplierName = ps.Supplier?.SupName
            }).ToList();
            currentDataType = "ProductSupplierDTO";
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
                using var form = new AddModifySingle(currentDataType, "Add");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon("Add");
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
                using var form = new AddModifySingle(currentDataType, "Modify", id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await RefreshData();
                }
            }
            if (currentDataType == "ProductSupplierDTO")
            {
                using var form = new AddModifyCommon("Modify", id);
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
        }


        private async Task RefreshData()
        {
            switch (currentDataType)
            {
                case "PackageDTO":
                    await LoadPackagesData();
                    break;
                case "ProductDTO":
                    await LoadProductsData();
                    break;
                case "SupplierDTO":
                    await LoadSuppliersData();
                    break;
                case "ProductSupplierDTO":
                    await LoadProductSuppliersData();
                    break;
                default:
                    break;
            }
        }

        
    }
}
