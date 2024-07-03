namespace Main
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            viewPkg = new Button();
            viewProd = new Button();
            viewSup = new Button();
            viewProdSup = new Button();
            panel1 = new Panel();
            open = new Button();
            btnExit = new Button();
            btnRemove = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            btnSubmit = new Button();
            txtQuery = new TextBox();
            dgvView = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.Cyan;
            flowLayoutPanel1.Controls.Add(viewPkg);
            flowLayoutPanel1.Controls.Add(viewProd);
            flowLayoutPanel1.Controls.Add(viewSup);
            flowLayoutPanel1.Controls.Add(viewProdSup);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 904);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // viewPkg
            // 
            viewPkg.AutoSize = true;
            viewPkg.BackColor = Color.FromArgb(10, 155, 170);
            viewPkg.Dock = DockStyle.Fill;
            viewPkg.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewPkg.FlatAppearance.BorderSize = 0;
            viewPkg.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewPkg.FlatStyle = FlatStyle.Flat;
            viewPkg.ForeColor = SystemColors.Window;
            viewPkg.ImageAlign = ContentAlignment.MiddleLeft;
            viewPkg.Location = new Point(3, 3);
            viewPkg.Name = "viewPkg";
            viewPkg.Size = new Size(231, 37);
            viewPkg.TabIndex = 0;
            viewPkg.Text = "Packages";
            viewPkg.UseVisualStyleBackColor = false;
            viewPkg.Click += viewPkg_Click;
            // 
            // viewProd
            // 
            viewProd.AutoSize = true;
            viewProd.BackColor = Color.FromArgb(10, 155, 170);
            viewProd.Dock = DockStyle.Fill;
            viewProd.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewProd.FlatAppearance.BorderSize = 0;
            viewProd.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewProd.FlatStyle = FlatStyle.Flat;
            viewProd.ForeColor = SystemColors.Window;
            viewProd.ImageAlign = ContentAlignment.MiddleLeft;
            viewProd.Location = new Point(3, 46);
            viewProd.Name = "viewProd";
            viewProd.Size = new Size(231, 37);
            viewProd.TabIndex = 1;
            viewProd.Text = "Products";
            viewProd.UseVisualStyleBackColor = false;
            viewProd.Click += viewProd_Click;
            // 
            // viewSup
            // 
            viewSup.AutoSize = true;
            viewSup.BackColor = Color.FromArgb(10, 155, 170);
            viewSup.Dock = DockStyle.Fill;
            viewSup.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewSup.FlatAppearance.BorderSize = 0;
            viewSup.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewSup.FlatStyle = FlatStyle.Flat;
            viewSup.ForeColor = SystemColors.Window;
            viewSup.ImageAlign = ContentAlignment.MiddleLeft;
            viewSup.Location = new Point(3, 89);
            viewSup.Name = "viewSup";
            viewSup.Size = new Size(231, 37);
            viewSup.TabIndex = 2;
            viewSup.Text = "Suppliers";
            viewSup.UseVisualStyleBackColor = false;
            viewSup.Click += viewSup_Click;
            // 
            // viewProdSup
            // 
            viewProdSup.AutoSize = true;
            viewProdSup.BackColor = Color.FromArgb(10, 155, 170);
            viewProdSup.Dock = DockStyle.Fill;
            viewProdSup.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewProdSup.FlatAppearance.BorderSize = 0;
            viewProdSup.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewProdSup.FlatStyle = FlatStyle.Flat;
            viewProdSup.ForeColor = SystemColors.Window;
            viewProdSup.ImageAlign = ContentAlignment.MiddleLeft;
            viewProdSup.Location = new Point(3, 132);
            viewProdSup.Name = "viewProdSup";
            viewProdSup.Size = new Size(231, 37);
            viewProdSup.TabIndex = 3;
            viewProdSup.Text = "Product Suppliers";
            viewProdSup.UseVisualStyleBackColor = false;
            viewProdSup.Click += viewProdSup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(open);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtQuery);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(237, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 150);
            panel1.TabIndex = 1;
            // 
            // open
            // 
            open.Location = new Point(1122, 66);
            open.Name = "open";
            open.Size = new Size(112, 34);
            open.TabIndex = 6;
            open.Text = "Test";
            open.TextImageRelation = TextImageRelation.TextAboveImage;
            open.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(1403, 59);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(313, 59);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 34);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(172, 58);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(112, 34);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(850, 59);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(577, 59);
            txtQuery.Name = "txtQuery";
            txtQuery.PlaceholderText = "Search...";
            txtQuery.Size = new Size(248, 31);
            txtQuery.TabIndex = 0;
            // 
            // dgvView
            // 
            dgvView.AllowUserToAddRows = false;
            dgvView.AllowUserToDeleteRows = false;
            dgvView.AllowUserToResizeColumns = false;
            dgvView.AllowUserToResizeRows = false;
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView.Dock = DockStyle.Fill;
            dgvView.Location = new Point(237, 150);
            dgvView.Name = "dgvView";
            dgvView.RowHeadersWidth = 62;
            dgvView.Size = new Size(1527, 754);
            dgvView.TabIndex = 2;
            dgvView.CellClick += dgvView_CellClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1764, 904);
            Controls.Add(dgvView);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Main";
            Text = "Dashboard";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button viewPkg;
        private Button viewProd;
        private Button viewSup;
        private Button btnSubmit;
        private TextBox txtQuery;
        private DataGridView dgvView;
        private Button btnRemove;
        private Button btnModify;
        private Button btnAdd;
        private Button viewProdSup;
        private Button btnExit;
        private Button open;
    }
}
