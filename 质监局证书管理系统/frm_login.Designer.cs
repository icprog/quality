namespace 质监局证书管理系统
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_login = new DevComponents.DotNetBar.ButtonX();
            this.comb_username = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_remember = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb_autoLogin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lb_info = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tb_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tb_login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tb_login.Location = new System.Drawing.Point(151, 142);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(213, 36);
            this.tb_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tb_login.TabIndex = 0;
            this.tb_login.Text = "登录";
            this.tb_login.Click += new System.EventHandler(this.tb_login_Click);
            // 
            // comb_username
            // 
            this.comb_username.DisplayMember = "Text";
            this.comb_username.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comb_username.ForeColor = System.Drawing.Color.Black;
            this.comb_username.FormattingEnabled = true;
            this.comb_username.ItemHeight = 16;
            this.comb_username.Location = new System.Drawing.Point(151, 49);
            this.comb_username.Name = "comb_username";
            this.comb_username.Size = new System.Drawing.Size(213, 22);
            this.comb_username.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comb_username.TabIndex = 1;
            this.comb_username.WatermarkText = "用户名";
            this.comb_username.DropDown += new System.EventHandler(this.comb_username_DropDown);
            this.comb_username.SelectedIndexChanged += new System.EventHandler(this.comb_username_SelectedIndexChanged);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password.Border.Class = "TextBoxBorder";
            this.tb_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(151, 85);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(213, 22);
            this.tb_password.TabIndex = 2;
            this.tb_password.WatermarkText = "密码";
            // 
            // cb_remember
            // 
            this.cb_remember.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cb_remember.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_remember.ForeColor = System.Drawing.Color.Black;
            this.cb_remember.Location = new System.Drawing.Point(151, 113);
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.Size = new System.Drawing.Size(100, 23);
            this.cb_remember.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_remember.TabIndex = 3;
            this.cb_remember.Text = "记住密码";
            this.cb_remember.CheckedChanged += new System.EventHandler(this.cb_remember_CheckedChanged);
            // 
            // cb_autoLogin
            // 
            this.cb_autoLogin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cb_autoLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_autoLogin.ForeColor = System.Drawing.Color.Black;
            this.cb_autoLogin.Location = new System.Drawing.Point(258, 113);
            this.cb_autoLogin.Name = "cb_autoLogin";
            this.cb_autoLogin.Size = new System.Drawing.Size(100, 23);
            this.cb_autoLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_autoLogin.TabIndex = 4;
            this.cb_autoLogin.Text = "自动登录";
            this.cb_autoLogin.Visible = false;
            this.cb_autoLogin.CheckedChanged += new System.EventHandler(this.cb_autoLogin_CheckedChanged);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_info.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_info.ForeColor = System.Drawing.Color.Black;
            this.lb_info.Location = new System.Drawing.Point(151, 189);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 0);
            this.lb_info.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::质监局证书管理系统.Properties.Resources.quality副本;
            this.pictureBox1.Location = new System.Drawing.Point(17, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 214);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.cb_autoLogin);
            this.Controls.Add(this.cb_remember);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.comb_username);
            this.Controls.Add(this.tb_login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX tb_login;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comb_username;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_remember;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_autoLogin;
        private DevComponents.DotNetBar.LabelX lb_info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}