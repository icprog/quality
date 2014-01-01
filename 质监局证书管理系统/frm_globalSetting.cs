using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Quality.BLL;
using Quality.Model;
namespace 质监局证书管理系统
{
    public partial class frm_globalSetting : DevComponents.DotNetBar.Metro.MetroForm
    {
        private SettingBLL bll;
        private Settings settings;

        public Settings Settings
        {
            get { return settings; }
            set { settings = value; }
        }
        public frm_globalSetting()
        {
            InitializeComponent();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Settings setting = new Settings("默认", tb_address.Text.Trim(), tb_addressEng.Text.Trim(), tb_unitName.Text.Trim(),
                                tb_unitNameEng.Text.Trim(), tb_email.Text.Trim(), tb_fax.Text.Trim(), tb_standard1.Text.Trim(),
                                tb_standard2.Text.Trim(), tb_tel.Text.Trim(), tb_auth.Text.Trim(),tb_zipcode.Text.Trim(), 1);
                
            }
        }
        private bool CheckForm()
        {
            if (string.IsNullOrEmpty(tb_standard1.Text.Trim()))
            {
                this.SetError(tb_standard1, "内容不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_auth.Text.Trim()))
            {
                this.SetError(tb_auth, "内容不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_standard2.Text.Trim()))
            {
                this.SetError(tb_standard2, "内容不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_unitName.Text.Trim()))
            {
                this.SetError(tb_unitName, "内容不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_unitNameEng.Text.Trim()))
            {
                this.SetError(tb_unitNameEng, "内容不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_address.Text.Trim()))
            {
                this.SetError(tb_address, "内容不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_addressEng.Text.Trim()))
            {
                this.SetError(tb_addressEng, "内容不能为空!");
                return false;

            }
            if (string.IsNullOrEmpty(tb_zipcode.Text.Trim()))
            {
                this.SetError(tb_zipcode, "内容不能为空!");
                return false;

            }
            if (string.IsNullOrEmpty(tb_email.Text.Trim()))
            {
                this.SetError(tb_email, "内容不能为空!");
                return false;

            }
            if (string.IsNullOrEmpty(tb_tel.Text.Trim()))
            {
                this.SetError(tb_tel, "内容不能为空!");
                return false;

            }
            if (string.IsNullOrEmpty(tb_fax.Text.Trim()))
            {
                this.SetError(tb_fax, "内容不能为空!");
                return false;
            }
            return true;
        }
        private void SetError(Control c, string ErrMsg)
        {
            errorProvider1.SetError(c, ErrMsg);
            highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
        }
        private void SetError(Control c, string ErrMsg, string color)
        {
            errorProvider1.SetError(c, ErrMsg);
            switch (color)
            {
                case "red":
                    highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    break;
                case "orange":
                    highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
                    break;
            }

        }
        private void RemoveError(Control c)
        {
            errorProvider1.Clear();
            highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.None);
        }
    }
}