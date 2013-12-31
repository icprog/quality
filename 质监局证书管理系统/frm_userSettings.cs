using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.AdvTree;
using System.Configuration;
using Quality;
using Quality.Model;
using Quality.BLL;
namespace 质监局证书管理系统
{
    public partial class frm_userSettings : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserBLL bll;
        private RoleBLL roleBll;
        private bool isEditing;
        private bool isModify;
        private bool isRoleEditing;
        private bool isRoleModify;
        public frm_userSettings()
        {
            InitializeComponent();
            InitRealnameList(tb_autoRealname.Text.Trim());
            InitRoleDropdownList();
            InitRolenameList();
            this.DisableForm();
            this.DisableRoleForm();
            
        }
        public void InitRealnameList(string realname)
        {
            bll=new UserBLL();
            adv_realnameList.Nodes.Clear();
            IList<Users> users = bll.GetRealNameList(realname);
            for (int i = 0; i < users.Count; i++)
            {
               adv_realnameList.Nodes.Add(CreateRealnameNode(users[i].Id,users[i].Realname));
            }
        }
        public void InitRolenameList()
        {
            roleBll = new RoleBLL();
            adv_roleList.Nodes.Clear();
            IList<Roles> roles = roleBll.GetAllRoles();
            foreach (Roles role in roles)
            {
                adv_roleList.Nodes.Add(CreateRoleNode(role.Id,role.RoleName,role.RoleValue));

            }

        }
        
        private Node CreateRealnameNode(int id,string realname)
        {
            Node node = new Node(realname);
        
            node.Tag = id;
            return node;
        }
        private Node CreateRoleNode(int roleId, string rolename, string roleValue)
        {
            Node node = new Node(rolename);
            node.Tooltip = "权限:"+roleValue;
            node.Tag = roleId;
            return node;

        }

        private void tb_autoRealname_KeyUp(object sender, KeyEventArgs e)
        {
            InitRealnameList(tb_autoRealname.Text.Trim());
        }

