using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;

namespace Main.Forms
{
    public partial class SimpleEntryForm : Form
    {
        public string EntityName { get; set; }
        private ProductDTO product;
        private SupplierDTO supplier;
        private ProductsSupplierDTO productSupplier;

        public SimpleEntryForm(string entityName, ProductDTO product = null, SupplierDTO supplier = null, ProductsSupplierDTO productSupplier = null)
        {
            InitializeComponent();
            txtId.Enabled = false;
            EntityName = entityName;
            this.product = product;
            this.supplier = supplier;
            this.productSupplier = productSupplier;
            this.Text = $"Add/Modify {EntityName}";

            if (EntityName == "Product" && product != null)
            {
                txtId.Text = product.ProductId.ToString();
                txtName.Text = product.ProdName;
            }
            else if (EntityName == "Supplier" && supplier != null)
            {
                txtId.Text = supplier.SupplierId.ToString();
                txtName.Text = supplier.SupName;
            }
            else if (EntityName == "ProductSupplier" && productSupplier != null)
            {
                txtId.Text = productSupplier.ProductId.ToString();
                txtId.Text = productSupplier.SupplierId.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EntityName == "Product")
            {
                if (product == null) product = new ProductDTO();
                product.ProdName = txtName.Text;

                // Save or update product in database
                if (product.ProductId == 0)  // Assuming 0 means a new product
                {
                    DataCache.Instance.Products.Add(product);
                }
                else
                {
                    // Update logic here
                }
            }
            else if (EntityName == "Supplier")
            {
                if (supplier == null) supplier = new SupplierDTO();
                supplier.SupName = txtName.Text;

                // Save or update supplier in database
                if (supplier.SupplierId == 0)  // Assuming 0 means a new supplier
                {
                    DataCache.Instance.Suppliers.Add(supplier);
                }
                else
                {
                    // Update logic here
                }
            }
            else if (EntityName == "ProductSupplier")
            {
                if (productSupplier == null) productSupplier = new ProductsSupplierDTO();
                productSupplier.ProductId = int.Parse(txtId.Text);
                productSupplier.SupplierId = int.Parse(txtId.Text);

                // Save or update product supplier in database
                if (productSupplier.ProductSupplierId == 0)  // Assuming 0 means a new product supplier
                {
                    DataCache.Instance.ProductSuppliers.Add(productSupplier);
                }
                else
                {
                    // Update logic here
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
