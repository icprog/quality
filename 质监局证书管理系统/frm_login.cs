using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Quality;
using System.Configuration;
using Quality.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Quality.BLL;
using Quality.Utility;
namespace 质监局证书管理系统
{
    public partial class frm_login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public bool bLogin = false;
        private Users _users;
        private int attemptCount = 0; //尝试次数
        private UserBLL userbll;
        public Users Users
        {
            get { return _users; }
            set { _users = value; }
        }
        private int errCount = 0;

        public int ErrCount
        {
            get { return errCount; }
            set { errCount = value; }
        }
        private DBManager manager;
        public frm_login()
        {
            InitializeComponent();
            manager = new DBManager();
            if (!manager.isConnectable)
            {
                MessageBoxEx.Show("数据库服务器连接错误。\n错误信息:" + manager.ErrorMsg, "服务器连接错误");
                frm_DBSettings dbsetting = new frm_DBSettings();
                dbsetting.ShowDialog();
            }
            FileStream fs = new FileStream(Application.StartupPath + "\\data\\data.bin", FileMode.OpenOrCreate);

            if (fs.Length > 0)
            {

                BinaryFormatter bf = new BinaryFormatter();

                users = bf.Deserialize(fs) as Dictionary<string, Users>;

                foreach (Users user in users.Values)
                {

                    comb_username.Items.Add(user.Username);

                }

                for (int i = 0; i < users.Count; i++)
                {

                    if (comb_username.Text.Trim() != "")
                    {

                        if (users.ContainsKey(comb_username.Text.Trim()))
                        {

                            tb_password.Text = users[comb_username.Text].Password;

                            cb_remember.Checked = true;

                        }

                    }

                }

            }

            fs.Close();

        }
         Dictionary<string, Users> users = new Dictionary<string, Users>();
        private void tb_login_Click(object sender, EventArgs e)
        {
            userbll = new UserBLL();
            if (attemptCount < 6)
            {
                _users = userbll.Login(comb_username.Text.ToLower(), tb_password.Text.Trim());
                if (_users != null)
                {

                    bLogin = true;

                   
                    FileStream fs = new FileStream(Application.StartupPath + "\\data\\data.bin", FileMode.Create);

                    BinaryFormatter bf = new BinaryFormatter();
                    if (!cb_remember.Checked)
                    {
                        _users.Password = "";
                    }
                    else
                    {
                        _users.Password = tb_password.Text;
                    }
                    if (users.ContainsKey(_users.Username))
                    {

                        users.Remove(_users.Username);

                    }
                    users.Add(_users.Username, _users);

                    bf.Serialize(fs, users);

                    fs.Close();


                }
                else
                {
                    MessageBox.Show("用户名或密码错误,您还有" + (5 - attemptCount) + "次机会尝试。", "错误");
                    tb_password.Text = "";
                    this.DialogResult = DialogResult.None;
                    lb_info.ForeColor = Color.Red;

                    lb_info.Text = "用户名或密码错误,剩余尝试次数...." + (5 - attemptCount) + "次";
                    attemptCount++;
                    if (attemptCount == 6)
                    {
                        MessageBoxEx.Show("登录尝试次数已满，程序即将关闭。", "退出程序");
                        this.DialogResult = DialogResult.Abort;
                    }

                }
            }

        }

        private void cb_remember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_autoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_autoLogin.Checked)
            {
                cb_remember.Checked = true;
            }
            else
            {
                cb_remember.Checked = false;
            }
        }

        private void comb_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Application.StartupPath+"\\data\\data.bin", FileMode.OpenOrCreate);

            if (fs.Length > 0)

            {

                BinaryFormatter bf = new BinaryFormatter();

                users = bf.Deserialize(fs) as Dictionary<string, Users>;

                for (int i = 0; i < users.Count; i++)

                {

                    if (comb_username.Text.Trim() != "")

                    {

                        if (users.ContainsKey(comb_username.Text.Trim()) && users[comb_username.Text].Password != "")

                        {

                            tb_password.Text = users[comb_username.Text].Password;

                            cb_remember.Checked = true;

                        }

                        else

                        {

                            tb_password.Text = "";

                            cb_remember.Checked = false;

                        }

                    }

                }

            }

            fs.Close();
        }

        private void comb_username_DropDown(object sender, EventArgs e)
        {
           

        }
    }
}