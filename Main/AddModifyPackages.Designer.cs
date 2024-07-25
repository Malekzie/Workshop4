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
            txtId = new TextBox();
            txtPkgName = new TextBox();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtDesc = new TextBox();
            label6 = new Label();
            txtBasePrice = new TextBox();
            label7 = new Label();
            txtAgencyComm = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 56);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Package Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 18);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.ForeColor = SystemColors.Desktop;
            txtId.Location = new Point(132, 10);
            txtId.Margin = new Padding(1);
            txtId.Name = "txtId";
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtPkgName
            // 
            txtPkgName.BackColor = Color.FromArgb(197, 159, 96);
            txtPkgName.ForeColor = SystemColors.Desktop;
            txtPkgName.Location = new Point(132, 48);
            txtPkgName.Margin = new Padding(1);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(148, 23);
            txtPkgName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 82);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarMonthBackground = Color.FromArgb(197, 159, 96);
            dtpStartDate.CalendarTrailingForeColor = Color.FromArgb(197, 159, 96);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(132, 74);
            dtpStartDate.Margin = new Padding(1);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(98, 23);
            dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarMonthBackground = Color.FromArgb(197, 159, 96);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(435, 48);
            dtpEndDate.Margin = new Padding(1);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(99, 23);
            dtpEndDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 56);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 130);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Description:";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.FromArgb(197, 159, 96);
            txtDesc.ForeColor = SystemColors.Desktop;
            txtDesc.Location = new Point(132, 130);
            txtDesc.Margin = new Padding(1);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(402, 94);
            txtDesc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 105);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            txtBasePrice.BackColor = Color.FromArgb(197, 159, 96);
            txtBasePrice.ForeColor = SystemColors.Desktop;
            txtBasePrice.Location = new Point(132, 100);
            txtBasePrice.Margin = new Padding(1);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(98, 23);
            txtBasePrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(294, 84);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 12;
            label7.Text = "Agency Commision:";
            // 
            // txtAgencyComm
            // 
            txtAgencyComm.BackColor = Color.FromArgb(197, 159, 96);
            txtAgencyComm.ForeColor = SystemColors.Desktop;
            txtAgencyComm.Location = new Point(437, 76);
            txtAgencyComm.Margin = new Padding(1);
            txtAgencyComm.Name = "txtAgencyComm";
            txtAgencyComm.Size = new Size(99, 23);
            txtAgencyComm.TabIndex = 13;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(197, 159, 96);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(238, 238);
            btnConfirm.Margin = new Padding(1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(83, 31);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(197, 159, 96);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(323, 238);
            btnCancel.Margin = new Padding(1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 22, 31);
            ClientSize = new Size(603, 279);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtAgencyComm);
            Controls.Add(label7);
            Controls.Add(txtBasePrice);
            Controls.Add(label6);
            Controls.Add(txtDesc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label3);
            Controls.Add(txtPkgName);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(1);
            Name = "AddModifyPackages";
            Text = "AddModifyPackage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtPkgName;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label4;
        private Label label5;
        private TextBox txtDesc;
        private Label label6;
        private TextBox txtBasePrice;
        private Label label7;
        private TextBox txtAgencyComm;
        private Button btnConfirm;
        private Button btnCancel;
    }
}