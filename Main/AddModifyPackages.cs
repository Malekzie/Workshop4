using TravelExpertsData.Models;
using TravelExpertsData.Models.DTO;
using TravelExpertsData.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class AddModifyPackages : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _operationType;
        private List<int> _currentProductSupplierIds;

        public AddModifyPackages(string operationType, IUnitOfWork unitOfWork, int id = 0)
        {
            InitializeComponent();
            _operationType = operationType;
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));

            LoadData(id);

            this.Text = _operationType == "Add" ? "Add Package" : "Modify Package";
        }

        private async void LoadData(int id)
        {
            if (_operationType == "Modify")
            {
                await LoadExistingPackageData(id);
            }
            else
            {
                await LoadNewPackageData();
                // Autofill txtId with the next packageId
                var nextPackageId = await _unitOfWork.Packages.GetNextPackageIdAsync();
                txtId.Text = nextPackageId.ToString();
            }
        }

        private async Task LoadExistingPackageData(int id)
        {
            txtId.Enabled = false;
            var package = await _unitOfWork.Packages.GetByIdAsync(id);

            if (package != null)
            {
                PopulatePackageFields(package);
                await PopulateProductSupplierLists(id);
            }
        }

        private void PopulatePackageFields(Package package)
        {
            txtId.Text = package.PackageId.ToString();
            txtPkgName.Text = package.PkgName;
            dtpStartDate.Value = package.PkgStartDate;
            dtpEndDate.Value = package.PkgEndDate;
            txtDesc.Text = package.PkgDesc;
            txtBasePrice.Text = package.PkgBasePrice.ToString();
            txtAgencyComm.Text = package.PkgAgencyCommission.ToString();
        }

        private async Task PopulateProductSupplierLists(int packageId)
        {
            var prodSup = await _unitOfWork.Packages.GetProdSupAsync(packageId);
            lsbProd.Items.Clear();
            lsbSup.Items.Clear();
            _currentProductSupplierIds = new List<int>();

            foreach (var item in prodSup)
            {
                lsbProd.Items.Add(new ListBoxItem { Text = item.ProductName, Value = item.ProductSupplierId });
                lsbSup.Items.Add(new ListBoxItem { Text = item.SupplierName, Value = item.ProductSupplierId });
                _currentProductSupplierIds.Add(item.ProductSupplierId);
            }
        }

        private async Task LoadNewPackageData()
        {
            var products = await _unitOfWork.Products.GetAllProductsAsync();
            var suppliers = await _unitOfWork.Suppliers.GetAllSuppliersAsync();

            lsbProd.Items.Clear();
            lsbSup.Items.Clear();

            foreach (var product in products)
            {
                lsbProd.Items.Add(new ListBoxItem { Text = product.ProdName, Value = product.ProductId });
            }

            foreach (var supplier in suppliers)
            {
                lsbSup.Items.Add(new ListBoxItem { Text = supplier.SupName, Value = supplier.SupplierId });
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
                await AddNewPackage();
            }
            else if (_operationType == "Modify")
            {
                await ModifyExistingPackage();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async Task AddNewPackage()
        {
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

            await AddPackageProductSuppliers(package.PackageId);
        }

        private async Task AddPackageProductSuppliers(int packageId)
        {
            var selectedProductItems = lsbProd.SelectedItems.Cast<ListBoxItem>().ToList();
            var selectedSupplierItems = lsbSup.SelectedItems.Cast<ListBoxItem>().ToList();

            if (selectedProductItems.Count == 0 || selectedSupplierItems.Count == 0)
            {
                MessageBox.Show("Please select at least one product and one supplier.");
                return;
            }

            foreach (var productItem in selectedProductItems)
            {
                foreach (var supplierItem in selectedSupplierItems)
                {
                    var productId = productItem.Value;
                    var supplierId = supplierItem.Value;

                    var productSupplier = await _unitOfWork.ProductsSuppliers.AddOrGetAsync(productId, supplierId);
                    await _unitOfWork.PackagesProductsSuppliers.AddPackagesProductsSupplierAsync(packageId, productSupplier.ProductSupplierId);
                }
            }
        }

        private async Task ModifyExistingPackage()
        {
            var package = await _unitOfWork.Packages.GetByIdAsync(int.Parse(txtId.Text));

            if (package != null)
            {
                UpdatePackageFields(package);

                await _unitOfWork.Packages.UpdateAsync(package);
                await _unitOfWork.CompleteAsync();

                var newProductSupplierIds = lsbProd.Items.Cast<ListBoxItem>().Select(i => i.Value).ToList();
                await _unitOfWork.Packages.UpdateRelations(package.PackageId, newProductSupplierIds);
            }
        }

        private void UpdatePackageFields(Package package)
        {
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = dtpStartDate.Value;
            package.PkgEndDate = dtpEndDate.Value;
            package.PkgDesc = txtDesc.Text;
            package.PkgBasePrice = decimal.Parse(txtBasePrice.Text);
            package.PkgAgencyCommission = decimal.Parse(txtAgencyComm.Text);
        }
    }
}
