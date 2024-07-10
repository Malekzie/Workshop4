namespace Main
{
    partial class DescriptionForm
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            hiddenCancelButton = new Button();
            panel1 = new Panel();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(1245, 581);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // hiddenCancelButton
            // 
            hiddenCancelButton.ForeColor = SystemColors.Desktop;
            hiddenCancelButton.Location = new Point(1158, 19);
            hiddenCancelButton.Name = "hiddenCancelButton";
            hiddenCancelButton.Size = new Size(75, 23);
            hiddenCancelButton.TabIndex = 0;
            hiddenCancelButton.TabStop = false;
            hiddenCancelButton.Text = "Cancel";
            hiddenCancelButton.UseVisualStyleBackColor = true;
            hiddenCancelButton.Click += hiddenCancelButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(hiddenCancelButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 527);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 54);
            panel1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = SystemColors.Desktop;
            btnSubmit.Location = new Point(12, 19);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // DescriptionForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 34, 53);
            CancelButton = hiddenCancelButton;
            ClientSize = new Size(1245, 581);
            Controls.Add(panel1);
            Controls.Add(webView21);
            ForeColor = SystemColors.ControlLightLight;
            Name = "DescriptionForm";
            Text = "Description";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button hiddenCancelButton;
        private Panel panel1;
        private Button btnSubmit;
    }
}