﻿namespace Main
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
            btnExit = new Button();
            btnRemove = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            dgvView = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(32, 22, 31);
            flowLayoutPanel1.Controls.Add(viewPkg);
            flowLayoutPanel1.Controls.Add(viewProd);
            flowLayoutPanel1.Controls.Add(viewSup);
            flowLayoutPanel1.Controls.Add(viewProdSup);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 850);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // viewPkg
            // 
            viewPkg.AutoSize = true;
            viewPkg.BackColor = Color.FromArgb(197, 159, 96);
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
            viewPkg.TabIndex = 4;
            viewPkg.Text = "Packages";
            viewPkg.UseVisualStyleBackColor = false;
            viewPkg.Click += viewPkg_Click;
            // 
            // viewProd
            // 
            viewProd.AutoSize = true;
            viewProd.BackColor = Color.FromArgb(197, 159, 96);
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
            viewProd.TabIndex = 5;
            viewProd.Text = "Products";
            viewProd.UseVisualStyleBackColor = false;
            viewProd.Click += viewProd_Click;
            // 
            // viewSup
            // 
            viewSup.AutoSize = true;
            viewSup.BackColor = Color.FromArgb(197, 159, 96);
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
            viewSup.TabIndex = 6;
            viewSup.Text = "Suppliers";
            viewSup.UseVisualStyleBackColor = false;
            viewSup.Click += viewSup_Click;
            // 
            // viewProdSup
            // 
            viewProdSup.AutoSize = true;
            viewProdSup.BackColor = Color.FromArgb(197, 159, 96);
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
            viewProdSup.TabIndex = 7;
            viewProdSup.Text = "Product Suppliers";
            viewProdSup.UseVisualStyleBackColor = false;
            viewProdSup.Click += viewProdSup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 22, 31);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(237, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1519, 150);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1396, 57);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 38);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(306, 58);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(116, 38);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(167, 58);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(116, 38);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvView
            // 
            dgvView.AllowUserToAddRows = false;
            dgvView.AllowUserToDeleteRows = false;
            dgvView.AllowUserToResizeColumns = false;
            dgvView.AllowUserToResizeRows = false;
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvView.BackgroundColor = Color.FromArgb(32, 22, 31);
            dgvView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView.Dock = DockStyle.Fill;
            dgvView.Location = new Point(237, 150);
            dgvView.Name = "dgvView";
            dgvView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Size = new Size(1519, 700);
            dgvView.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1756, 850);
            Controls.Add(dgvView);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Main";
            Text = "Dashboard";
            Load += Main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private DataGridView dgvView;
        private Button btnModify;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnExit;
        private Button viewPkg;
        private Button viewProd;
        private Button viewSup;
        private Button viewProdSup;
    }
}
