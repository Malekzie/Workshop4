using Main.Forms;
using TravelExpertsData.Models;
using TravelExpertsData.DataAccess;
using System.Windows.Forms;

namespace Main.Services
{
    public class AddModifyService
    {
        public void HandleAdd(string entityType)
        {
            if (entityType == "Package")
            {
                OpenAddModifyPackagesForm(null, "Add Package");
            }
            else if (entityType == "Product")
            {
                OpenSimpleEntryForm("Product");
            }
            else if (entityType == "Supplier")
            {
                OpenSimpleEntryForm("Supplier");
            }
            else if (entityType == "ProductSupplier")
            {
                OpenSimpleEntryForm("ProductSupplier");
            }
            else
            {
                MessageBox.Show("Invalid entity type for adding.");
            }
        }

        public void HandleModify(object selectedItem)
        {
            if (selectedItem is PackageDTO selectedPackage)
            {
                OpenAddModifyPackagesForm(selectedPackage, "Modify Package");
            }
            else if (selectedItem is ProductDTO selectedProduct)
            {
                OpenSimpleEntryForm("Product", selectedProduct);
            }
            else if (selectedItem is SupplierDTO selectedSupplier)
            {
                OpenSimpleEntryForm("Supplier", selectedSupplier);
            }
            else if (selectedItem is ProductsSupplierDTO selectedProductSupplier)
            {
                OpenSimpleEntryForm("ProductSupplier", selectedProductSupplier);
            }
            else if (selectedItem is SearchResult searchResult)
            {
                if (searchResult.Type == "Package")
                {
                    var package = (PackageDTO)searchResult.Data;
                    OpenAddModifyPackagesForm(package, "Modify Package");
                }
                else if (searchResult.Type == "Product")
                {
                    var product = (ProductDTO)searchResult.Data;
                    OpenSimpleEntryForm("Product", product);
                }
                else if (searchResult.Type == "Supplier")
                {
                    var supplier = (SupplierDTO)searchResult.Data;
                    OpenSimpleEntryForm("Supplier", supplier);
                }
                else if (searchResult.Type == "ProductSupplier")
                {
                    var productSupplier = (ProductsSupplierDTO)searchResult.Data;
                    OpenSimpleEntryForm("ProductSupplier", productSupplier);
                }
            }
            else
            {
                MessageBox.Show("Selected item is not a valid entry.");
            }
        }

        private void OpenSimpleEntryForm(string entityType, object entity = null)
        {
            using (var form = new SimpleEntryForm(entityType, entity as ProductDTO, entity as SupplierDTO, entity as ProductsSupplierDTO))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Handle post-save actions if necessary
                }
            }
        }

        private void OpenAddModifyPackagesForm(PackageDTO package = null, string formTitle = "Add Package")
        {
            using (var form = new AddModifyPackages(package))
            {
                form.Text = formTitle;
                form.ShowDialog();
            }
        }
    }
}
