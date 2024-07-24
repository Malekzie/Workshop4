namespace Main.Forms
{
    partial class SimpleEntryForm
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
            lbld = new Label();
            txtId = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbld
            // 
            lbld.AutoSize = true;
            lbld.Location = new Point(15, 46);
            lbld.Name = "lbld";
            lbld.Size = new Size(66, 15);
            lbld.TabIndex = 0;
            lbld.Text = "Product ID:";
            // 
            // txtId
            // 
            txtId.ForeColor = SystemColors.Desktop;
            txtId.Location = new Point(101, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 75);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.Desktop;
            txtName.Location = new Point(101, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 23);
            txtName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(219, 34, 42);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.HighlightText;
            btnSave.Location = new Point(94, 126);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(219, 34, 42);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.HighlightText;
            btnClose.Location = new Point(175, 126);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // SimpleEntryForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 53);
            ClientSize = new Size(309, 170);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(lbld);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SimpleEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductSupplierForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbld;
        private TextBox txtId;
        private Label label1;
        private TextBox txtName;
        private Button btnSave;
        private Button btnClose;
    }
}