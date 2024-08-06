using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData.Repository.IRepository;
using TravelExpertsData.Models;

namespace Main
{
    public partial class AddModifySingle : Form
    {
        private readonly string _operationType;
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _dataType;
        private readonly int _id;

        public AddModifySingle(IUnitOfWork unitOfWork, string dataType, string operationType, int id = 0)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _dataType = dataType;
            _operationType = operationType;
            _id = id;

            InitializeForm().ConfigureAwait(false);
        }

        private async Task InitializeForm()
        {
            ConfigureForm();

            if (_operationType == "Add")
            {
                await LoadNextId();
            }
            else if (_operationType == "Modify")
            {
                txtId.ReadOnly = true;
                await LoadData(_id);
            }
        }

        private void ConfigureForm()
        {
            if (_dataType == "ProductDTO")
            {
                Text = _operationType == "Add" ? "Add Product" : "Modify Product";
                lblId.Text = "Product Id";
                lblName.Text = "Product Name";
            }
            else if (_dataType == "SupplierDTO")
            {
                Text = _operationType == "Add" ? "Add Supplier" : "Modify Supplier";
                lblId.Text = "Supplier Id";
                lblName.Text = "Supplier Name";
            }
        }

        private async Task LoadNextId()
        {
            if (_dataType == "ProductDTO")
            {
                var nextId = await _unitOfWork.Products.GetNextIdAsync();
                txtId.Text = nextId.ToString();
            }
            else if (_dataType == "SupplierDTO")
            {
                var nextId = await _unitOfWork.Suppliers.GetNextIdAsync();
                txtId.Text = nextId.ToString();
            }
        }

        private async Task LoadData(int id)
        {
            try
            {
                if (_dataType == "ProductDTO")
                {
                    var product = await _unitOfWork.Products.GetByIdAsync(id);
                    if (product != null)
                    {
                        LoadProdToForm(product);
                    }
                }
                else if (_dataType == "SupplierDTO")
                {
                    var supplier = await _unitOfWork.Suppliers.GetByIdAsync(id);
                    if (supplier != null)
                    {
                        LoadSuppToForm(supplier);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void LoadProdToForm(Product product)
        {
            txtId.Text = product.ProductId.ToString();
            txtName.Text = product.ProdName;
        }

        private void LoadSuppToForm(Supplier supplier)
        {
            txtId.Text = supplier.SupplierId.ToString();
            txtName.Text = supplier.SupName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (_operationType == "Add")
                {
                    await AddDataAsync();
                }
                else if (_operationType == "Modify")
                {
                    await ModifyDataAsync();
                }
                MessageBox.Show($"{_operationType} operation completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task AddDataAsync()
        {
            if (_dataType == "ProductDTO")
            {
                await _unitOfWork.Products.AddAsync(new Product { ProdName = txtName.Text });
            }
            else if (_dataType == "SupplierDTO")
            {
                await _unitOfWork.Suppliers.AddAsync(new Supplier { SupName = txtName.Text });
            }
            await _unitOfWork.CompleteAsync();
        }

        private async Task ModifyDataAsync()
        {
            if (_dataType == "ProductDTO")
            {
                var product = await _unitOfWork.Products.GetByIdAsync(_id);
                if (product != null)
                {
                    product.ProdName = txtName.Text;
                    await _unitOfWork.Products.UpdateAsync(product);
                }
            }
            else if (_dataType == "SupplierDTO")
            {
                var supplier = await _unitOfWork.Suppliers.GetByIdAsync(_id);
                if (supplier != null)
                {
                    supplier.SupName = txtName.Text;
                    await _unitOfWork.Suppliers.UpdateAsync(supplier);
                }
            }
            await _unitOfWork.CompleteAsync();
        }
    }
}
