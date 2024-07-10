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

            if (package == null)
            {
                txtPkgId.Text = "New Package";
                txtPkgId.Width= 100;
                txtPkgId.Enabled = false;
            }
            else
            {
                LoadPackageData();
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
        }
    }
}
 