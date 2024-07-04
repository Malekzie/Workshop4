namespace Main
{
    partial class AddModifyPackages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            grbID = new GroupBox();
            txtPkgName = new TextBox();
            label3 = new Label();
            dtpkStartDate = new DateTimePicker();
            dtpkEndDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtPkgDescription = new TextBox();
            label6 = new Label();
            txtbxBasePrice = new TextBox();
            label7 = new Label();
            txtbxAgencyCommision = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            btnSelectProduct = new Button();
            cklbProductList = new CheckedListBox();
            cklbSelectedProducts = new CheckedListBox();
            btnRemoveProduct = new Button();
            label8 = new Label();
            grbID.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Package Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Product List";
            // 
            // grbID
            // 
            grbID.Controls.Add(label8);
            grbID.Controls.Add(btnRemoveProduct);
            grbID.Controls.Add(label2);
            grbID.Controls.Add(cklbSelectedProducts);
            grbID.Controls.Add(cklbProductList);
            grbID.Controls.Add(btnSelectProduct);
            grbID.Location = new Point(29, 262);
            grbID.Margin = new Padding(2);
            grbID.Name = "grbID";
            grbID.Padding = new Padding(2);
            grbID.Size = new Size(582, 283);
            grbID.TabIndex = 2;
            grbID.TabStop = false;
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(153, 35);
            txtPkgName.Margin = new Padding(2);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(226, 27);
            txtPkgName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Start Date:";
            // 
            // dtpkStartDate
            // 
            dtpkStartDate.Format = DateTimePickerFormat.Short;
            dtpkStartDate.Location = new Point(153, 65);
            dtpkStartDate.Margin = new Padding(2);
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(112, 27);
            dtpkStartDate.TabIndex = 5;
            // 
            // dtpkEndDate
            // 
            dtpkEndDate.Format = DateTimePickerFormat.Short;
            dtpkEndDate.Location = new Point(442, 63);
            dtpkEndDate.Margin = new Padding(2);
            dtpkEndDate.Name = "dtpkEndDate";
            dtpkEndDate.Size = new Size(113, 27);
            dtpkEndDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 7;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 132);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Description:";
            // 
            // txtPkgDescription
            // 
            txtPkgDescription.Location = new Point(153, 132);
            txtPkgDescription.Margin = new Padding(2);
            txtPkgDescription.Multiline = true;
            txtPkgDescription.Name = "txtPkgDescription";
            txtPkgDescription.Size = new Size(458, 117);
            txtPkgDescription.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 99);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 10;
            label6.Text = "Base Price:";
            // 
            // txtbxBasePrice
            // 
            txtbxBasePrice.Location = new Point(153, 94);
            txtbxBasePrice.Margin = new Padding(2);
            txtbxBasePrice.Name = "txtbxBasePrice";
            txtbxBasePrice.Size = new Size(112, 27);
            txtbxBasePrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 99);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 12;
            label7.Text = "Agency Commision:";
            // 
            // txtbxAgencyCommision
            // 
            txtbxAgencyCommision.Location = new Point(442, 92);
            txtbxAgencyCommision.Margin = new Padding(2);
            txtbxAgencyCommision.Name = "txtbxAgencyCommision";
            txtbxAgencyCommision.Size = new Size(113, 27);
            txtbxAgencyCommision.TabIndex = 13;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(153, 549);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 27);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(442, 549);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelectProduct
            // 
            btnSelectProduct.Location = new Point(57, 236);
            btnSelectProduct.Name = "btnSelectProduct";
            btnSelectProduct.Size = new Size(138, 29);
            btnSelectProduct.TabIndex = 2;
            btnSelectProduct.Text = "Select Product";
            btnSelectProduct.UseVisualStyleBackColor = true;
            // 
            // cklbProductList
            // 
            cklbProductList.FormattingEnabled = true;
            cklbProductList.Items.AddRange(new object[] { "thing", "thing2", "thing3", "thing4", "thing5", "thing6", "thing7", "thing8", "thing9", "thing10", "thing11", "thing12" });
            cklbProductList.Location = new Point(16, 50);
            cklbProductList.Name = "cklbProductList";
            cklbProductList.Size = new Size(262, 180);
            cklbProductList.TabIndex = 3;
            // 
            // cklbSelectedProducts
            // 
            cklbSelectedProducts.FormattingEnabled = true;
            cklbSelectedProducts.Items.AddRange(new object[] { "thing2", "thing4" });
            cklbSelectedProducts.Location = new Point(303, 50);
            cklbSelectedProducts.Name = "cklbSelectedProducts";
            cklbSelectedProducts.Size = new Size(258, 180);
            cklbSelectedProducts.TabIndex = 4;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Location = new Point(365, 236);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(138, 29);
            btnRemoveProduct.TabIndex = 5;
            btnRemoveProduct.Text = "Remove Product";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 22);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 6;
            label8.Text = "Selected Products";
            // 
            // AddModifyPackages
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(690, 587);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtbxAgencyCommision);
            Controls.Add(label7);
            Controls.Add(txtbxBasePrice);
            Controls.Add(label6);
            Controls.Add(txtPkgDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpkEndDate);
            Controls.Add(dtpkStartDate);
            Controls.Add(label3);
            Controls.Add(txtPkgName);
            Controls.Add(grbID);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddModifyPackages";
            Text = "AddModifyPackage";
            grbID.ResumeLayout(false);
            grbID.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox grbID;
        private TextBox txtPkgName;
        private Label label3;
        private DateTimePicker dtpkStartDate;
        private DateTimePicker dtpkEndDate;
        private Label label4;
        private Label label5;
        private TextBox txtPkgDescription;
        private Label label6;
        private TextBox txtbxBasePrice;
        private Label label7;
        private TextBox txtbxAgencyCommision;
        private Button btnConfirm;
        private Button btnCancel;
        private CheckedListBox cklbProductList;
        private Button btnSelectProduct;
        private Button btnRemoveProduct;
        private CheckedListBox cklbSelectedProducts;
        private Label label8;
    }
}