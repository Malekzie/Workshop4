using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class DescriptionForm : Form
    {
        private string initialContent;

        public DescriptionForm(string content)
        {
            initialContent = content;
            InitializeComponent();
            InitializeAsync();

        }

        private async void InitializeAsync()
        {
            var env = await CoreWebView2Environment.CreateAsync(null, null, new CoreWebView2EnvironmentOptions("--remote-debugging-port=9222"));
            await webView21.EnsureCoreWebView2Async(env);
            LoadTinyMCE();
        }

        private void LoadTinyMCE()
        {
            string htmlFilePath = Path.Combine(Application.StartupPath, "editor.html");

            if (File.Exists(htmlFilePath))
            {
                // Modify HTML content to include the initial content
                string htmlContent = File.ReadAllText(htmlFilePath);
                htmlContent = htmlContent.Replace("<textarea id=\"mytextarea\"></textarea>", $"<textarea id=\"mytextarea\">{initialContent}</textarea>");
                webView21.NavigateToString(htmlContent);
            }
            else
            {
                MessageBox.Show($"HTML file for TinyMCE editor not found at path: {htmlFilePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetContent()
        {
            // Implement a way to retrieve content from TinyMCE (e.g., through JavaScript)
            // This is a placeholder; actual implementation may vary
            return initialContent;
        }

        private void hiddenCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
