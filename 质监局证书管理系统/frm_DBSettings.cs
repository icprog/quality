using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Configuration;
namespace 质监局证书管理系统
{
    public partial class frm_DBSettings : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frm_DBSettings()
        {
            InitializeComponent();
            string ipAddress = ConfigurationManager.AppSettings["sqlServerIPAddress"].ToString();
            if (!string.IsNullOrEmpty(ipAddress))
            {
                ip_serverip.Text = ipAddress;
            }
            string port = ConfigurationManager.AppSettings["sqlServerPort"].ToString();
            if (!string.IsNullOrEmpty(port))
            {
                int_port.Value = int.Parse(port);
            }
        }

        private void frm_DBSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}