namespace Main.Forms
{
    partial class RelationEntryForm
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            lblRel2 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.Desktop;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.ForeColor = SystemColors.Desktop;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(349, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Relation 1";
            // 
            // lblRel2
            // 
            lblRel2.AutoSize = true;
            lblRel2.Location = new Point(264, 50);
            lblRel2.Name = "lblRel2";
            lblRel2.Size = new Size(59, 15);
            lblRel2.TabIndex = 3;
            lblRel2.Text = "Relation 2";
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = SystemColors.Desktop;
            btnSubmit.Location = new Point(148, 415);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.Desktop;
            btnCancel.Location = new Point(264, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RelationEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 53);
            ClientSize = new Size(503, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(lblRel2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "RelationEntryForm";
            Text = "RelationEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label lblRel2;
        private Button btnSubmit;
        private Button btnCancel;
    }
}