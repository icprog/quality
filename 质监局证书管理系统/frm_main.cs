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
using Quality;
using Quality.Model;
namespace 质监局证书管理系统
{
    public partial class frm_main : MetroAppForm
    {
        private LMSCommands _Commands;
        private Node lastSelectNode;
        private bool isPreviewCalled=false;
        private bool isPrintCalled = false;
        Users currentUser;

        public Users CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        public frm_main(Users user)
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
            _Commands.SearchDialogCommands.Open = new Command(components);
            _Commands.SearchDialogCommands.Open.Executed += CertificationSearchExcuted;
            _Commands.SearchDialogCommands.Cancel = new Command(components);
            _Commands.SearchDialogCommands.Cancel.Executed += CancelSearchDialogExecuted;
            tile_certManage.Command = _Commands.SearchDialogCommands.Open;
            lb_indexTitle.Text += user.Realname;
            lb_username.Text = user.Username;
            lb_role.Text = user.RoleName;
            currentUser = user;
            if (user.RoleName.IndexOf("管理员") >= 0)
            {
                pictureBox1.Image = Properties.Resources.admin;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.normal;
            }
            metroToolbar1.Location = new Point((this.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1);
            metroTilePanel1.Location = new Point((this.Width - metroTilePanel1.Width) / 2, (this.Height - metroTilePanel1.Height) / 2);
            
            
            
        }
        /// <summary>
        /// 初始证书列表
        /// </summary>
        public void InitLicenseList()
        {
            Quality.AccessDbClass accClass=new AccessDbClass(Application.StartupPath+"/DATA/license.mdb");
            DataTable dt = new DataTable(); 
            dt = accClass.SelectToDataTable("select * from license");
            advTree_licenseList.Nodes.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                advTree_licenseList.Nodes.Add(CreateLicenseNode(dt.Rows[i]["证书编号"].ToString(), dt.Rows[i]["受检单位"].ToString(), Convert.ToDateTime(dt.Rows[i]["受检日期"].ToString()), int.Parse(dt.Rows[i]["ID"].ToString()), dt.Rows[i]["计量器具名称"].ToString(), dt.Rows[i]["检定员"].ToString(), dt.Rows[i]["型号"].ToString(),dt.Rows[i]["出厂编号"].ToString()));
            }
           

            //关闭数据库 
            accClass.Close();
            
           
        }
        protected override void OnLoad(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnLoad(e);
        }
        private void UpdateControlsSizeAndLocation()
        {
           
            metroToolbar1.Location = new Point((this.Width - metroToolbar1.Width) / 2, metroToolbar1.Parent.Height - metroToolbar1.Height - 1);
            metroTilePanel1.Location= new Point((this.Width - metroTilePanel1.Width) / 2, (this.Height - metroTilePanel1.Height) / 2);
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnResize(e);
        }
        public Node CreateLicenseNode(string serialNo, string name, DateTime date,int id,string type,string recorder,string module,string instSerial)
        {
            Node node = new Node(serialNo);
            node.Cells.Add(new Cell(name));
           
            node.Cells.Add(new Cell(type));
            node.Cells.Add(new Cell(module));
             node.Cells.Add(new Cell(instSerial));
             node.Cells.Add(new Cell(recorder));
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

            //if (e.Node != null)
            //{
            //    LicenseClass license = new LicenseClass(int.Parse(e.Node.Tag.ToString()));
            //    webBrowser1.DocumentText = license.getHtml();
            //    lastSelectNode = e.Node;
            //}
            //else
            //{
            //    LicenseClass license = new LicenseClass(int.Parse(lastSelectNode.Tag.ToString()));
            //    advTree_licenseList.SelectedNode = lastSelectNode;
            //    webBrowser1.DocumentText = license.getHtml();
            //}
            
                
        }
        LicenseControl _LicenseControl = null;
        void NewLicenseExecuted(object sender, EventArgs e)
        {
            Debug.Assert(_LicenseControl == null);
            _Commands.LicenseCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            _LicenseControl = new LicenseControl(currentUser);
            
            _LicenseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.Padding = new System.Windows.Forms.Padding(8);
            _LicenseControl.Commands = _Commands;
            this.ShowModalPanel(_LicenseControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _LicenseControl.tb_type.Focus();
        }

        private void CancelLicenseExecuted(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            Debug.Assert(_LicenseControl != null);
            InitLicenseList();
            CloseClientDialog();
        }
        private void CancelSearchDialogExecuted(object sender, EventArgs e)
        {
            CloseSearchDialog();
        }
        CertificateSearch _CertificationSearch=null;
       private  void CertificationSearchExcuted(object sender,EventArgs e)
        {
            _CertificationSearch=new CertificateSearch();
            _CertificationSearch.Dock=System.Windows.Forms.DockStyle.Fill;
            _CertificationSearch.Commands = _Commands;
            this.ShowModalPanel(_CertificationSearch, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }
        private void SaveLicenseExecuted(object sender, EventArgs e)
        {
            // Simply close client entry form "dialog"
            //MessageBox.Show("mainframe");
            InitLicenseList();
            //CloseClientDialog();
        }
        private void CloseClientDialog()
        {


            _Commands.LicenseCommands.New.Enabled = true; // Enable new client command
            this.CloseModalPanel(_LicenseControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _LicenseControl.Commands = null;
            _LicenseControl.Dispose();
            _LicenseControl = null;
        }
        private void CloseSearchDialog()
        {
            _Commands.SearchDialogCommands.Open.Enabled = true;
            this.CloseModalPanel(_CertificationSearch, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _CertificationSearch.Commands = null;
            _CertificationSearch.Dispose();
            _CertificationSearch = null;
        }
       
        private void metroShell1_SettingsButtonClick(object sender, EventArgs e)
        {
            frm_Settings settings = new frm_Settings();
            settings.ShowDialog();
        }

        
        

       

        private void metroToolbar1_MouseHover(object sender, EventArgs e)
        {
            metroToolbar1.Expanded = true;
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void metroShell1_SizeChanged(object sender, EventArgs e)
        {
            UpdateControlsSizeAndLocation();
        }

        private void frm_main_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_tool_preview_Click(object sender, EventArgs e)
        {
            if (advTree_licenseList.SelectedNode != null)
            {
                isPreviewCalled = true;
                web_dummy.Navigate(Application.StartupPath + "\\Data\\template.html");
               

                
            }
            

        }

        //private void web_dummy_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
      
        //}

        private void btn_tool_New_Click(object sender, EventArgs e)
        {
            _Commands.LicenseCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            _LicenseControl = new LicenseControl(currentUser);
            _LicenseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.Padding = new System.Windows.Forms.Padding(8);
            _LicenseControl.Commands = _Commands;
            this.ShowModalPanel(_LicenseControl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            _LicenseControl.tb_type.Focus();
        }

        private void btn_tool_print_Click(object sender, EventArgs e)
        {
            if (advTree_licenseList.SelectedNode != null)
            {
                isPrintCalled = true;
                web_dummy.Navigate(Application.StartupPath + "\\Data\\template.html");



            }
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            this.NewLicenseExecuted(sender, e);
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            frm_userSettings userSetting = new frm_userSettings();
            userSetting.ShowDialog();
        }

        private void tile_certManage_Click(object sender, EventArgs e)
        {

        }

        private void lb_username_Click(object sender, EventArgs e)
        {
            frm_userinfo userinfo = new frm_userinfo();
            userinfo.User = this.currentUser;
            userinfo.ShowDialog();
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {

        }
       
    }
}
