namespace 质监局证书管理系统
{
    partial class frm_userinfo
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
            this.components = new System.ComponentModel.Container();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lb_username = new DevComponents.DotNetBar.LabelX();
            this.tb_password1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_password2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_realname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancle = new DevComponents.DotNetBar.ButtonX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_role = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(28, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = " 用户名：";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(42, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(36, 17);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "密码：";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(20, 88);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(58, 17);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "确认密码：";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(20, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(58, 17);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "真实姓名：";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(9, 140);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(69, 17);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "角色和权限：";
            // 
            // lb_username
            // 
            this.lb_username.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_username.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_username.ForeColor = System.Drawing.Color.Black;
            this.lb_username.Location = new System.Drawing.Point(84, 33);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(75, 23);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "labelX6";
            // 
            // tb_password1
            // 
            this.tb_password1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password1.Border.Class = "TextBoxBorder";
            this.tb_password1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password1.ForeColor = System.Drawing.Color.Black;
            this.tb_password1.Location = new System.Drawing.Point(84, 58);
            this.tb_password1.Name = "tb_password1";
            this.tb_password1.PasswordChar = '*';
            this.tb_password1.Size = new System.Drawing.Size(151, 22);
            this.tb_password1.TabIndex = 6;
            this.tb_password1.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // tb_password2
            // 
            this.tb_password2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password2.Border.Class = "TextBoxBorder";
            this.tb_password2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password2.ButtonCustom.Text = "查看";
            this.tb_password2.ForeColor = System.Drawing.Color.Black;
            this.tb_password2.Location = new System.Drawing.Point(84, 85);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.PasswordChar = '*';
            this.tb_password2.Size = new System.Drawing.Size(151, 22);
            this.tb_password2.TabIndex = 7;
            this.tb_password2.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_password2.Leave += new System.EventHandler(this.tb_password2_Leave);
            // 
            // tb_realname
            // 
            this.tb_realname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_realname.Border.Class = "TextBoxBorder";
            this.tb_realname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_realname.ForeColor = System.Drawing.Color.Black;
            this.tb_realname.Location = new System.Drawing.Point(84, 112);
            this.tb_realname.Name = "tb_realname";
            this.tb_realname.Size = new System.Drawing.Size(151, 22);
            this.tb_realname.TabIndex = 8;
            this.tb_realname.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_realname.Leave += new System.EventHandler(this.tb_realname_Leave);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(148, 181);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancle.Location = new System.Drawing.Point(230, 181);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancle.TabIndex = 11;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lb_role.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_role.ForeColor = System.Drawing.Color.Black;
            this.lb_role.Location = new System.Drawing.Point(84, 138);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(38, 17);
            this.lb_role.TabIndex = 9;
            this.lb_role.Text = "labelX7";
            this.lb_role.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // frm_userinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 216);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.tb_realname);
            this.Controls.Add(this.tb_password2);
            this.Controls.Add(this.tb_password1);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_userinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.frm_userinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lb_username;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_realname;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_cancle;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.LabelX lb_role;
    }
}