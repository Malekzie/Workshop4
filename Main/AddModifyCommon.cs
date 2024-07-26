using System.ComponentModel;
using TravelExpertsData.Models;
using TravelExpertsData.Repository.IRepository;

namespace Main
{
    public partial class AddModifyCommon : Form
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly string _operationType;
        private readonly int _id;

        public AddModifyCommon(IUnitOfWork unitOfWork, string operationType, int id = 0)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _operationType = operationType;
            _id = id;

            InitializeForm();
        }

        private async void InitializeForm()
        {
            if (_operationType == "Add")
            {
                await LoadAddForm();
            }
            else if (_operationType == "Modify")
            {
                await LoadModifyForm(_id);
            }
        }

        private async Task LoadAddForm()
        {
            Text = "Add Product Suppliers";
            lblRel1.Text = "Products:";
            lblRel2.Text = "Suppliers:";

            cboRel1.DataSource = await _unitOfWork.Products.GetAllAsync();
            cboRel1.DisplayMember = "ProdName";
            cboRel1.ValueMember = "ProductId";
            cboRel2.DataSource = await _unitOfWork.Suppliers.GetAllAsync();
            cboRel2.DisplayMember = "SupName";
            cboRel2.ValueMember = "SupplierId";
        }

        private async Task LoadModifyForm(int id)
        {
            Text = "Modify Product Suppliers";
            lblRel1.Text = "Products:";
            lblRel2.Text = "Suppliers:";

            var data = await _unitOfWork.ProductsSuppliers.GetByIdAsync(id);

            if (data == null)
            {
                MessageBox.Show("Data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var products = await _unitOfWork.Products.GetAllAsync();
            var suppliers = await _unitOfWork.Suppliers.GetAllAsync();

            // Set the data sources
            cboRel1.DataSource = new BindingList<Product>(products.ToList());
            cboRel1.DisplayMember = "ProdName";
            cboRel1.ValueMember = "ProductId";

            cboRel2.DataSource = new BindingList<Supplier>(suppliers.ToList());
            cboRel2.DisplayMember = "SupName";
            cboRel2.ValueMember = "SupplierId";

            // Set the selected values
            cboRel1.SelectedValue = data.ProductId;
            cboRel2.SelectedValue = data.SupplierId;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_operationType == "Add")
                {
                    await AddProductSupplierAsync();
                }
                else if (_operationType == "Modify")
                {
                    await ModifyProductSupplierAsync();
                }

                MessageBox.Show("Operation completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }

        private async Task AddProductSupplierAsync()
        {
            var data = new ProductsSupplier
            {
                ProductId = (int)cboRel1.SelectedValue,
                SupplierId = (int)cboRel2.SelectedValue
            };

            await _unitOfWork.ProductsSuppliers.AddAsync(data);
            await _unitOfWork.CompleteAsync();
        }

        private async Task ModifyProductSupplierAsync()
        {
            var data = await _unitOfWork.ProductsSuppliers.GetByIdAsync(_id);

            if (data == null)
            {
                MessageBox.Show("Data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data.ProductId = (int)cboRel1.SelectedValue;
            data.SupplierId = (int)cboRel2.SelectedValue;

            await _unitOfWork.CompleteAsync();
        }

    }
}