        private void adv_realnameList_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            if (isEditing)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃编辑？", "放弃保存", MessageBoxButtons.YesNo))
                {
                    
                }
                else 
                {
                    return;
                }
            }
            this.DisableForm();
            Users user=new Users();
            user = bll.GetUserById((int)e.Node.Tag);
            this.lb_id.Text = user.Id.ToString();
            this.tb_realname.Text = user.Realname;
            this.tb_username.Text = user.Username;
            this.tb_password.Text = user.Password;
            this.tb_password2.Text = user.Password;
            this.comb_role.SelectedValue = user.RoleId;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_saveUser.Enabled = false;
        }

        private void btn_newuser_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃编辑？", "放弃保存", MessageBoxButtons.YesNo))
                {

                }
                else
                {
                    return;
                }
            }
            this.EnableForm();
            this.ClearForm();
            this.btn_saveUser.Enabled = true;

        }
        public void SetUserInfo(Users user)
        {
            lb_id.Text = user.Id.ToString();
            tb_realname.Text = user.Realname;
            tb_username.Text = user.Username;
            tb_password.Text = user.Password;
            tb_password2.Text = user.Password;
        }
        private void InitRoleDropdownList()
        {
            comb_role.Nodes.Clear();
            roleBll = new RoleBLL();
            comb_role.DataSource = roleBll.GetRoleDropDown();
            

        }
        private void ClearForm()
        {
            this.lb_id.Text = "";
            this.tb_password.Text = "";
            this.tb_password2.Text = "";
            this.tb_realname.Text = "";
            this.tb_username.Text = "";
            this.comb_role.Text = "";
        }
        private void DisableForm()
        {
            this.tb_username.Enabled = false;
            this.tb_realname.Enabled = false;
            this.tb_password.Enabled = false;
            this.tb_password2.Enabled = false;
            this.comb_role.Enabled = false;
            this.isEditing = false;
            this.isModify = false;
            this.btn_saveUser.Enabled = false;

        }
        private void EnableForm()
        {
            this.tb_username.Enabled = true;
            this.tb_realname.Enabled = true;
            this.tb_password.Enabled = true;
            this.tb_password2.Enabled = true;
            this.comb_role.Enabled = true;
            this.isEditing = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.EnableForm();
            this.tb_username.Enabled = false;

            this.btn_saveUser.Enabled = true;
            this.isModify = true;
        }

        private void adv_realnameList_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("aaa");
          
        }

        private void adv_realnameList_AfterNodeDeselect(object sender, AdvTreeNodeEventArgs e)
        {
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (bll.DeleteUserById(int.Parse(lb_id.Text)))
            {
                MessageBoxEx.Show("删除成功", "删除用户");
                this.ClearForm();
                
                this.DisableForm();
                InitRealnameList("");
            }
            else
            {
                MessageBoxEx.Show("删除失败", "删除用户");
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                if (!bll.CheckUsername(tb_username.Text))
                {
                    errorProvider1.SetError(tb_username, " 用户名已存在。");
                    highlighter1.SetHighlightColor(tb_username, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                }
                else
                {
                    errorProvider1.Clear();
                    highlighter1.SetHighlightColor(tb_username, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                }
            }
        }

        private void tb_password2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_password2_Leave(object sender, EventArgs e)
        {
            if (isEditing)
            {
                if (tb_password.Text != tb_password2.Text)
                {
                    errorProvider1.SetError(tb_password2, " 两次输入的密码不一致。");
                    highlighter1.SetHighlightColor(tb_password2, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                }
                else
                {
                    errorProvider1.Clear();
                    highlighter1.SetHighlightColor(tb_password2, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                }
            }
        }
        private void SetError(Control c, string ErrMsg)
        {
            errorProvider1.SetError(c, ErrMsg);
            highlighter1.SetHighlightColor(c, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
        }
        private void SetError(Control c, string ErrMsg,string color)
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
        private void btn_saveUser_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tb_username.Text.Trim()))
            {
                this.SetError(tb_username, "用户名不能为空!");
                tb_username.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.tb_realname.Text.Trim(), "[\u4e00-\u9fa5]+$"))
            {
                this.SetError(tb_realname, "真实姓名不是汉字!", "red");
                tb_realname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tb_password.Text) )
            {
                this.SetError(tb_password, "密码不能为空!", "red");
                tb_password.Focus();
                return;
            }
            if (tb_password.Text != tb_password2.Text)
            {
                this.SetError(tb_password2, "两次密码输入不一致!", "red");
                tb_password2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comb_role.SelectedDisplayMember))
            {
                this.SetError(comb_role, "请选择用户角色!", "red");
                
                return;
            }
            Users user = new Users(tb_username.Text.Trim(), (int)comb_role.SelectedValue, tb_password.Text, tb_realname.Text.Trim());
            if (isModify)
            {
                user.Id = int.Parse(lb_id.Text);
                if (bll.UpdateUser(user))
                {
                    MessageBoxEx.Show("修改成功!", "修改用户");
                    this.DisableForm();

                    InitRealnameList("");
                }
                else
                {
                    MessageBoxEx.Show("修改失败!", "添加用户");
                }
            }
            else
            {
                if (bll.AddUser(user))
                {
                    MessageBoxEx.Show("添加成功!", "添加用户");
                    this.DisableForm();
                    this.ClearForm();

                    InitRealnameList("");
                }
                else
                {
                    MessageBoxEx.Show("添加失败!", "添加用户");
                }
            }
        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void tb_realname_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
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

        }
        
       
        private void comb_role_SelectionChanged(object sender, AdvTreeNodeEventArgs e)
        {
            if (string.IsNullOrEmpty(comb_role.SelectedDisplayMember))
            {
                this.SetError(comb_role, "请选择用户角色!", "red");

            }
            else
            {
                this.RemoveError(comb_role);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃编辑？", "放弃保存", MessageBoxButtons.YesNo))
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else this.Close(); 
        }

        #region // 角色管理
        private void DisableRoleForm()
        {
            this.tb_roleName.Enabled = false;
            this.cb_roleEdit.Enabled = false;
            this.cb_roleMakeLicense.Enabled = false;
            this.cb_roleManage.Enabled = false;
            this.cb_roleReprint.Enabled = false;
            this.cb_roleSearch.Enabled = false;
            this.cb_roleTemplate.Enabled = false;
            this.btn_saveRole.Enabled = false;
            isRoleEditing = false;
            isRoleModify = false;
             
        }

        private void EnableRoleFrom()
        {
            this.tb_roleName.Enabled = true;
            this.cb_roleEdit.Enabled = true;
            this.cb_roleMakeLicense.Enabled = true;
            this.cb_roleManage.Enabled = true;
            this.cb_roleReprint.Enabled = true;
            this.cb_roleSearch.Enabled = true;
            this.cb_roleTemplate.Enabled = true;
            isRoleEditing = true;
        }
        private void ClearRoleForm()
        {
            this.tb_roleName.Text = "";
            UncheckAll();
            lb_roleId.Text = "";
        }
        private void UncheckAll()
        {
            this.cb_roleEdit.Checked = false;
            this.cb_roleMakeLicense.Checked = false;
            this.cb_roleManage.Checked = false;
            this.cb_roleReprint.Checked = false;
            this.cb_roleSearch.Checked = false;
            this.cb_roleTemplate.Checked = false;
        }
        private void SetRoleValue(string roleValue)
        {
            UncheckAll();
            string[] values = roleValue.Split('|');
            foreach (string value in values)
            {
                SetCheckBox(value);
            }
        }
        private string GetRoleValue()
        {
            string roleValue = "";
            if (cb_roleMakeLicense.Checked)
                roleValue += cb_roleMakeLicense.CheckValue+"|";
            if (cb_roleEdit.Checked)
                roleValue += cb_roleEdit.CheckValue + "|";
            if (cb_roleReprint.Checked)
                roleValue += cb_roleReprint.CheckValue + "|";
            if (cb_roleSearch.Checked)
                roleValue += cb_roleSearch.CheckValue + "|";
            if (cb_roleManage.Checked)
                roleValue += cb_roleManage.CheckValue + "|";
            if (cb_roleTemplate.Checked)
                roleValue += cb_roleTemplate.CheckValue + "|";
            return roleValue;
        }
        private void SetCheckBox(string name)
        {
            
            if (!string.IsNullOrEmpty(name))
            {
                switch (name)
                {
                    case "新建证书":
                        cb_roleMakeLicense.Checked = true;
                        break;
                    case "修改证书":
                        cb_roleEdit.Checked = true;
                        break;
                    case "证书重印":
                        this.cb_roleReprint.Checked = true;
                        break;
                    case "证书搜索":
                        this.cb_roleSearch.Checked = true;
                        break;
                    case "权限管理":
                        this.cb_roleManage.Checked = true;
                        break;
                    case "模板管理":
                        this.cb_roleTemplate.Checked = true;
                        break;
                }
            }
        }
        #endregion

        private void advTree1_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            

            if (isRoleEditing)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃编辑？", "放弃保存", MessageBoxButtons.YesNo))
                {

                }
                else
                {
                    return;
                }
            }
            this.DisableRoleForm();
            Roles role = roleBll.GetRoleById(int.Parse(e.Node.Tag.ToString()));

            tb_roleName.Text = role.RoleName;
            this.SetRoleValue(role.RoleValue);
            lb_roleId.Text = role.Id.ToString();
            this.btn_roleModify.Enabled = true;
            this.btn_roleDelete.Enabled = true;
            btn_saveRole.Enabled = false;

        }

        private void adv_roleList_AfterNodeDeselect(object sender, AdvTreeNodeEventArgs e)
        {
            this.btn_roleDelete.Enabled = false;
            this.btn_roleModify.Enabled = false;
        }

        private void btn_saveRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_roleName.Text.Trim()))
            {
                this.SetError(tb_username, "角色名不能为空!");
                tb_username.Focus();
                return;
            }


            Roles role;
            if (isRoleModify)
            {
                role = new Roles(int.Parse(this.lb_roleId.Text), tb_roleName.Text.Trim(), GetRoleValue());
                
                    if (roleBll.UpdateRole(role))
                    {
                        MessageBoxEx.Show("修改成功!", "修改角色");
                        this.DisableRoleForm();
                        InitRoleDropdownList();
                        InitRolenameList();
                    }
                    else
                    {
                        MessageBoxEx.Show("修改失败!", "修改角色");
                    }
                
               
            }
            else
            {
                role = new Roles(tb_roleName.Text.Trim(), GetRoleValue());
                if (roleBll.Check(role.RoleName))
                {
                    if (roleBll.AddRole(role))
                    {
                        MessageBoxEx.Show("添加成功!", "添加角色");
                        this.DisableRoleForm();
                        this.ClearForm();
                        InitRolenameList();
                        InitRoleDropdownList();
                    }
                    else
                    {
                        MessageBoxEx.Show("添加失败!", "添加角色");
                    }
                }
               
            }
        }

        private void btn_roleModify_Click(object sender, EventArgs e)
        {
            this.EnableRoleFrom();
            this.btn_saveRole.Enabled = true;
            this.isRoleModify = true;
        }

        private void btn_newRole_Click(object sender, EventArgs e)
        {
            if (isRoleEditing)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃编辑？", "放弃保存", MessageBoxButtons.YesNo))
                {

                }
                else
                {
                    return;
                }
            }
            this.EnableRoleFrom();
            ClearRoleForm();
            this.btn_saveRole.Enabled = true;
        }

        private void tb_roleName_TextChanged(object sender, EventArgs e)
        {
            if (isRoleEditing)
            {
                if (!roleBll.Check(tb_roleName.Text))
                    this.SetError(tb_roleName, "角色名已存在!");
                else
                    this.RemoveError(tb_roleName);
            }
        }

        private void btn_roleDelete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBoxEx.Show("如果您确定删除，该角色所属的用户将被冻结并且无法登录，\n需要管理员重新赋予新的角色。", "删除角色", MessageBoxButtons.YesNo))
            {
                if (roleBll.DeleteRole(int.Parse(lb_roleId.Text)))
                {
                    MessageBoxEx.Show("删除成功", "删除角色");
                    this.ClearRoleForm();
                    this.InitRoleDropdownList();
                    this.DisableRoleForm();
                    InitRolenameList();
                }
                else
                {
                    MessageBoxEx.Show("删除失败", "删除角色");
                }
            }
            else
            {
                return;
            }
           
        }

        private void btn_roleCancle_Click(object sender, EventArgs e)
        {
            if (isRoleEditing)
            {
                if (DialogResult.Yes == MessageBoxEx.Show("确定放弃编辑？", "放弃保存", MessageBoxButtons.YesNo))
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else this.Close(); 
        }
    }
    //public class ComboBoxItem:BaseItem
    //{
    //    private string _text;

    //    public string Text
    //    {
    //        get { return _text; }
    //        set { _text = value; }
    //    }
    //    private object _value;

    //    public object Value
    //    {
    //        get { return _value; }
    //        set { _value = value; }
    //    }
    //    public override string ToString()
    //    {
    //        return this._text;
    //    }
    //    public ComboBoxItem(string text, object value)
    //    {
    //        _text = text;
    //        _value = value;
    //    }
    //}
}