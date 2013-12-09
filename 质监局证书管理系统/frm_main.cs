using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.AdvTree;
using System.Configuration;
namespace 质监局证书管理系统
{
    public partial class frm_main : MetroAppForm
    {
        private LMSCommands _Commands;
        public frm_main()
        {
            InitializeComponent();
            InitLicenseList();

            this.Text = ConfigurationManager.AppSettings["appName"];
            _Commands = new LMSCommands();
           
            _Commands.LicenseCommands.New = new Command(components); // We pass in components from Form so the command gets disposed automatically when form is disposed
            _Commands.LicenseCommands.New.Executed += NewLicenseExecuted;
            _Commands.LicenseCommands.Cancel = new Command(components);
            _Commands.LicenseCommands.Cancel.Executed += CancelLicenseExecuted;
            //_Commands.LicenseCommands.Save = new Command(components);
            //_Commands.LicenseCommands.Save.Executed += SaveClientExecuted;
            btn_newLicense.Command = _Commands.LicenseCommands.New;
            _Commands.LicenseCommands.Save = new Command(components);
            _Commands.LicenseCommands.Save.Executed += SaveLicenseExecuted;


        }
        /// <summary>
        /// 初始证书列表
        /// </summary>
        public void InitLicenseList()
        {
            AccessDbClass accClass=new AccessDbClass(Application.StartupPath+"/DATA/license.mdb");
            DataTable dt = new DataTable(); 
            dt = accClass.SelectToDataTable(@"select * from license");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                advTree_licenseList.Nodes.Add(CreateLicenseNode(dt.Rows[i]["证书编号"].ToString(), dt.Rows[i]["受检单位"].ToString(), Convert.ToDateTime(dt.Rows[i]["受检日期"].ToString()), int.Parse(dt.Rows[i]["ID"].ToString())));
            }
           

            //关闭数据库 
            accClass.Close();
            
           
        }
        public Node CreateLicenseNode(string serialNo, string name, DateTime date,int id)
        {
            Node node = new Node(serialNo);
            node.Cells.Add(new Cell(name));
            node.Cells.Add(new Cell(date.ToShortDateString()));
            node.Tag = id;
            return node;
        }
        /// <summary>
        /// 初始化证书列表方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     

        private void metroAppButton1_Click(object sender, EventArgs e)
        {

        }

        private void advTree_licenseList_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            LicenseClass license = new LicenseClass(int.Parse(e.Node.Tag.ToString()));
            webBrowser1.DocumentText = license.getHtml();
                
        }
        LicenseControl _LicenseControl = null;
        void NewLicenseExecuted(object sender, EventArgs e)
        {
            Debug.Assert(_LicenseControl == null);
            _Commands.LicenseCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            _LicenseControl = new LicenseControl();
            _LicenseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.Padding = new System.Windows.Forms.Padding(8);
            _LicenseControl.Commands = _Commands;
            this.ShowModalPanel(_LicenseControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            
        }
        private void CancelLicenseExecuted(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            Debug.Assert(_LicenseControl != null);
            InitLicenseList();
            CloseClientDialog();
        }
        private void SaveLicenseExecuted(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            MessageBox.Show("mainframe");
        }
        private void CloseClientDialog()
        {


            _Commands.LicenseCommands.New.Enabled = true; // Enable new client command
            this.CloseModalPanel(_LicenseControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _LicenseControl.Commands = null;
            _LicenseControl.Dispose();
            _LicenseControl = null;
        }

        private void metroShell1_SettingsButtonClick(object sender, EventArgs e)
        {
            frm_Settings settings = new frm_Settings();
            settings.Show();
        }

        private void metroShell1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void metroShell1_CausesValidationChanged(object sender, EventArgs e)
        {

        }
       
    }
}
