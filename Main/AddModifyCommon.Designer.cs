namespace Main
{
    partial class AddModifyCommon
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
            lblRel1 = new Label();
            lblRel2 = new Label();
            cboRel1 = new ComboBox();
            cboRel2 = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblRel1
            // 
            lblRel1.AutoSize = true;
            lblRel1.Location = new Point(12, 35);
            lblRel1.Name = "lblRel1";
            lblRel1.Size = new Size(59, 25);
            lblRel1.TabIndex = 0;
            lblRel1.Text = "label1";
            // 
            // lblRel2
            // 
            lblRel2.AutoSize = true;
            lblRel2.Location = new Point(12, 101);
            lblRel2.Name = "lblRel2";
            lblRel2.Size = new Size(59, 25);
            lblRel2.TabIndex = 1;
            lblRel2.Text = "label2";
            // 
            // cboRel1
            // 
            cboRel1.FormattingEnabled = true;
            cboRel1.Location = new Point(119, 32);
            cboRel1.Name = "cboRel1";
            cboRel1.Size = new Size(287, 33);
            cboRel1.TabIndex = 2;
            // 
            // cboRel2
            // 
            cboRel2.FormattingEnabled = true;
            cboRel2.Location = new Point(119, 98);
            cboRel2.Name = "cboRel2";
            cboRel2.Size = new Size(287, 33);
            cboRel2.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(197, 159, 96);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(119, 189);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(197, 159, 96);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(253, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddModifyCommon
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 22, 31);
            CancelButton = btnCancel;
            ClientSize = new Size(444, 235);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cboRel2);
            Controls.Add(cboRel1);
            Controls.Add(lblRel2);
            Controls.Add(lblRel1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "AddModifyCommon";
            Text = "AddModifyCommon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRel1;
        private Label lblRel2;
        private ComboBox cboRel1;
        private ComboBox cboRel2;
        private Button btnSubmit;
        private Button btnCancel;
    }
}