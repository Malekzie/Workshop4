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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtPkgId = new TextBox();
            label2 = new Label();
            txtPkgName = new TextBox();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            label4 = new Label();
            dtpEndDate = new DateTimePicker();
            label5 = new Label();
            txtBasePrice = new TextBox();
            label6 = new Label();
            txtAgentCommision = new TextBox();
            panel1 = new Panel();
            packageId = new Panel();
            txtDes = new TextBox();
            label7 = new Label();
            dgvRelatedProducts = new DataGridView();
            dgvRelatedSuppliers = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            btnSubmit = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            packageId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatedProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatedSuppliers).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Package ID:";
            // 
            // txtPkgId
            // 
            txtPkgId.Location = new Point(128, 69);
            txtPkgId.Margin = new Padding(4, 5, 4, 5);
            txtPkgId.Name = "txtPkgId";
            txtPkgId.Size = new Size(73, 31);
            txtPkgId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(23, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 3;
            label2.Text = "Package Name:";
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(223, 193);
            txtPkgName.Margin = new Padding(4, 5, 4, 5);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(243, 31);
            txtPkgName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(23, 303);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 5;
            label3.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(223, 290);
            dtpStartDate.Margin = new Padding(4, 5, 4, 5);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(158, 31);
            dtpStartDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(23, 352);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(223, 338);
            dtpEndDate.Margin = new Padding(4, 5, 4, 5);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(158, 31);
            dtpEndDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(23, 400);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 9;
            label5.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(223, 387);
            txtBasePrice.Margin = new Padding(4, 5, 4, 5);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(243, 31);
            txtBasePrice.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(23, 448);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 11;
            label6.Text = "Agent Commision:";
            // 
            // txtAgentCommision
            // 
            txtAgentCommision.Location = new Point(223, 435);
            txtAgentCommision.Margin = new Padding(4, 5, 4, 5);
            txtAgentCommision.Name = "txtAgentCommision";
            txtAgentCommision.Size = new Size(243, 31);
            txtAgentCommision.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(packageId);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 164);
            panel1.TabIndex = 14;
            // 
            // packageId
            // 
            packageId.Controls.Add(label1);
            packageId.Controls.Add(txtPkgId);
            packageId.Dock = DockStyle.Left;
            packageId.Location = new Point(0, 0);
            packageId.Margin = new Padding(4, 5, 4, 5);
            packageId.Name = "packageId";
            packageId.Size = new Size(310, 160);
            packageId.TabIndex = 0;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(223, 242);
            txtDes.Margin = new Padding(4, 5, 4, 5);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(243, 31);
            txtDes.TabIndex = 16;
            txtDes.DoubleClick += txtDes_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(23, 255);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 15;
            label7.Text = "Description:";
            // 
            // dgvRelatedProducts
            // 
            dgvRelatedProducts.AllowUserToAddRows = false;
            dgvRelatedProducts.AllowUserToDeleteRows = false;
            dgvRelatedProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatedProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRelatedProducts.BackgroundColor = Color.FromArgb(31, 34, 53);
            dgvRelatedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRelatedProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatedProducts.Location = new Point(22, 60);
            dgvRelatedProducts.Margin = new Padding(4, 5, 4, 5);
            dgvRelatedProducts.Name = "dgvRelatedProducts";
            dgvRelatedProducts.ReadOnly = true;
            dgvRelatedProducts.RowHeadersWidth = 62;
            dgvRelatedProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatedProducts.Size = new Size(354, 432);
            dgvRelatedProducts.TabIndex = 17;
            // 
            // dgvRelatedSuppliers
            // 
            dgvRelatedSuppliers.AllowUserToAddRows = false;
            dgvRelatedSuppliers.AllowUserToDeleteRows = false;
            dgvRelatedSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatedSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRelatedSuppliers.BackgroundColor = Color.FromArgb(31, 34, 53);
            dgvRelatedSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRelatedSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRelatedSuppliers.Location = new Point(385, 60);
            dgvRelatedSuppliers.Margin = new Padding(4, 5, 4, 5);
            dgvRelatedSuppliers.Name = "dgvRelatedSuppliers";
            dgvRelatedSuppliers.ReadOnly = true;
            dgvRelatedSuppliers.RowHeadersWidth = 62;
            dgvRelatedSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatedSuppliers.Size = new Size(354, 432);
            dgvRelatedSuppliers.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(127, 1);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(159, 48);
            label8.TabIndex = 19;
            label8.Text = "Products";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(479, 1);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 48);
            label9.TabIndex = 20;
            label9.Text = "Suppliers";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(219, 34, 42);
            btnSubmit.ForeColor = SystemColors.ControlLightLight;
            btnSubmit.Location = new Point(23, 635);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 38);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(219, 34, 42);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(179, 635);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 38);
            btnClose.TabIndex = 22;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dgvRelatedSuppliers);
            panel2.Controls.Add(dgvRelatedProducts);
            panel2.Location = new Point(614, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 514);
            panel2.TabIndex = 23;
            // 
            // AddModifyPackages
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 53);
            CancelButton = btnClose;
            ClientSize = new Size(1370, 697);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(txtDes);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(txtAgentCommision);
            Controls.Add(label6);
            Controls.Add(txtBasePrice);
            Controls.Add(label5);
            Controls.Add(dtpEndDate);
            Controls.Add(label4);
            Controls.Add(dtpStartDate);
            Controls.Add(label3);
            Controls.Add(txtPkgName);
            Controls.Add(label2);
            Controls.Add(panel2);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddModifyPackages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddModifyPackage";
            panel1.ResumeLayout(false);
            packageId.ResumeLayout(false);
            packageId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatedProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRelatedSuppliers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPkgId;
        private Label label2;
        private TextBox txtPkgName;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private Label label4;
        private DateTimePicker dtpEndDate;
        private Label label5;
        private TextBox txtBasePrice;
        private Label label6;
        private TextBox txtAgentCommision;
        private Panel panel1;
        private Panel packageId;
        private TextBox txtDes;
        private Label label7;
        private DataGridView dgvRelatedProducts;
        private DataGridView dgvRelatedSuppliers;
        private Label label8;
        private Label label9;
        private Button btnSubmit;
        private Button btnClose;
        private Panel panel2;
    }
}