namespace 质监局证书管理系统
{
    partial class frm_DBSettings
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
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ip_serverip = new DevComponents.Editors.IpAddressInput();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.int_port = new DevComponents.Editors.IntegerInput();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.ip_serverip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_port)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 173);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(316, 22);
            this.metroStatusBar1.TabIndex = 5;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "尚未连接";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX3.Location = new System.Drawing.Point(212, 123);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(89, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 13;
            this.buttonX3.Text = "退出";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonX2.Location = new System.Drawing.Point(117, 123);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(89, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 12;
            this.buttonX2.Text = "确定";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(22, 123);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(89, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 11;
            this.buttonX1.Text = "测试";
            // 
            // ip_serverip
            // 
            this.ip_serverip.AutoOverwrite = true;
            this.ip_serverip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ip_serverip.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ip_serverip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ip_serverip.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ip_serverip.ButtonFreeText.Visible = true;
            this.ip_serverip.ForeColor = System.Drawing.Color.Black;
            this.ip_serverip.Location = new System.Drawing.Point(21, 36);
            this.ip_serverip.Name = "ip_serverip";
            this.ip_serverip.Size = new System.Drawing.Size(194, 22);
            this.ip_serverip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ip_serverip.TabIndex = 7;
            this.ip_serverip.WatermarkText = "服务器IP";
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(21, 94);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(280, 22);
            this.textBoxX2.TabIndex = 10;
            this.textBoxX2.WatermarkText = "密码";
            // 
            // int_port
            // 
            this.int_port.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.int_port.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_port.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_port.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_port.ForeColor = System.Drawing.Color.Black;
            this.int_port.Location = new System.Drawing.Point(221, 36);
            this.int_port.Name = "int_port";
            this.int_port.Size = new System.Drawing.Size(80, 22);
            this.int_port.TabIndex = 8;
            this.int_port.WatermarkText = "端口号";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(21, 65);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(280, 22);
            this.textBoxX1.TabIndex = 9;
            this.textBoxX1.WatermarkText = "数据库用户名";
            // 
            // frm_DBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 195);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.ip_serverip);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.int_port);
            this.Controls.Add(this.textBoxX2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_DBSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DBSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ip_serverip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.Editors.IpAddressInput ip_serverip;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.Editors.IntegerInput int_port;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;

    }
}