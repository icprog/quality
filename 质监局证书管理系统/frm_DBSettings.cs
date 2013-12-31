using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Configuration;
using Quality.Utility;
using System.Xml;
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string ip = ip_serverip.Text;
            string port = int_port.Text;
            string username = tb_username.Text;
            string password = tb_password.Text;
            DBManager manager = new DBManager(ip, port, username, password);
            if (manager.isConnectable)
            {
                MessageBoxEx.Show(" 连接成功!", "提示");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.SaveConfig("sqlServerIPAddress", ip_serverip.Text);
            this.SaveConfig("sqlServerPort", int_port.Text);
            this.SaveConfig("dbUsername", tb_username.Text.Trim());
            this.SaveConfig("dbPassword",SysUtil.EncryptDES(tb_password.Text,"quality"));
            ConfigurationManager.RefreshSection("appSettings");
            frm_login login = new frm_login();
            login.Show();
            this.Close();
        }
        private void SaveConfig(string strKey, string strVal)
        {
            XmlDocument doc = new XmlDocument();
            //获得配置文件的全路径
            string strFileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            doc.Load(strFileName);
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //获得将当前元素的key属性
                XmlAttribute att = nodes[i].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value == strKey)
                {
                    //对目标元素中的第二个属性赋值
                    att = nodes[i].Attributes["value"];
                    att.Value = strVal;
                    break;
                }
            }
            //保存上面的修改
            doc.Save(strFileName);
        }
    }
}