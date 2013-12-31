using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Quality.Model;
using Quality.BLL;
namespace 质监局证书管理系统
{
    public partial class frm_userinfo : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Users _user;
        private bool isChange;
        private UserBLL userBll;
        public Users User
        {
            get { return _user; }
            set { _user = value; }
        }
        public frm_userinfo()
        {
            InitializeComponent();

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void frm_userinfo_Load(object sender, EventArgs e)
        {
            tb_realname.Text = _user.Realname;
            lb_username.Text = _user.Username;
            tb_password1.Text = _user.Password;
            tb_password2.Text = _user.Password;
            lb_role.Text = _user.RoleName;
            this.isChange = false;
            btn_save.Enabled = false;
            
        }

        private void Form_TextChanged(object sender, EventArgs e)
        {
            isChange = true;
            btn_save.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                
                if(tb_password1.Text!=tb_password2.Text)
                {
                    this.SetError(tb_password2,"两次输入的密码不一致。");
                    return;
                }
                if(tb_password1.Text=="")
                {
                    this.SetError(tb_password1,"请输入密码！");
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.tb_realname.Text.Trim(), "[\u4e00-\u9fa5]+$"))
                {
                    this.SetError(tb_realname, "真实姓名不是汉字!", "red");
                    tb_realname.Focus();
                    return;

                }
                userBll=new UserBLL();
                _user.Realname=tb_realname.Text.Trim();
                _user.Password=tb_password1.Text;
                if (userBll.UpdateUser(_user))
                {
                    MessageBoxEx.Show("修改成功!", "修改个人信息");
                    this.btn_save.Enabled = false;
                    this.isChange = false;
                }
                else
                {
                    MessageBoxEx.Show("修改失败!", "修改个人信息");
                }
            }
        }

        private void tb_password2_Leave(object sender, EventArgs e)
        {
            if (tb_password1.Text != tb_password2.Text)
            {
                errorProvider1.SetError(tb_password2, " 两次输入的密码不一致。");
                highlighter1.SetHighlightColor(tb_password2, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
            else if (string.IsNullOrEmpty(tb_password2.Text))
            {
                errorProvider1.SetError(tb_password2, " 请输入密码!");
                highlighter1.SetHighlightColor(tb_password2, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
            else
            {
                errorProvider1.Clear();
                highlighter1.SetHighlightColor(tb_password2, DevComponents.DotNetBar.Validator.eHighlightColor.None);
            }
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

        private void tb_realname_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.tb_realname.Text.Trim(), "[\u4e00-\u9fa5]+$"))
            {
                this.SetError(tb_realname, "真实姓名不是汉字!", "red");
                tb_realname.Focus();

            }
            else
            {
                RemoveError(tb_realname);
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃保存？", "放弃保存", MessageBoxButtons.YesNo))
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }
      
    }
}