using TravelExpertsData.Repository.IRepository;

namespace Main
{
    public partial class AddModifyPackages : Form
    {
        private readonly string _operationType;
        private readonly IUnitOfWork _unitOfWork;


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
                foreach (var item in prodSup)
                {
                    lsbProd.Items.Add(new ListBoxItem { Text = item.ProductName.ToString(), Value = item.ProductSupplierID });
                    lsbSup.Items.Add(new ListBoxItem { Text = item.SupplierName.ToString(), Value = item.ProductSupplierID });
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
    }
}
