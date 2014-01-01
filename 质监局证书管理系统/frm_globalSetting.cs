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
            bll=new SettingBLL();
            settings = bll.GetDefaultSetting();
            tb_address.Text = settings.AddrChs;
            tb_addressEng.Text = settings.AddrEng;
            tb_auth.Text = settings.VerificationNo;
            tb_email.Text = settings.Email;
            tb_fax.Text = settings.Fax;
            tb_standard1.Text = settings.Standard1;
            tb_standard2.Text = settings.Standard2;
            tb_tel.Text = settings.Telephone;
            tb_unitName.Text = settings.AuthUnitChs;
            tb_unitNameEng.Text = settings.AuthUnitEng;
            tb_zipcode.Text = settings.Zipcode;
            this.btn_apply.Enabled = false;
            
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                settings = new Settings("默认", tb_address.Text.Trim(), tb_addressEng.Text.Trim(), tb_unitName.Text.Trim(),
                                tb_unitNameEng.Text.Trim(), tb_email.Text.Trim(), tb_fax.Text.Trim(), tb_standard1.Text.Trim(),
                                tb_standard2.Text.Trim(), tb_tel.Text.Trim(), tb_auth.Text.Trim(),tb_zipcode.Text.Trim(), 1);
                bll = new SettingBLL();
                if (bll.UpdateSetting(settings))
                {
                    MessageBoxEx.Show("设定成功", "提示");
                    this.btn_apply.Enabled = false;
                }
                else
                {
                    MessageBoxEx.Show("设定失败", "提示");
                }
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

        private void Form_TextChanged(object sender, EventArgs e)
        {
            this.btn_apply.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (btn_apply.Enabled)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("内容已变更，确定放弃编辑？", "提示", MessageBoxButtons.YesNo))
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (btn_apply.Enabled)
            {
                if (CheckForm())
                {
                    settings = new Settings("默认", tb_address.Text.Trim(), tb_addressEng.Text.Trim(), tb_unitName.Text.Trim(),
                                    tb_unitNameEng.Text.Trim(), tb_email.Text.Trim(), tb_fax.Text.Trim(), tb_standard1.Text.Trim(),
                                    tb_standard2.Text.Trim(), tb_tel.Text.Trim(), tb_auth.Text.Trim(), tb_zipcode.Text.Trim(), 1);
                    bll = new SettingBLL();
                    if (bll.UpdateSetting(settings))
                    {
                        MessageBoxEx.Show("设定成功", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBoxEx.Show("设定失败", "提示");
                    }
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}