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

            InitializeForm();
        }

        private async void InitializeForm()
        {

            if (_operationType == "Add")
            {
                if (_dataType == "ProductDTO")
                {
                    Text = "Add Product";
                    lblId.Text = "Product Id";
                    lblName.Text = "Product Name";
                    var nextId = await _unitOfWork.Products.GetNextIdAsync();

                    txtId.Text = nextId.ToString();
                }
                else if (_dataType == "SupplierDTO")
                {
                    Text = "Add Supplier";
                    lblId.Text = "Supplier Id";
                    lblName.Text = "Supplier Name";
                    var nextId = await _unitOfWork.Suppliers.GetNextIdAsync();

                    txtId.Text = nextId.ToString();
                }
            }
            else if (_operationType == "Modify")
            {
                if (_dataType == "ProductDTO")
                {
                    Text = "Modify Product";
                    txtId.ReadOnly = true;
                }
                else if (_dataType == "SupplierDTO")
                {
                    Text = "Modify Supplier";
                    txtId.ReadOnly = true;
                }
            }

            LoadData(_id).ConfigureAwait(false);
        }

        private async Task LoadData(int id)
        {
            try
            {
                if (_dataType == "ProductDTO")
                {
                    var results = await _unitOfWork.Products.GetByIdAsync(id);
                    if (results != null)
                    {
                        LoadProdToForm(results);
                    }
                }
                else if (_dataType == "SupplierDTO")
                {
                    var results = await _unitOfWork.Suppliers.GetByIdAsync(id);
                    if (results != null)
                    {
                        LoadSuppToForm(results);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void LoadProdToForm(Product results)
        {
            txtId.Text = results.ProductId.ToString();
            txtName.Text = results.ProdName;
            lblId.Text = "Product Id";
            lblName.Text = "Product Name";
        }

        private void LoadSuppToForm(Supplier results)
        {
            txtId.Text = results.SupplierId.ToString();
            txtName.Text = results.SupName;
            lblId.Text = "Supplier Id";
            lblName.Text = "Supplier Name";
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataType == "ProductDTO")
                {
                    if (_operationType == "Add")
                    {
                        await AddProductAsync();
                    }
                    else if (_operationType == "Modify")
                    {
                        await ModifyProductAsync();
                    }
                }
                else if (_dataType == "SupplierDTO")
                {
                    if (_operationType == "Add")
                    {
                        await AddSupplierAsync();
                    }
                    else if (_operationType == "Modify")
                    {
                        await ModifySupplierAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task AddProductAsync()
        {
            await _unitOfWork.Products.AddAsync(new Product
            {
                ProdName = txtName.Text
            });
            MessageBox.Show("Product added successfully");
        }

        private async Task ModifyProductAsync()
        {
            await _unitOfWork.Products.UpdateAsync(new Product
            {
                ProdName = txtName.Text
            });
            MessageBox.Show("Product modified successfully");
        }

        private async Task AddSupplierAsync()
        {
            await _unitOfWork.Suppliers.AddAsync(new Supplier
            {
                SupName = txtName.Text
            });
            MessageBox.Show("Supplier added successfully");
        }

        private async Task ModifySupplierAsync()
        {
            await _unitOfWork.Suppliers.UpdateAsync(new Supplier
            {
                SupName = txtName.Text
            });
            MessageBox.Show("Supplier modified successfully");
        }



    }
}
