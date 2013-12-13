using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace 质监局证书管理系统
{
    public partial class LicensePreview : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string _htmlFilePath;
        public LicensePreview()
        {
            InitializeComponent();
            webBrowser1.Navigate(Application.StartupPath+"\\Data\\HTMLPage1.htm");

            webBrowser1.ShowPrintPreviewDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}