using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Word;
using Quality;
using System.Configuration;
using Quality.Model;
using Quality.BLL;
using Quality.Utility;
namespace 质监局证书管理系统
{
    public partial class LicenseControl : UserControl
    {
        #region 控件成员变量
        bool a_isOpen = false;
        bool b_isOpen = false;
        bool c_isOpen = false;
        bool Validated = true;
        bool gridChanged=false;
        private Users _users;
        private CertificationBLL certBll;

        public Users Users
        {
            get { return _users; }
            set { _users = value; }
        }
        DBManager manager;
        Certification license;
        private BenchSetBLL benchBll;
        private AutoCompleteBLL autoBll;
        #endregion

        public LicenseControl(Users user)
        {
            InitializeComponent();
            _users = user;
            InitAutoComplete();
            //InitializeEmptyGrid();
            superTabControl1.Visible = true;
            tb_type.Focus();
            manager = new DBManager();
            
        }
        public void InitAutoComplete()
        {
           
            DateTime expire = DateTime.Now;
            expire = expire.AddYears(1);
            expire = expire.AddDays(-1);
            dt_expire.Value = expire;

            //器具名称下拉框初始化，
            autoBll = new AutoCompleteBLL();
            string[] items=autoBll.GetInstNameList();
            tbd_instName.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            tbd_instName.AutoCompleteCustomSource.AddRange(items);
            tbd_instName.Items.AddRange(items);

            ////制造厂
            items = autoBll.GetMadeByList();
            tbd_madeBy.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            tbd_madeBy.AutoCompleteCustomSource.AddRange(items);
            tbd_madeBy.Items.AddRange(items);
         
            ////检定依据
            items = autoBll.GetAccordingList();
            tb_accordingTo.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            tb_accordingTo.AutoCompleteCustomSource.AddRange(items);
            tb_accordingTo.Items.AddRange(items);

            ////专用证书
            items = autoBll.GetUsedLicense();
            tb_license.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            tb_license.AutoCompleteCustomSource.AddRange(items);
            tb_license.Items.AddRange(items);
            
            
            //常用标准器具
            benchBll = new BenchSetBLL();
            IList<BenchSet> bSets = benchBll.GetAllBenchSet(_users.Id);
            comb_benchSet1.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            comb_benchSet2.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            comb_benchSet3.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (BenchSet bSet in bSets)
            {
                comb_benchSet1.Items.Add(bSet.SetName);
                comb_benchSet1.AutoCompleteCustomSource.Add(bSet.SetName);
                comb_benchSet2.Items.Add(bSet.SetName);
                comb_benchSet2.AutoCompleteCustomSource.Add(bSet.SetName);
                comb_benchSet3.Items.Add(bSet.SetName);
                comb_benchSet3.AutoCompleteCustomSource.Add(bSet.SetName);
               
            }

        }
        #region Command 设置
        private LMSCommands _Commands;
        public LMSCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    LMSCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        protected virtual void OnCommandsChanged(LMSCommands oldValue, LMSCommands newValue)
        {
            if (newValue != null)
            {
                btn_save.Command = newValue.LicenseCommands.Save;
                btn_cancel.Command = newValue.LicenseCommands.Cancel;
                btn_preview.Command = newValue.LicenseCommands.Preview;
                btn_print.Command = newValue.LicenseCommands.Print;
                btn_reset.Command = newValue.LicenseCommands.Reset;
            }
            else
            {
                btn_save.Command = null;
                btn_cancel.Command = null;
                btn_preview.Command = null;
                btn_print.Command = null;
                btn_reset.Command = null;
            }
        }
        #endregion

        #region 添加标准器具 1 2 3
        /// <summary>
        /// 添加器具按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!groupPanel2.Visible && !groupPanel3.Visible)
            {
                groupPanel2.Visible = true;
                panel4.Location = new Point(panel4.Location.X, panel4.Location.Y + 130);
                linkLabel2.Text = "+添加标准器具(2/3)";
            }
            else if (groupPanel2.Visible && !groupPanel3.Visible)
            {
                groupPanel3.Visible = true;
                panel4.Location = new Point(panel4.Location.X, panel4.Location.Y + 130);
                linkLabel2.Text = "+添加标准器具(3/3)";
            }
            else
            {
                MessageBox.Show("最多可添加3个标准器具!");
            }




        }
        #endregion

