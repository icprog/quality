using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Quality;
namespace 质监局证书管理系统
{
    public partial class frm_Settings : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frm_Settings()
        {
            InitializeComponent();
            InitSettings();
        }

        public void InitSettings()
        {
            tb_appName.Text = ConfigurationManager.AppSettings["programName"];
            tb_unitName.Text = ConfigurationManager.AppSettings["companyName"];
            tb_unitNameEng.Text = ConfigurationManager.AppSettings["companyNameEng"];

            tb_auth.Text = ConfigurationManager.AppSettings["verificationNumber"];
            tb_standard1.Text = ConfigurationManager.AppSettings["standard1"];
            tb_standard2.Text = ConfigurationManager.AppSettings["standard2"];

            tb_zipcode.Text = ConfigurationManager.AppSettings["zipcode"];
            tb_email.Text = ConfigurationManager.AppSettings["email"];
            tb_fax.Text = ConfigurationManager.AppSettings["fax"]
;
            tb_tel.Text = ConfigurationManager.AppSettings["telephone"];
            tb_addressEng.Text = ConfigurationManager.AppSettings["addressEng"];
            tb_address.Text = ConfigurationManager.AppSettings["address"];
            comb_freqExam.Text = ConfigurationManager.AppSettings["freq_exam"];

            comb_freq_match.Text = ConfigurationManager.AppSettings["freq_match"];
            comb_freqtest.Text = ConfigurationManager.AppSettings["freq_test"];
            tb_appName.Text = ConfigurationManager.AppSettings["appName"];
            ip_sqlIPAddress.Value = ConfigurationManager.AppSettings["sqlServerIPAddress"];
            int_port.Value = int.Parse(ConfigurationManager.AppSettings["sqlServerPort"].ToString());
            if (ConfigurationManager.AppSettings["mdbFilePath"].ToString() == "")
            {
                ConfigurationManager.AppSettings["mdbFilePath"] = Application.StartupPath + "\\Data\\license.mdb";
                tb_mdbfilename.Text = ConfigurationManager.AppSettings["mdbFilePath"].ToString();
            }
            else
            {
                tb_mdbfilename.Text = ConfigurationManager.AppSettings["mdbFilePath"].ToString();
            }
            
            if (ConfigurationManager.AppSettings["DBType"].ToString() == "online")
            {
                rb_online.Checked = true;
                tb_mdbfilename.Enabled = false;
                btn_loadMDB.Enabled = false;
                ip_sqlIPAddress.Enabled = true;
                int_port.Enabled = true;
                btn_testConn.Enabled = true;
                
            }
            else
            {
                rb_offline.Checked = true;
                tb_mdbfilename.Enabled = true;
                btn_loadMDB.Enabled = true;
                ip_sqlIPAddress.Enabled = false;
                int_port.Enabled = false;
                btn_testConn.Enabled = false;
            }
               
        }

        #region  方法保存修改的设置
        /// <summary>
        /// 方法保存修改的设置
        /// </summary>
        /// <param name="ConnenctionString"></param>
        /// <param name="strKey"></param>
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
        #endregion

