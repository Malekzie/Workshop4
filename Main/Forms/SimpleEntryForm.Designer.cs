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
            lbld.Location = new Point(21, 77);
            lbld.Margin = new Padding(4, 0, 4, 0);
            lbld.Name = "lbld";
            lbld.Size = new Size(101, 25);
            lbld.TabIndex = 0;
            lbld.Text = "Product ID:";
            // 
            // txtId
            // 
            txtId.ForeColor = SystemColors.Desktop;
            txtId.Location = new Point(144, 63);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 31);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.Desktop;
            txtName.Location = new Point(144, 112);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 31);
            txtName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(219, 34, 42);
            btnSave.ForeColor = SystemColors.HighlightText;
            btnSave.Location = new Point(135, 210);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(219, 34, 42);
            btnClose.ForeColor = SystemColors.HighlightText;
            btnClose.Location = new Point(250, 210);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // SimpleEntryForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 53);
            CancelButton = btnClose;
            ClientSize = new Size(441, 283);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(lbld);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
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