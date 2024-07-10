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
            panel1.SuspendLayout();
            packageId.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Package ID:";
            // 
            // txtPkgId
            // 
            txtPkgId.Location = new Point(86, 37);
            txtPkgId.Name = "txtPkgId";
            txtPkgId.Size = new Size(52, 23);
            txtPkgId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 124);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Package Name:";
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(156, 116);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(171, 23);
            txtPkgName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 182);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(156, 174);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(112, 23);
            dtpStartDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 211);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(156, 203);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(112, 23);
            dtpEndDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 240);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(156, 232);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(171, 23);
            txtBasePrice.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 269);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 11;
            label6.Text = "Agent Commision:";
            // 
            // txtAgentCommision
            // 
            txtAgentCommision.Location = new Point(156, 261);
            txtAgentCommision.Name = "txtAgentCommision";
            txtAgentCommision.Size = new Size(171, 23);
            txtAgentCommision.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(packageId);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 100);
            panel1.TabIndex = 14;
            // 
            // packageId
            // 
            packageId.Controls.Add(label1);
            packageId.Controls.Add(txtPkgId);
            packageId.Dock = DockStyle.Left;
            packageId.Location = new Point(0, 0);
            packageId.Name = "packageId";
            packageId.Size = new Size(217, 96);
            packageId.TabIndex = 0;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(156, 145);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(171, 23);
            txtDes.TabIndex = 16;
            txtDes.DoubleClick += txtDes_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 153);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 15;
            label7.Text = "Description:";
            // 
            // AddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 53);
            ClientSize = new Size(709, 368);
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
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "AddModifyPackages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddModifyPackage";
            panel1.ResumeLayout(false);
            packageId.ResumeLayout(false);
            packageId.PerformLayout();
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
    }
}