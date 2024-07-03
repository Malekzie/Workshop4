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
            txtId = new TextBox();
            txtPkgName = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            grbID.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "Package Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // grbID
            // 
            grbID.Controls.Add(txtId);
            grbID.Controls.Add(label2);
            grbID.Location = new Point(546, 12);
            grbID.Name = "grbID";
            grbID.Size = new Size(293, 63);
            grbID.TabIndex = 2;
            grbID.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(137, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 2;
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(191, 44);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(209, 31);
            txtPkgName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 87);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "Start Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(191, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(622, 80);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(140, 31);
            dateTimePicker2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 86);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 186);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 8;
            label5.Text = "Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 186);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(571, 154);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 124);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 10;
            label6.Text = "Base Price:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 31);
            textBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(420, 124);
            label7.Name = "label7";
            label7.Size = new Size(171, 25);
            label7.TabIndex = 12;
            label7.Text = "Agency Commision:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(622, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 31);
            textBox3.TabIndex = 13;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(191, 419);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(574, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddModifyPackages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 465);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtPkgName);
            Controls.Add(grbID);
            Controls.Add(label1);
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
        private TextBox txtId;
        private TextBox txtPkgName;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Button btnConfirm;
        private Button btnCancel;
    }
}