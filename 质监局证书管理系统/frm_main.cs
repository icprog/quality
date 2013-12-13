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
using ModelLib;
namespace 质监局证书管理系统
{
    public partial class frm_main : MetroAppForm
    {
        private LMSCommands _Commands;
        private Node lastSelectNode;
        private bool isPreviewCalled=false;
        private bool isPrintCalled = false;
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

            if (ConfigurationManager.AppSettings["mdbFilePath"].ToString() == "")
            {
                ConfigurationManager.AppSettings["mdbFilePath"] = Application.StartupPath + "\\Data\\license.mdb";
                
            }


        }
        /// <summary>
        /// 初始证书列表
        /// </summary>
        public void InitLicenseList()
        {
            ModelLib.AccessDbClass accClass=new AccessDbClass(Application.StartupPath+"/DATA/license.mdb");
            DataTable dt = new DataTable(); 
            dt = accClass.SelectToDataTable(@"select * from license");
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

            if (e.Node != null)
            {
                LicenseClass license = new LicenseClass(int.Parse(e.Node.Tag.ToString()));
                webBrowser1.DocumentText = license.getHtml();
                lastSelectNode = e.Node;
            }
            else
            {
                LicenseClass license = new LicenseClass(int.Parse(lastSelectNode.Tag.ToString()));
                advTree_licenseList.SelectedNode = lastSelectNode;
                webBrowser1.DocumentText = license.getHtml();
            }
            
                
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
            _LicenseControl.tb_type.Focus();
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

        private void web_dummy_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            LicenseClass license = new LicenseClass(int.Parse(advTree_licenseList.SelectedNode.Tag.ToString()));
            int total=2;
            web_dummy.Document.GetElementById("frontLicenseNo").InnerText = license.Serial;
            web_dummy.Document.GetElementById("unitName").InnerText = license.UnitName;
            web_dummy.Document.GetElementById("instName").InnerText = license.InstructionName;
            web_dummy.Document.GetElementById("model").InnerText = license.Module;
            web_dummy.Document.GetElementById("manufactNo").InnerText = license.Manufact_no;
            web_dummy.Document.GetElementById("madeBy").InnerText = license.Madeby;
            web_dummy.Document.GetElementById("accordingTo").InnerText = license.According;
            web_dummy.Document.GetElementById("result").InnerText = license.Result;
            web_dummy.Document.GetElementById("approver").InnerText = license.ApprovedBy;
            web_dummy.Document.GetElementById("checker").InnerText = license.CheckedBy;
            web_dummy.Document.GetElementById("recorder").InnerText = license.VerifiedBy;
            web_dummy.Document.GetElementById("date_y").InnerText = license.Date.Year.ToString();
            web_dummy.Document.GetElementById("date_m").InnerText = license.Date.Month.ToString();
            web_dummy.Document.GetElementById("date_d").InnerText = license.Date.Day.ToString();
            web_dummy.Document.GetElementById("expire_y").InnerText = license.Expire.Year.ToString();
            web_dummy.Document.GetElementById("expire_m").InnerText = license.Expire.Month.ToString();
            web_dummy.Document.GetElementById("expire_d").InnerText = license.Expire.Day.ToString();
            web_dummy.Document.GetElementById("verificationNo").InnerText = ConfigurationManager.AppSettings["verificationNumber"].ToString();
            web_dummy.Document.GetElementById("tel").InnerText = ConfigurationManager.AppSettings["telephone"].ToString();
            web_dummy.Document.GetElementById("zipcode").InnerText = ConfigurationManager.AppSettings["zipcode"].ToString();
            web_dummy.Document.GetElementById("address").InnerText = ConfigurationManager.AppSettings["address"].ToString();
            web_dummy.Document.GetElementById("fax").InnerText = ConfigurationManager.AppSettings["fax"].ToString();
            web_dummy.Document.GetElementById("email").InnerText = ConfigurationManager.AppSettings["email"].ToString();
            web_dummy.Document.GetElementById("header_license1").InnerText ="证书编号："+license.Serial;
            web_dummy.Document.GetElementById("standard1").InnerText = ConfigurationManager.AppSettings["standard1"].ToString();
            web_dummy.Document.GetElementById("standard2").InnerText = ConfigurationManager.AppSettings["standard2"].ToString();
            if(!string.IsNullOrEmpty(license.BenchName1)){
                web_dummy.Document.GetElementById("bench_name").InnerHtml = "<span>" + license.BenchName1 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchName2))
            {
                web_dummy.Document.GetElementById("bench_name").InnerHtml += "<span>" + license.BenchName2 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchName3))
            {
                web_dummy.Document.GetElementById("bench_name").InnerHtml += "<span>" + license.BenchName3 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchRange1))
            {
                web_dummy.Document.GetElementById("bench_range").InnerHtml = "<span>" + license.BenchRange1 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchRange2))
            {
                web_dummy.Document.GetElementById("bench_range").InnerHtml += "<span>" + license.BenchRange2 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchRange3))
            {
                web_dummy.Document.GetElementById("bench_range").InnerHtml += "<span>" + license.BenchRange3 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.Notsure1))
            {
                web_dummy.Document.GetElementById("bench_notsure").InnerHtml = "<span>" + license.Notsure1 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.Notsure2))
            {
                web_dummy.Document.GetElementById("bench_notsure").InnerHtml += "<span>" + license.Notsure2 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.Notsure3))
            {
                web_dummy.Document.GetElementById("bench_notsure").InnerHtml += "<span>" + license.Notsure3 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchSn1))
            {
                web_dummy.Document.GetElementById("bench_sn").InnerHtml = "<span>" + license.BenchSn1 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchSn2))
            {
                web_dummy.Document.GetElementById("bench_sn").InnerHtml += "<span>" + license.BenchSn2 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchSn3))
            {
                web_dummy.Document.GetElementById("bench_sn").InnerHtml += "<span>" + license.BenchSn3 + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchName1))
            {
                web_dummy.Document.GetElementById("bench_expire").InnerHtml = "<span>" + license.Benchexpire1.ToString("yyyy年 MM月 dd日") + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchName2))
            {
                web_dummy.Document.GetElementById("bench_expire").InnerHtml += "<span>" + license.Benchexpire1.ToString("yyyy年 MM月 dd日") + "</span><br/>";
            }
            if (!string.IsNullOrEmpty(license.BenchName3))
            {
                web_dummy.Document.GetElementById("bench_expire").InnerHtml += "<span>" + license.Benchexpire1.ToString("yyyy年 MM月 dd日") + "</span><br/>";
            }
            web_dummy.Document.GetElementById("location").InnerText = license.Location;
            web_dummy.Document.GetElementById("temperature").InnerText = license.Temperature + "   ℃";
            web_dummy.Document.GetElementById("humidity").InnerText = license.Humidity + "   %RH";
            web_dummy.Document.GetElementById("presure").InnerText = license.Presure + "   kpa";
            if (!string.IsNullOrEmpty(license.ResultHTML))
            {
                web_dummy.Document.GetElementById("htmlresultA").InnerHtml = license.ResultHTML;
                web_dummy.Document.GetElementById("page1").Style = "page-break-after: always;";
            }
            if (!string.IsNullOrEmpty(license.ResultHTML2))
            {
                web_dummy.Document.GetElementById("htmlresultB").InnerHtml = license.ResultHTML2;
                web_dummy.Document.GetElementById("page2").Style = "page-break-after: always;";
                total++;
            }
            else
            {
                
                web_dummy.Document.GetElementById("page3").Style = "display:none";
                
                
            }
            if (!string.IsNullOrEmpty(license.ResultHTML3))
            {
                web_dummy.Document.GetElementById("htmlresultC").InnerHtml = license.ResultHTML3;
                web_dummy.Document.GetElementById("page3").Style = "page-break-after: always;";
                total++;
            }
            else
            {
               
                web_dummy.Document.GetElementById("page4").Style = "display:none";
            }
            if (!string.IsNullOrEmpty(license.ResultHTML4))
            {
                web_dummy.Document.GetElementById("htmlresultD").InnerHtml = license.ResultHTML4;
                total++;
            }
            else
            {
                web_dummy.Document.GetElementById("page5").Style = "display:none";
                //web_dummy.Document.GetElementById("page4").Style += "page-break-after: avoid;";
            }
            web_dummy.Document.GetElementById("totalPage1").InnerText = total.ToString();
            web_dummy.Document.GetElementById("totalPage2").InnerText = total.ToString();
            web_dummy.Document.GetElementById("totalPage3").InnerText = total.ToString();
            web_dummy.Document.GetElementById("totalPage4").InnerText = total.ToString();
            web_dummy.Document.GetElementById("totalPage5").InnerText = total.ToString();
            web_dummy.Document.GetElementById("header_license1").InnerText = "证书编号:" + license.Serial;
            web_dummy.Document.GetElementById("header_license2").InnerText = "证书编号:" + license.Serial;
            web_dummy.Document.GetElementById("header_license3").InnerText = "证书编号:" + license.Serial;
            web_dummy.Document.GetElementById("header_license4").InnerText = "证书编号:" + license.Serial;
            if (isPreviewCalled)
            {
                web_dummy.ShowPrintPreviewDialog();
                isPreviewCalled = false;
            }
            else if (isPrintCalled)
            {
                web_dummy.ShowPrintDialog();
                isPrintCalled = false;
            }
        }

        private void btn_tool_New_Click(object sender, EventArgs e)
        {
            _Commands.LicenseCommands.New.Enabled = false; // Disable new client command to prevent re-entrancy
            _LicenseControl = new LicenseControl();
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
       
    }
}
