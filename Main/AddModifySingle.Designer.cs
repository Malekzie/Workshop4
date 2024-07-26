namespace Main
{
    partial class AddModifySingle
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
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            btnConfirm = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = SystemColors.ControlLightLight;
            lblId.Location = new Point(29, 72);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(156, 69);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 31);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 120);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 117);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 31);
            txtName.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(197, 159, 96);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Location = new Point(60, 202);
            btnConfirm.Margin = new Padding(4, 5, 4, 5);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(107, 38);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Save";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(197, 159, 96);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(226, 202);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // AddModifySingle
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 22, 31);
            CancelButton = btnExit;
            ClientSize = new Size(394, 317);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnConfirm);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddModifySingle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddModifySingle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private Button btnConfirm;
        private Button btnExit;
    }
}