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
            flowLayoutPanel1.BackColor = Color.FromArgb(31, 34, 53);
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(viewPkg);
            flowLayoutPanel1.Controls.Add(viewProd);
            flowLayoutPanel1.Controls.Add(viewSup);
            flowLayoutPanel1.Controls.Add(viewProdSup);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(239, 903);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // viewPkg
            // 
            viewPkg.AutoSize = true;
            viewPkg.BackColor = Color.FromArgb(31, 122, 140);
            viewPkg.Dock = DockStyle.Fill;
            viewPkg.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewPkg.FlatAppearance.BorderSize = 0;
            viewPkg.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewPkg.FlatStyle = FlatStyle.Flat;
            viewPkg.ForeColor = SystemColors.Window;
            viewPkg.ImageAlign = ContentAlignment.MiddleLeft;
            viewPkg.Location = new Point(3, 3);
            viewPkg.Name = "viewPkg";
            viewPkg.Size = new Size(231, 58);
            viewPkg.TabIndex = 0;
            viewPkg.Text = "Packages";
            viewPkg.UseVisualStyleBackColor = false;
            viewPkg.Click += viewPkg_Click;
            // 
            // viewProd
            // 
            viewProd.AutoSize = true;
            viewProd.BackColor = Color.FromArgb(31, 122, 140);
            viewProd.Dock = DockStyle.Fill;
            viewProd.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewProd.FlatAppearance.BorderSize = 0;
            viewProd.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewProd.FlatStyle = FlatStyle.Flat;
            viewProd.ForeColor = SystemColors.Window;
            viewProd.ImageAlign = ContentAlignment.MiddleLeft;
            viewProd.Location = new Point(3, 67);
            viewProd.Name = "viewProd";
            viewProd.Size = new Size(231, 58);
            viewProd.TabIndex = 1;
            viewProd.Text = "Products";
            viewProd.UseVisualStyleBackColor = false;
            viewProd.Click += viewProd_Click;
            // 
            // viewSup
            // 
            viewSup.AutoSize = true;
            viewSup.BackColor = Color.FromArgb(31, 122, 140);
            viewSup.Dock = DockStyle.Fill;
            viewSup.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewSup.FlatAppearance.BorderSize = 0;
            viewSup.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewSup.FlatStyle = FlatStyle.Flat;
            viewSup.ForeColor = SystemColors.Window;
            viewSup.ImageAlign = ContentAlignment.MiddleLeft;
            viewSup.Location = new Point(3, 131);
            viewSup.Name = "viewSup";
            viewSup.Size = new Size(231, 58);
            viewSup.TabIndex = 2;
            viewSup.Text = "Suppliers";
            viewSup.UseVisualStyleBackColor = false;
            viewSup.Click += viewSup_Click;
            // 
            // viewProdSup
            // 
            viewProdSup.AutoSize = true;
            viewProdSup.BackColor = Color.FromArgb(31, 122, 140);
            viewProdSup.Dock = DockStyle.Fill;
            viewProdSup.FlatAppearance.BorderColor = Color.FromArgb(41, 53, 65);
            viewProdSup.FlatAppearance.BorderSize = 0;
            viewProdSup.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 237, 183);
            viewProdSup.FlatStyle = FlatStyle.Flat;
            viewProdSup.ForeColor = SystemColors.Window;
            viewProdSup.ImageAlign = ContentAlignment.MiddleLeft;
            viewProdSup.Location = new Point(3, 195);
            viewProdSup.Name = "viewProdSup";
            viewProdSup.Size = new Size(231, 58);
            viewProdSup.TabIndex = 3;
            viewProdSup.Text = "Product Suppliers";
            viewProdSup.UseVisualStyleBackColor = false;
            viewProdSup.Click += viewProdSup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 34, 53);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(open);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtQuery);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(239, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1525, 150);
            panel1.TabIndex = 1;
            // 
            // open
            // 
            open.BackColor = Color.FromArgb(219, 34, 42);
            open.BackgroundImageLayout = ImageLayout.Center;
            open.ForeColor = SystemColors.ControlLight;
            open.Location = new Point(1106, 63);
            open.Name = "open";
            open.Size = new Size(111, 33);
            open.TabIndex = 6;
            open.Text = "Test";
            open.TextImageRelation = TextImageRelation.TextAboveImage;
            open.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(219, 34, 42);
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.ForeColor = SystemColors.ControlLight;
            btnExit.Location = new Point(1399, 58);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(219, 34, 42);
            btnRemove.BackgroundImageLayout = ImageLayout.Center;
            btnRemove.ForeColor = SystemColors.ControlLight;
            btnRemove.Location = new Point(313, 58);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(117, 38);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(219, 34, 42);
            btnModify.BackgroundImageLayout = ImageLayout.Center;
            btnModify.ForeColor = SystemColors.ControlLight;
            btnModify.Location = new Point(171, 58);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(113, 38);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(219, 34, 42);
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.ForeColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(31, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(219, 34, 42);
            btnSubmit.BackgroundImageLayout = ImageLayout.Center;
            btnSubmit.ForeColor = SystemColors.ControlLight;
            btnSubmit.Location = new Point(850, 58);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(111, 33);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtQuery
            // 
            txtQuery.BackColor = Color.FromArgb(31, 34, 53);
            txtQuery.ForeColor = SystemColors.Window;
            txtQuery.Location = new Point(577, 58);
            txtQuery.Name = "txtQuery";
            txtQuery.PlaceholderText = "Search...";
            txtQuery.Size = new Size(248, 31);
            txtQuery.TabIndex = 0;
            txtQuery.TextChanged += txtQuery_TextChanged;
            // 
            // dgvView
            // 
            dgvView.AllowUserToAddRows = false;
            dgvView.AllowUserToDeleteRows = false;
            dgvView.AllowUserToResizeColumns = false;
            dgvView.AllowUserToResizeRows = false;
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView.BackgroundColor = Color.FromArgb(31, 34, 53);
            dgvView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView.Dock = DockStyle.Fill;
            dgvView.GridColor = Color.FromArgb(31, 34, 53);
            dgvView.Location = new Point(239, 150);
            dgvView.MultiSelect = false;
            dgvView.Name = "dgvView";
            dgvView.RowHeadersWidth = 62;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Size = new Size(1525, 753);
            dgvView.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1764, 903);
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