        private void btn_save_Click(object sender, EventArgs e)
        {

            this.SaveConfig("programName", tb_appName.Text);
            this.SaveConfig("companyName", tb_unitName.Text);
            this.SaveConfig("companyNameEng", tb_unitNameEng.Text);
            this.SaveConfig("verificationNumber", tb_auth.Text);
            this.SaveConfig("standard1", tb_standard1.Text);
            this.SaveConfig("standard2", tb_standard2.Text);
            this.SaveConfig("zipcode", tb_zipcode.Text);
            this.SaveConfig("email", tb_email.Text);
            this.SaveConfig("fax", tb_fax.Text);
            this.SaveConfig("telephone", tb_tel.Text);
            this.SaveConfig("addressEng", tb_addressEng.Text);
            this.SaveConfig("address", tb_address.Text);
            this.SaveConfig("freq_exam", comb_freqExam.Text);
            this.SaveConfig("freq_match", comb_freq_match.Text);
            this.SaveConfig("appName", tb_appName.Text);
            this.SaveConfig("freq_test", comb_freqtest.Text);
            this.SaveConfig("sqlServerIPAddress", ip_sqlIPAddress.Text);
            this.SaveConfig("sqlServerPort", int_port.Value.ToString());
            this.SaveConfig("mdbFilePath", tb_mdbfilename.Text);
            if (rb_offline.Checked)
            {
                this.SaveConfig("DBType", "offline");

            }
            else
            {
                this.SaveConfig("DBType", "online");

                this.SaveConfig("connection", string.Format("Data Source={0},{1};Network Library=DBMSSOCN;Initial Catalog=qualityDB;User ID=sa;Password=dbadmin;", ip_sqlIPAddress.Text, int_port.Value.ToString()));
                
            }
            ConfigurationManager.RefreshSection("appSettings");

            //ConfigurationManager.AppSettings["programName"] = tb_appName.Text;
            //ConfigurationManager.AppSettings["companyName"] = tb_unitName.Text;
            //ConfigurationManager.AppSettings["companyNameEng"] = tb_unitNameEng.Text;

            //ConfigurationManager.AppSettings["verificationNumber"] = tb_auth.Text;
            //ConfigurationManager.AppSettings["standard1"] = tb_standard1.Text;
            //ConfigurationManager.AppSettings["standard2"] = tb_standard2.Text;

            //ConfigurationManager.AppSettings["zipcode"] = tb_zipcode.Text;
            //ConfigurationManager.AppSettings["email"] = tb_email.Text;
            //ConfigurationManager.AppSettings["fax"] = tb_fax.Text;
            //ConfigurationManager.AppSettings["telephone"] = tb_tel.Text;
            //ConfigurationManager.AppSettings["addressEng"] = tb_addressEng.Text;
            //ConfigurationManager.AppSettings["address"] = tb_address.Text;
            //ConfigurationManager.AppSettings["freq_exam"] = comb_freqExam.Text;

            //ConfigurationManager.AppSettings["freq_match"] = comb_freq_match.Text;
            //ConfigurationManager.AppSettings["freq_test"] = comb_freqtest.Text;
            this.Close();

        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            this.SaveConfig("programName", tb_appName.Text);
            this.SaveConfig("companyName", tb_unitName.Text);
            this.SaveConfig("companyNameEng", tb_unitNameEng.Text);
            this.SaveConfig("verificationNumber", tb_auth.Text);
            this.SaveConfig("standard1", tb_standard1.Text);
            this.SaveConfig("standard2", tb_standard2.Text);
            this.SaveConfig("zipcode", tb_zipcode.Text);
            this.SaveConfig("email", tb_email.Text);
            this.SaveConfig("fax", tb_fax.Text);
            this.SaveConfig("telephone", tb_tel.Text);
            this.SaveConfig("addressEng", tb_addressEng.Text);
            this.SaveConfig("address", tb_address.Text);
            this.SaveConfig("freq_exam", comb_freqExam.Text);
            this.SaveConfig("freq_match", comb_freq_match.Text);
            this.SaveConfig("appName", tb_appName.Text);
            this.SaveConfig("freq_test", comb_freqtest.Text);

            this.SaveConfig("sqlServerIPAddress", ip_sqlIPAddress.Text);
            this.SaveConfig("sqlServerPort", int_port.Value.ToString());
            this.SaveConfig("mdbFilePath", tb_mdbfilename.Text);
            if (rb_offline.Checked)
            {
                this.SaveConfig("DBType", "offline");

            }
            else
            {
                this.SaveConfig("DBType", "online");

                this.SaveConfig("connStr", string.Format("Data Source={0}\\SQLEXPRESS;Initial Catalog=QualityDB;Integrated Security=True;Pooling=False"));

            }
            ConfigurationManager.RefreshSection("appSettings");

            //ConfigurationManager.AppSettings["programName"] = tb_appName.Text;
            //ConfigurationManager.AppSettings["companyName"] = tb_unitName.Text;
            //ConfigurationManager.AppSettings["companyNameEng"] = tb_unitNameEng.Text;

            //ConfigurationManager.AppSettings["verificationNumber"] = tb_auth.Text;
            //ConfigurationManager.AppSettings["standard1"] = tb_standard1.Text;
            //ConfigurationManager.AppSettings["standard2"] = tb_standard2.Text;

            //ConfigurationManager.AppSettings["zipcode"] = tb_zipcode.Text;
            //ConfigurationManager.AppSettings["email"] = tb_email.Text;
            //ConfigurationManager.AppSettings["fax"] = tb_fax.Text;
            //ConfigurationManager.AppSettings["telephone"] = tb_tel.Text;
            //ConfigurationManager.AppSettings["addressEng"] = tb_addressEng.Text;
            //ConfigurationManager.AppSettings["address"] = tb_address.Text;
            //ConfigurationManager.AppSettings["freq_exam"] = comb_freqExam.Text;

            //ConfigurationManager.AppSettings["freq_match"] = comb_freq_match.Text;
            //ConfigurationManager.AppSettings["freq_test"] = comb_freqtest.Text;
            btn_apply.Enabled = false;
            this.Close();

        }


       

        private void rb_offline_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_offline.Checked)
            {
                tb_mdbfilename.Enabled = true;
                btn_loadMDB.Enabled = true;
                ip_sqlIPAddress.Enabled = false;
                int_port.Enabled = false;
                btn_testConn.Enabled = false;
            }
            else
            {
                tb_mdbfilename.Enabled = false;
                btn_loadMDB.Enabled = false;
                ip_sqlIPAddress.Enabled = true;
                int_port.Enabled = true;
                btn_testConn.Enabled = true;
            }
        }

        private void btn_testConn_Click(object sender, EventArgs e)
        {
            //bool isSuccess=SqlHelper.ConnectTest(string.Format("Data Source={0},{1};Network Library=DBMSSOCN;Initial Catalog=qualityDB;User ID=sa;Password=dbadmin;", ip_sqlIPAddress.Text, int_port.Value.ToString()));
            //if (isSuccess)
            //{
            //    MessageBox.Show("连接成功");

            //}
            //else
            //{
            //    MessageBox.Show("连接失败");
            //}
        }

        private void btn_loadMDB_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_mdbfilename.Text = openFileDialog1.FileName;
            
            }
        }

        private void di_temper_ValueChanged(object sender, EventArgs e)
        {
           // di_temper.Text = di_temper.Text.Substring(0, di_temper.Text.IndexOf(".") + 2);
        }
        

        
    }
}