using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData.DataAccess;
using TravelExpertsData.Models;

namespace Main
{
    public partial class AddModifyPackages : Form
    {
        private PackageDTO package;

        public AddModifyPackages(PackageDTO package = null)
        {



            InitializeComponent();
            this.package = package;
            txtPkgId.Enabled = false;
            if (package == null)
            {
                txtPkgId.Text = "New Package";
                txtPkgId.Width= 100;
                txtPkgId.Enabled = false;
                dgvRelatedProducts.Visible = false;
                dgvRelatedSuppliers.Visible = false;
            }
            else
            {
                LoadPackageData();
                LoadRelatedProducts(package.PackageId);
                LoadRelatedSuppliers(package.PackageId);
            }


        }

        private void txtDes_DoubleClick(object sender, EventArgs e)
        {
            string currentDescription = txtDes.Text;
            DescriptionForm editorForm = new DescriptionForm(currentDescription);

            if (editorForm.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the updated description from the TinyMCEForm
                txtDes.Text = editorForm.GetContent();
            }
        }

        private void LoadPackageData()
        {
            // Assuming you have TextBoxes for package details
            txtPkgName.Text = package.PkgName;
            dtpStartDate.Value = package.PkgStartDate ?? DateTime.Now;
            dtpEndDate.Value = package.PkgEndDate ?? DateTime.Now;
            txtDes.Text = package.PkgDesc;
            txtBasePrice.Text = package.PkgBasePrice.ToString();
            txtAgentCommision.Text = package.PkgAgencyCommission.ToString();
            txtPkgId.Text = package.PackageId.ToString();
        }

        private void LoadRelatedProducts(int packageId)
        {
            var relatedProducts = (from pps in DataCache.Instance.PackageProductSuppliers
                                   join ps in DataCache.Instance.ProductSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                                   join p in DataCache.Instance.Products on ps.ProductId equals p.ProductId
                                   where pps.PackageId == packageId
                                   select new
                                   {
                                       p.ProductId,
                                       p.ProdName
                                   }).ToList();

            dgvRelatedProducts.DataSource = relatedProducts;
        }

        private void LoadRelatedSuppliers(int packageId)
        {
            var relatedSuppliers = (from pps in DataCache.Instance.PackageProductSuppliers
                                    join ps in DataCache.Instance.ProductSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                                    join s in DataCache.Instance.Suppliers on ps.SupplierId equals s.SupplierId
                                    where pps.PackageId == packageId
                                    select new
                                    {
                                        s.SupplierId,
                                        s.SupName
                                    }).ToList();

            dgvRelatedSuppliers.DataSource = relatedSuppliers;
        }
    }
}
 