        #region 检定结果A表格 行列变化

        /// <summary>
        /// 列个数发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colCountChanged(object sender, EventArgs e)
        {

            if (int_col.Value > superGridControl1.PrimaryGrid.Columns.Count)
            {
                int addcount = int_col.Value - superGridControl1.PrimaryGrid.Columns.Count;

                for (int i = 0; i < addcount; i++)
                {
                    DevComponents.DotNetBar.SuperGrid.GridColumn col = new DevComponents.DotNetBar.SuperGrid.GridColumn("数据项" + (int_col.Value - addcount + 1 + i));
                    col.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl);
                    col.AllowSelection = true;

                    for (int j = 0; j < superGridControl1.PrimaryGrid.Rows.Count; j++)
                    {
                        DevComponents.DotNetBar.SuperGrid.GridCell cell = new DevComponents.DotNetBar.SuperGrid.GridCell();
                        cell.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl);


                    }
                    superGridControl1.PrimaryGrid.Columns.Add(col);
                }

                int colCnt = superGridControl1.PrimaryGrid.Columns.Count;
                int rowCnt = superGridControl1.PrimaryGrid.Rows.Count;
                string[,] data = new string[rowCnt, colCnt];
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt - 1; j++)
                    {
                        DevComponents.DotNetBar.SuperGrid.GridRow row = (DevComponents.DotNetBar.SuperGrid.GridRow)superGridControl1.PrimaryGrid.Rows[i];
                        if (row.Cells[j].Value == null)
                        {
                            data[i, j] = "";

                        }
                        else data[i, j] = row.Cells[j].Value.ToString();



                    }
                }
                superGridControl1.PrimaryGrid.GridPanel.Rows.Clear();
                for (int i = 0; i < rowCnt; i++)
                {
                    DevComponents.DotNetBar.SuperGrid.GridRow row = new DevComponents.DotNetBar.SuperGrid.GridRow();
                    for (int j = 0; j < colCnt; j++)
                    {
                        DevComponents.DotNetBar.SuperGrid.GridCell cell = new DevComponents.DotNetBar.SuperGrid.GridCell();
                        cell.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl);
                        cell.Value = string.IsNullOrEmpty(data[i, j]) ? "" : data[i, j];
                        row.Cells.Add(cell);
                    }
                    superGridControl1.PrimaryGrid.Rows.Add(row);


                }

            }
            else if (int_col.Value < superGridControl1.PrimaryGrid.Columns.Count)
            {
                int deleteCount = superGridControl1.PrimaryGrid.Columns.Count - int_col.Value;
                for (int j = 0; j < deleteCount; j++)
                {
                    superGridControl1.PrimaryGrid.Columns.RemoveAt(superGridControl1.PrimaryGrid.Columns.Count - 1);
                }


            }
        }

        /// <summary>
        /// 行个数发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rowCountChanged(object sender, EventArgs e)
        {
            if (int_row.Value > superGridControl1.PrimaryGrid.Rows.Count)
            {
                int addcount = int_row.Value - superGridControl1.PrimaryGrid.Rows.Count;
                for (int j = 0; j < addcount; j++)
                {
                    DevComponents.DotNetBar.SuperGrid.GridRow row = new DevComponents.DotNetBar.SuperGrid.GridRow();
                    for (int i = 0; i < superGridControl1.PrimaryGrid.Columns.Count; i++)
                    {
                        DevComponents.DotNetBar.SuperGrid.GridCell cell = new DevComponents.DotNetBar.SuperGrid.GridCell();
                        cell.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl);
                        row.Cells.Add(cell);


                    }

                    superGridControl1.PrimaryGrid.Rows.Add(row);

                }



            }
            else if (int_row.Value < superGridControl1.PrimaryGrid.Rows.Count)
            {
                int deleteCount = superGridControl1.PrimaryGrid.Rows.Count - int_row.Value;
                for (int i = 0; i < deleteCount; i++)
                {
                    superGridControl1.PrimaryGrid.Rows.RemoveAt(superGridControl1.PrimaryGrid.Rows.Count - 1);
                }


            }
        }
        #endregion





        private void button1_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Show();

        }

        private void Setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Settings settings = new frm_Settings();
            settings.Show();
        }

        #region 检定，测试，校准 切换
        private void radio_exam_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_exam.Checked)
            {
                lb_instName.Text = "器具名称:";
                lb_instSerial.Text = "器具编号:";
                lb_unitName.Text = "受检方:";
                lb_date.Text = "检定日期:";
                lb_according.Text = "检定依据:";
                labelX19.Visible = true;
                tb_result.Visible = true;
                lb_location.Text = "检定地点:";
                tb_result.Text = "";
                tb_comment.Text = "";
                lb_expire.Text = "有效期至:";
                superTabItem2.Text = "检定数据";
                superTabItem6.Text = "检定数据A";
                superTabItem4.Text = "检定数据B";
                tbd_filename3.Text = "检定数据C";

            }
        }

        private void radio_match_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_match.Checked)
            {
                lb_instName.Text = "样品名称:";
                lb_instSerial.Text = "样品编号:";
                lb_unitName.Text = "委托方:";
                lb_date.Text = "校准日期:";
                lb_according.Text = "校准依据:";
                labelX19.Visible = false;
                tb_result.Visible = false;
                tb_result.Text = "校准";
                lb_location.Text = "校准地点:";
                tb_comment.Text = "建议下次校准日期不超过" + dt_date.Value.AddYears(1).AddDays(-1).ToString("yyyy年MM月dd日") + "。";
                lb_expire.Text = "收样日期:";
                superTabItem2.Text = "校准数据";
                superTabItem6.Text = "校准数据A";
                superTabItem4.Text = "校准数据B";
                tbd_filename3.Text = "校准数据C";
            }

        }

        private void radio_test_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_test.Checked)
            {

                lb_date.Text = "测试日期:";
                lb_according.Text = "测试依据:";
                labelX19.Visible = false;
                tb_result.Visible = false;
                tb_result.Text = "测试";
                lb_location.Text = "测试地点:";
                tb_comment.Text = "建议下次测试日期不超过" + dt_date.Value.AddYears(1).AddDays(-1).ToString("yyyy年MM月dd日") + "。";
                lb_expire.Text = "收样日期:";
                superTabItem2.Text = "测试数据";
                superTabItem6.Text = "测试数据A";
                superTabItem4.Text = "测试数据B";
                tbd_filename3.Text = "测试数据C";

            }
        }
        #endregion

        #region 打开结果末班ABC
        private void btn_OpenA_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                webBrowser1.Navigate("about:blank");
                tbd_filename1.Text = openFileDialog1.FileName;
                string sFilePath = openFileDialog1.FileName;

                if (SysUtil.GetFileExt(sFilePath) == ".doc")
                {
                    WordHelp helper = new WordHelp();
                    helper.Open(sFilePath);
                    string htmlFilePath = System.Windows.Forms.Application.StartupPath + "/TEMP/temp_" + DateTime.Now.Ticks + ".html";
                    helper.SaveAsHtml(htmlFilePath);

                    helper.Quit();
                    this.labelItem1.Text = "转换中";
                    Thread.Sleep(3000);

                    this.labelItem1.Text = "转换完毕";
                    // webBrowser1.Navigate(System.Windows.Forms.Application.StartupPath + "/ckeditor/samples/editor.html");

                    StreamReader reader = new StreamReader(htmlFilePath, Encoding.GetEncoding("gb2312"), true);


                    string html = reader.ReadToEnd();

                    html = html.Substring(html.IndexOf("punctuation'>"), html.Length - html.IndexOf("punctuation'>"));
                    html = html.Substring(13, html.IndexOf("</body>") - 12);

                    webBrowser1.Navigate(this.getEditorHTML(html));
                }
                else if (SysUtil.GetFileExt(sFilePath) == ".html")
                {
                    webBrowser1.Navigate(sFilePath);
                }

                a_isOpen = true;
            }
        }
        private void btn_openB_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                webBrowser2.Navigate("about:blank");
                tbd_filename2.Text = openFileDialog1.FileName;
                string sFilePath = openFileDialog1.FileName;
                if (SysUtil.GetFileExt(sFilePath) == ".doc")
                {
                    WordHelp helper = new WordHelp();
                    helper.Open(sFilePath);
                    string htmlFilePath = System.Windows.Forms.Application.StartupPath + "/TEMP/temp_" + DateTime.Now.Ticks + ".html";
                    helper.SaveAsHtml(htmlFilePath);

                    helper.Quit();
                    Thread.Sleep(3000);
                    // webBrowser1.Navigate(System.Windows.Forms.Application.StartupPath + "/ckeditor/samples/editor.html");

                    StreamReader reader = new StreamReader(htmlFilePath, Encoding.GetEncoding("gb2312"), true);


                    string html = reader.ReadToEnd();

                    html = html.Substring(html.IndexOf("punctuation'>"), html.Length - html.IndexOf("punctuation'>"));
                    html = html.Substring(13, html.IndexOf("</body>") - 12);


                    reader.Close();
                    webBrowser2.Navigate(this.getEditorHTML(html));

                }
                else if (SysUtil.GetFileExt(sFilePath) == ".html")
                {
                    webBrowser2.Navigate(sFilePath);
                }


                b_isOpen = true;
            }





        }

        private void btn_openC_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                webBrowser3.Navigate("about:blank");
                tbd_filename3.Text = openFileDialog1.FileName;
                string sFilePath = openFileDialog1.FileName;
                if (SysUtil.GetFileExt(sFilePath) == ".doc")
                {
                    WordHelp helper = new WordHelp();
                    helper.Open(sFilePath);
                    string htmlFilePath = System.Windows.Forms.Application.StartupPath + "/TEMP/temp_" + DateTime.Now.Ticks + ".html";
                    helper.SaveAsHtml(htmlFilePath);

                    helper.Quit();
                    Thread.Sleep(3000);
                    // webBrowser1.Navigate(System.Windows.Forms.Application.StartupPath + "/ckeditor/samples/editor.html");

                    StreamReader reader = new StreamReader(htmlFilePath, Encoding.GetEncoding("gb2312"), true);


                    string html = reader.ReadToEnd();

                    html = html.Substring(html.IndexOf("punctuation'>"), html.Length - html.IndexOf("punctuation'>"));
                    html = html.Substring(13, html.IndexOf("</body>") - 12);


                    webBrowser3.Navigate(this.getEditorHTML(html));
                    reader.Close();
                }
                else if (SysUtil.GetFileExt(sFilePath) == ".html")
                {
                    webBrowser3.Navigate(sFilePath);
                }


                c_isOpen = true;
            }
        }
        private void btn_ClearA_Click(object sender, EventArgs e)
        {
            tbd_filename1.Text = "";
            webBrowser1.Navigate("about:blank");
            a_isOpen = false;
            ;
        }

        private void btn_clearB_Click(object sender, EventArgs e)
        {
            tbd_filename2.Text = "";
            webBrowser2.Navigate("about:blank");
            b_isOpen = false;
        }

        private void btn_clearC_Click(object sender, EventArgs e)
        {
            tbd_filename3.Text = "";
            webBrowser3.Navigate("about:blank");
            c_isOpen = false;
        }

        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {



        }
        private void btn_save_dummy_Click(object sender, EventArgs e)
        {
            if (this.Validated)
                btn_save.PerformClick();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            certBll = new CertificationBLL();
            license = new Certification();
            license.According = tb_accordingTo.Text;
            license.ApprovedBy = tb_approver.Text;
            license.Benchexpire1 = dt_benchExpire1.Value;
            license.BenchName1 = tb_benchname1.Text;
            license.BenchRange1 = tb_benchRange1.Text;
            license.BenchSerial1 = tb_benchserial1.Text;
            license.BenchSn1 = tb_benchSn1.Text;
            license.Notsure1 = tb_notsure1.Text;

            license.Benchexpire2 = dt_benchExpire2.Value;
            license.BenchName2 = tb_benchName2.Text;
            license.BenchRange2 = tb_benchRange2.Text;
            license.BenchSerial2 = tb_benchSerial2.Text;
            license.BenchSn2 = tb_benchSn2.Text;
            license.Notsure2 = tb_notSure2.Text;

            license.Benchexpire3 = dt_benchExpire3.Value;
            license.BenchName3 = tb_benchName3.Text;
            license.BenchRange3 = tb_benchRange3.Text;
            license.BenchSerial3 = tb_benchSerial3.Text;
            license.BenchSn3 = tb_benchSn3.Text;
            license.Notsure3 = tb_notSure3.Text;
            license.CheckedBy = tb_check.Text;
            license.Comment = tb_comment.Text;
            license.Date = dt_date.Value;
            license.Expire = dt_expire.Value;
            license.Humidity =di_humidity.Text;
            license.InstructionName = tbd_instName.Text;
            license.LicenseNotsure = tb_licenseNotsure.Text;
            license.Location = comb_location.Text;
            license.Madeby = tbd_madeBy.Text;
            license.Manufact_no = tb_instSerial.Text;
            license.Module = tb_module.Text;
            license.Presure = di_presure.Text;
            license.Result = tb_result.Text;
            license.ResultHTML = GetResultAGrid();
            license.ResultHTML2 = (a_isOpen ? webBrowser1.Document.GetElementById("htmlText").InnerHtml : "");
            license.ResultHTML3 = (b_isOpen ? webBrowser2.Document.GetElementById("htmlText").InnerHtml : "");
            license.ResultHTML4 = (c_isOpen ? webBrowser3.Document.GetElementById("htmlText").InnerHtml : "");

            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrEmpty(license.ResultHTML))
                {
                    license.ResultHTML = license.ResultHTML2;
                    license.ResultHTML2 = license.ResultHTML3;
                    license.ResultHTML3 = license.ResultHTML4;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (string.IsNullOrEmpty(license.ResultHTML2))
                {
                    license.ResultHTML2 = license.ResultHTML3;
                    license.ResultHTML3 = license.ResultHTML4;
                }
            }
            if (string.IsNullOrEmpty(license.ResultHTML3))
            {
                license.ResultHTML3 = license.ResultHTML4;
            }
            
            

            license.Serial = tb_licenseNo.Text;
            license.Telephone = tb_authToTel.Text;
            license.Temperature =di_temperatue.Text;
            license.Type = tb_type.Text;
            license.UnitName = tb_authTo.Text;
            license.UseLimit = tb_limit.Text;
            license.VerifiedBy = tb_recorder.Text;
            license.UseLicense = tb_license.Text;
            license.PrintCount = 0;
            if(radio_exam.Checked)
                license.CertType="检定";
            else if(radio_match.Checked)
                license.CertType="校准";
            else if(radio_test.Checked)
                license.CertType="测试";
            if (certBll.AddCertification(license))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加成功");
            }
            

                
        }
        #region 控件数据验证
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_licenseNo_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_licenseNo, "证书编号不能为空");
        }

        private void tb_type_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_type, "计量类别不能为空");
        }
        private void tbd_instName_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tbd_instName, "计量器具名称不能为空");
        }

        private void tb_instSerial_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_instSerial, "器具编号不能为空");
        }
        private void tb_authTo_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_authTo, "受检单位名称不能为空");
        }
        private void tb_accordingTo_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_accordingTo, "检定依据不能为空");
        }

        private void tb_license_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_license, "专用证书不能为空");
        }
        private void tb_result_Validating(object sender, CancelEventArgs e)
        {
            this.SetErrorEmpty(tb_result, "检定结论不能为空");
        }

        #endregion



        #region 窗口方法
        private void SetErrorEmpty(Control c, string errMsg)
        {
            if (string.IsNullOrEmpty(c.Text))
            {
                errorProvider1.SetError(c, errMsg);
                highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                //highlighter1.GetHighlightOnFocus(tb_licenseNo);
                //e.Cancel = true;
                this.Validated = false;
                return;
            }
            else
            {
                errorProvider1.Clear();
                highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                this.Validated = true;
            }
        }

        /// <summary>
        /// 初始化空白表格
        /// </summary>
        private void InitializeEmptyGrid()
        {
            int rowCount = int_row.Value;
            int colCount = int_col.Value;
            DataTable table = new DataTable();
            for (int i = 0; i < colCount; i++)
            {
                DataColumn col = new DataColumn();
                col.ColumnName = "数据项" + (i + 1).ToString();
                col.DataType = Type.GetType("System.String");
                table.Columns.Add(col);
            }
            for (int j = 0; j < rowCount; j++)
            {
                DataRow dr = null;
                dr = table.NewRow();
                table.Rows.Add(dr);

            }
            superGridControl1.PrimaryGrid.DataSource = table;
        }

        /// <summary>
        /// 用WORD转换的html文件替换，生成模板html文件
        /// </summary>
        /// <param name="replace">doc转换的html</param>
        /// <returns>生成的文件名</returns>
        private string getEditorHTML(string replace)
        {
            string html = "<!DOCTYPE html><html><head>";
            html += "<meta charset=\"UTF-8\">";
            html += "<title>API Usage &mdash; CKEditor Sample</title>";
            html += "<script src=../ckeditor/ckeditor.js ></script>";
            html += "<script src=../ckeditor/jquery-1.10.2.js ></script>";
            html += "<link href=\"sample.css\" rel=\"stylesheet\">";
            //html += "<script>";
            html += "<script>";
            html += " function keyup(e){";
            html+=" GetContents();";
            
             html+="}";
            html+=" function GetContents() {";
            html += "var editor = CKEDITOR.instances.editor1;";
            html += "document.getElementById('htmlText').innerHTML=editor.getData();";
            html += "}";
            html += "CKEDITOR.on( 'instanceReady', function( ev ) {GetContents();";
            html += "var editor = CKEDITOR.instances.editor1;if(ev.editor.document.$.addEventListener) ";
            html += " ev.editor.document.$.addEventListener('keyup',keyup,false);";
                html += " else if(ev.editor.document.$.attachEvent)";
                html += " ev.editor.document.$.attachEvent('onkeyup',function(ev){keyup(ev)});  ";
            html += "var command = editor.getCommand( 'maximize' );";
            html += "command.exec();});";
            html += "</script>";
            html += "</head><body>";
            html += "<div Id=htmlText style='display:none'></div>";
            html += "<textarea cols=\"100\" Id=\"editor1\" name=\"editor1\" rows=\"20\">" + replace + "</textarea>";
            html += "<script>";
            html += " CKEDITOR.replace( 'editor1', {";
            html += "customConfig : \"../ckeditor/config.js\",";
            html += "on: {blur:GetContents,";
            html += "pluginsLoaded: function( evt ) {";
            html += "var doc = CKEDITOR.document, ed = evt.editor;";
            html += "if ( !ed.getCommand( 'bold' ) )";
            html += "doc.getById( 'exec-bold' ).hide();";
            html += "if ( !ed.getCommand( 'link' ) )";
            html += "doc.getById( 'exec-link' ).hide();";
            html += "}";
            html += "}";
            html += "});";
            html += "</script>";
            html += "</body>";
            html += "</html>";
            string randFilename = System.Windows.Forms.Application.StartupPath + "/temp/temp_" + DateTime.Now.Ticks + ".html";
            FileStream fs = new FileStream(randFilename, FileMode.Create);
            byte[] htmldata = new UTF8Encoding().GetBytes(html);
            fs.Write(htmldata, 0, htmldata.Length);
            fs.Flush();
            fs.Close();
            return randFilename;
        }
        private string GetResultAGrid()
        {
                int colCnt = superGridControl1.PrimaryGrid.Columns.Count;
                int rowCnt = superGridControl1.PrimaryGrid.Rows.Count;
                
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        DevComponents.DotNetBar.SuperGrid.GridRow row = (DevComponents.DotNetBar.SuperGrid.GridRow)superGridControl1.PrimaryGrid.Rows[i];
                        if (row.Cells[j].Value != null)
                        {
                            this.gridChanged=true;

                        }
                       
                    }
                }
            
            
            if(cb_useResultA.Value&&this.gridChanged)
            {
                string html = "<table border=1>";
                int roucount = superGridControl1.PrimaryGrid.Rows.Count;
                int colcount = superGridControl1.PrimaryGrid.Columns.Count;
                for (int i = 0; i < roucount; i++)
                {
                    html += "<tr>";
                    DevComponents.DotNetBar.SuperGrid.GridRow row = (DevComponents.DotNetBar.SuperGrid.GridRow)superGridControl1.PrimaryGrid.Rows[i];
                    for (int j = 0; j < colcount; j++)
                    {

                        if (row.Cells[j].Value == null)
                        {
                            html += "<td></td>";
                        }
                        else
                        {
                            html += "<td>" + row.Cells[j].Value.ToString() + "</td>";
                        }
                    }
                    html += "</tr>";
                }
                html += "</table>";
                return html;
                }
                else 
                    return "";
        }
        #endregion

       
        private void comb_benchSet1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //BenchSetbench = manager.GetBenchSet(comb_benchSet1.SelectedItem.ToString());
            //tb_benchname1.Text = bench.BenchName;
            //tb_benchRange1.Text = bench.BenchRange;
            //tb_benchserial1.Text = bench.BenchSerial;
            //dt_benchExpire1.Value = bench.Expire;
            //tb_benchSn1.Text = bench.BenchSn;
            //tb_notsure1.Text = bench.Notsure;

        }

       

        private void superGridControl1_EditorValueChanged(object sender, DevComponents.DotNetBar.SuperGrid.GridEditEventArgs e)
        {
            this.gridChanged=true;
        
        }

        private void cb_useResultA_ValueChanged(object sender, EventArgs e)
        {
            if (!cb_useResultA.Value)
            {
                int_col.Enabled = false;
                int_row.Enabled = false;
                superGridControl1.Enabled = false;
            }
            else
            {
                int_col.Enabled = true;
                int_row.Enabled = true;
                superGridControl1.Enabled = true;
            }
        }

        private void comb_benchSet1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            benchBll = new BenchSetBLL();
            BenchSet bSet = benchBll.GetBenchSetByName(comb_benchSet1.SelectedItem.ToString(), _users.Id);
           
            tb_benchname1.Text = bSet.BenchName;
            tb_benchRange1.Text = bSet.BenchRange;
            tb_benchserial1.Text = bSet.BenchSerial;
            dt_benchExpire1.Value = bSet.Expire;
            tb_benchSn1.Text = bSet.BenchSn;
            tb_notsure1.Text = bSet.Notsure;
        }

        private void comb_benchSet2_SelectedIndexChanged(object sender, EventArgs e)
        {
            benchBll = new BenchSetBLL();
            BenchSet bSet = benchBll.GetBenchSetByName(comb_benchSet2.SelectedItem.ToString(), _users.Id);

            tb_benchName2.Text = bSet.BenchName;
            tb_benchRange2.Text = bSet.BenchRange;
            tb_benchSerial2.Text = bSet.BenchSerial;
            dt_benchExpire2.Value = bSet.Expire;
            tb_benchSn2.Text = bSet.BenchSn;
            tb_notSure2.Text = bSet.Notsure;
        }

        private void comb_benchSet3_SelectedIndexChanged(object sender, EventArgs e)
        {
            benchBll = new BenchSetBLL();
            BenchSet bSet = benchBll.GetBenchSetByName(comb_benchSet3.SelectedItem.ToString(), _users.Id);

            tb_benchName3.Text = bSet.BenchName;
            tb_benchRange3.Text = bSet.BenchRange;
            tb_benchSerial3.Text = bSet.BenchSerial;
            dt_benchExpire3.Value = bSet.Expire;
            tb_benchSn3.Text = bSet.BenchSn;
            tb_notSure3.Text = bSet.Notsure;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            license = new Certification();
            license.According = tb_accordingTo.Text;
            license.ApprovedBy = tb_approver.Text;
            license.Benchexpire1 = dt_benchExpire1.Value;
            license.BenchName1 = tb_benchname1.Text;
            license.BenchRange1 = tb_benchRange1.Text;
            license.BenchSerial1 = tb_benchserial1.Text;
            license.BenchSn1 = tb_benchSn1.Text;
            license.Notsure1 = tb_notsure1.Text;

            license.Benchexpire2 = dt_benchExpire2.Value;
            license.BenchName2 = tb_benchName2.Text;
            license.BenchRange2 = tb_benchRange2.Text;
            license.BenchSerial2 = tb_benchSerial2.Text;
            license.BenchSn2 = tb_benchSn2.Text;
            license.Notsure2 = tb_notSure2.Text;

            license.Benchexpire3 = dt_benchExpire3.Value;
            license.BenchName3 = tb_benchName3.Text;
            license.BenchRange3 = tb_benchRange3.Text;
            license.BenchSerial3 = tb_benchSerial3.Text;
            license.BenchSn3 = tb_benchSn3.Text;
            license.Notsure3 = tb_notSure3.Text;
            license.CheckedBy = tb_check.Text;
            license.Comment = tb_comment.Text;
            license.Date = dt_date.Value;
            license.Expire = dt_expire.Value;
            license.Humidity = di_humidity.Text;
            license.InstructionName = tbd_instName.Text;
            license.LicenseNotsure = tb_licenseNotsure.Text;
            license.Location = comb_location.Text;
            license.Madeby = tbd_madeBy.Text;
            license.Manufact_no = tb_instSerial.Text;
            license.Module = tb_module.Text;
            license.Presure = di_presure.Text;
            license.Result = tb_result.Text;
            license.ResultHTML = GetResultAGrid();
            license.ResultHTML2 = (a_isOpen ? webBrowser1.Document.GetElementById("htmlText").InnerHtml : "");
            license.ResultHTML3 = (b_isOpen ? webBrowser2.Document.GetElementById("htmlText").InnerHtml : "");
            license.ResultHTML4 = (c_isOpen ? webBrowser3.Document.GetElementById("htmlText").InnerHtml : "");

            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrEmpty(license.ResultHTML))
                {
                    license.ResultHTML = license.ResultHTML2;
                    license.ResultHTML2 = license.ResultHTML3;
                    license.ResultHTML3 = license.ResultHTML4;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (string.IsNullOrEmpty(license.ResultHTML2))
                {
                    license.ResultHTML2 = license.ResultHTML3;
                    license.ResultHTML3 = license.ResultHTML4;
                }
            }
            if (string.IsNullOrEmpty(license.ResultHTML3))
            {
                license.ResultHTML3 = license.ResultHTML4;
            }
            license.Serial = tb_licenseNo.Text;
            license.Telephone = tb_authToTel.Text;
            license.Temperature = di_temperatue.Text;
            license.Type = tb_type.Text;
            license.UnitName = tb_authTo.Text;
            license.UseLimit = tb_limit.Text;
            license.VerifiedBy = tb_recorder.Text;
            license.UseLicense = tb_license.Text;
            license.PrintCount = 0;
            if (radio_exam.Checked)
                license.CertType = "检定";
            else if (radio_match.Checked)
                license.CertType = "校准";
            else if (radio_test.Checked)
                license.CertType = "测试";


        }

        

        







    }
}
