using TravelExpertsData.Models;
using TravelExpertsData.Models.DTO;
using TravelExpertsData.Repository.IRepository;

namespace Main
{
    public partial class AddModifyPackages : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        // Operation type (Add or Modify)
        private readonly string _operationType;
        // Holds the current product supplier IDs for the package
        private List<int> _currentProductSupplierIds;

        public AddModifyPackages(string operationType, IUnitOfWork unitOfWork, int id = 0)
        {
            InitializeComponent();
            _operationType = operationType;
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));

            if (_unitOfWork == null)
            {
                MessageBox.Show("Unit of Work is not initialized.");
                return;
            }

            LoadData(id);

            if (_operationType == "Add")
            {
                this.Text = "Add Package";
            }
            else
            {
                this.Text = "Modify Package";
            }
        }

        private async void LoadData(int id)
        {
            if (_operationType == "Modify")
            {
                txtId.Enabled = false;
                var package = await _unitOfWork.Packages.GetByIdAsync(id);

                if (package != null)
                {
                    txtId.Text = package.PackageId.ToString();
                    txtPkgName.Text = package.PkgName;
                    dtpStartDate.Value = package.PkgStartDate;
                    dtpEndDate.Value = package.PkgEndDate;
                    txtDesc.Text = package.PkgDesc;
                    txtBasePrice.Text = package.PkgBasePrice.ToString();
                    txtAgencyComm.Text = package.PkgAgencyCommission.ToString();
                }


                var prodSup = await _unitOfWork.Packages.GetProdSupAsync(id);
                lsbProd.Items.Clear();
                lsbSup.Items.Clear();
                _currentProductSupplierIds = new List<int>();

                foreach (var item in prodSup)
                {
                    lsbProd.Items.Add(new ListBoxItem { Text = item.ProductName.ToString(), Value = item.ProductSupplierId });
                    lsbSup.Items.Add(new ListBoxItem { Text = item.SupplierName.ToString(), Value = item.ProductSupplierId });

                    _currentProductSupplierIds.Add(item.ProductSupplierId);
                }
            }
            else
            {
                var products = await _unitOfWork.Products.GetAllAsync();
                var suppliers = await _unitOfWork.Suppliers.GetAllAsync();

                lsbProd.Items.Clear();
                lsbSup.Items.Clear();

                foreach (var item in products)
                {
                    lsbProd.Items.Add(new ListBoxItem { Text = item.ProdName, Value = item.ProductId });
                }

                foreach (var item in suppliers)
                {
                    lsbSup.Items.Add(new ListBoxItem { Text = item.SupName, Value = item.SupplierId });
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public class ListBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void lsbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbProd.SelectedItem != null)
            {
                txtProd.Text = ((ListBoxItem)lsbProd.SelectedItem).Text;
            }
        }

        private void lsbSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSup.SelectedItem != null)
            {
                txtSup.Text = ((ListBoxItem)lsbSup.SelectedItem).Text;
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_operationType == "Add")
            {
                // Create a new package
                var package = new Package
                {
                    PkgName = txtPkgName.Text,
                    PkgStartDate = dtpStartDate.Value,
                    PkgEndDate = dtpEndDate.Value,
                    PkgDesc = txtDesc.Text,
                    PkgBasePrice = decimal.Parse(txtBasePrice.Text),
                    PkgAgencyCommission = decimal.Parse(txtAgencyComm.Text)
                };

                await _unitOfWork.Packages.AddAsync(package);
                await _unitOfWork.CompleteAsync();

                var selectedProductIds = lsbProd.Items.Cast<ListBoxItem>().Select(i => i.Value).ToList();
                var selectedSupplierIds = lsbSup.Items.Cast<ListBoxItem>().Select(i => i.Value).ToList();

                foreach (var productId in selectedProductIds)
                {
                    foreach (var supplierId in selectedSupplierIds)
                    {
                        var productSupplier = new ProductsSupplier
                        {
                            ProductId = productId,
                            SupplierId = supplierId
                        };

                        await _unitOfWork.ProductSuppliers.AddAsync(productSupplier);
                        await _unitOfWork.CompleteAsync();

                        // Create PackagesProductsSupplier association
                        var packagesProductsSupplier = new PackagesProductsSupplierDTO
                        {
                            PackageId = package.PackageId,
                            ProductSupplierId = productSupplier.ProductSupplierId
                        };

                        await _unitOfWork.PackagesProductsSuppliers.AddAsync(packagesProductsSupplier);
                    }
                }
            }
            else if (_operationType == "Modify")
            {
                // Update the existing package
                var package = await _unitOfWork.Packages.GetByIdAsync(int.Parse(txtId.Text));

                if (package != null)
                {
                    package.PkgName = txtPkgName.Text;
                    package.PkgStartDate = dtpStartDate.Value;
                    package.PkgEndDate = dtpEndDate.Value;
                    package.PkgDesc = txtDesc.Text;
                    package.PkgBasePrice = decimal.Parse(txtBasePrice.Text);
                    package.PkgAgencyCommission = decimal.Parse(txtAgencyComm.Text);

                    await _unitOfWork.Packages.UpdateAsync(package);
                    await _unitOfWork.CompleteAsync();

                    // Update associations
                    var newProductSupplierIds = lsbProd.Items.Cast<ListBoxItem>().Select(i => i.Value).ToList();
                    await _unitOfWork.Packages.UpdateRelations(package.PackageId, newProductSupplierIds);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
