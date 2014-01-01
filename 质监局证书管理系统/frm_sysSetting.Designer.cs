namespace 质监局证书管理系统
{
    partial class frm_sysSetting
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
            this.comboTree1 = new DevComponents.DotNetBar.Controls.ComboTree();
            this.tb_standard2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tb_fax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_zipcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_addressEng = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_address = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_unitNameEng = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_unitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_verification = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_standard1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btn_ok = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancle = new DevComponents.DotNetBar.ButtonX();
            this.lnk_new = new System.Windows.Forms.LinkLabel();
            this.tb_setName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTree1
            // 
            this.comboTree1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.comboTree1.BackgroundStyle.Class = "TextBoxBorder";
            this.comboTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.comboTree1.ButtonCustom.Image = global::质监局证书管理系统.Properties.Resources.PivotClearAll;
            this.comboTree1.ButtonCustom.Visible = true;
            this.comboTree1.ButtonDropDown.Visible = true;
            this.comboTree1.ColumnsVisible = false;
            this.comboTree1.DisplayMembers = "name,def";
            this.comboTree1.ForeColor = System.Drawing.Color.Black;
            this.comboTree1.Location = new System.Drawing.Point(174, 12);
            this.comboTree1.Name = "comboTree1";
            this.comboTree1.SelectedDisplayMember = "name";
            this.comboTree1.Size = new System.Drawing.Size(144, 23);
            this.comboTree1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTree1.TabIndex = 0;
            this.comboTree1.ValueMember = "id";
            this.comboTree1.ButtonCustomClick += new System.EventHandler(this.comboTree1_ButtonCustomClick);
            this.comboTree1.SelectionChanged += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.comboTree1_SelectionChanged);
            this.comboTree1.SelectedIndexChanged += new System.EventHandler(this.comboTree1_SelectedIndexChanged);
            // 
            // tb_standard2
            // 
            this.tb_standard2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_standard2.Border.Class = "TextBoxBorder";
            this.tb_standard2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_standard2.ForeColor = System.Drawing.Color.Black;
            this.tb_standard2.Location = new System.Drawing.Point(175, 99);
            this.tb_standard2.Name = "tb_standard2";
            this.tb_standard2.Size = new System.Drawing.Size(372, 22);
            this.tb_standard2.TabIndex = 45;
            this.tb_standard2.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_standard2.Leave += new System.EventHandler(this.tb_standard2_Leave);
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(22, 100);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(133, 22);
            this.labelX12.TabIndex = 44;
            this.labelX12.Text = "社会公用计量标准证书号:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX12.WordWrap = true;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(329, 243);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(57, 23);
            this.labelX11.TabIndex = 40;
            this.labelX11.Text = "电子邮箱:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(329, 273);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(57, 23);
            this.labelX10.TabIndex = 36;
            this.labelX10.Text = "传真:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(23, 273);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(133, 23);
            this.labelX9.TabIndex = 35;
            this.labelX9.Text = "电话:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(23, 244);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(133, 23);
            this.labelX8.TabIndex = 34;
            this.labelX8.Text = "邮政编码:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(23, 215);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(133, 23);
            this.labelX7.TabIndex = 33;
            this.labelX7.Text = "发证单位地址(英文):";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(23, 186);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(133, 23);
            this.labelX6.TabIndex = 32;
            this.labelX6.Text = "发证单位地址(中文):";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(23, 157);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(133, 23);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "发证单位名称(英文):";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(23, 128);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(133, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "发证单位名称(中文):";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(23, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(133, 23);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "授权证书号:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(22, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(134, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "计量标准考核证书号:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_fax
            // 
            this.tb_fax.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_fax.Border.Class = "TextBoxBorder";
            this.tb_fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_fax.ForeColor = System.Drawing.Color.Black;
            this.tb_fax.Location = new System.Drawing.Point(392, 273);
            this.tb_fax.Name = "tb_fax";
            this.tb_fax.Size = new System.Drawing.Size(154, 22);
            this.tb_fax.TabIndex = 43;
            this.tb_fax.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_fax.Leave += new System.EventHandler(this.tb_fax_Leave);
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_tel.Border.Class = "TextBoxBorder";
            this.tb_tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_tel.ForeColor = System.Drawing.Color.Black;
            this.tb_tel.Location = new System.Drawing.Point(174, 273);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(149, 22);
            this.tb_tel.TabIndex = 42;
            this.tb_tel.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_tel.Leave += new System.EventHandler(this.tb_tel_Leave);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_email.Border.Class = "TextBoxBorder";
            this.tb_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_email.ForeColor = System.Drawing.Color.Black;
            this.tb_email.Location = new System.Drawing.Point(392, 243);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(154, 22);
            this.tb_email.TabIndex = 41;
            this.tb_email.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // tb_zipcode
            // 
            this.tb_zipcode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_zipcode.Border.Class = "TextBoxBorder";
            this.tb_zipcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_zipcode.ForeColor = System.Drawing.Color.Black;
            this.tb_zipcode.Location = new System.Drawing.Point(174, 244);
            this.tb_zipcode.Name = "tb_zipcode";
            this.tb_zipcode.Size = new System.Drawing.Size(149, 22);
            this.tb_zipcode.TabIndex = 39;
            this.tb_zipcode.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_zipcode.Leave += new System.EventHandler(this.tb_zipcode_Leave);
            // 
            // tb_addressEng
            // 
            this.tb_addressEng.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_addressEng.Border.Class = "TextBoxBorder";
            this.tb_addressEng.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_addressEng.ForeColor = System.Drawing.Color.Black;
            this.tb_addressEng.Location = new System.Drawing.Point(174, 216);
            this.tb_addressEng.Name = "tb_addressEng";
            this.tb_addressEng.Size = new System.Drawing.Size(372, 22);
            this.tb_addressEng.TabIndex = 38;
            this.tb_addressEng.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_address.Border.Class = "TextBoxBorder";
            this.tb_address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_address.ForeColor = System.Drawing.Color.Black;
            this.tb_address.Location = new System.Drawing.Point(174, 187);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(372, 22);
            this.tb_address.TabIndex = 37;
            this.tb_address.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_address.Leave += new System.EventHandler(this.tb_address_Leave);
            // 
            // tb_unitNameEng
            // 
            this.tb_unitNameEng.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_unitNameEng.Border.Class = "TextBoxBorder";
            this.tb_unitNameEng.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_unitNameEng.ForeColor = System.Drawing.Color.Black;
            this.tb_unitNameEng.Location = new System.Drawing.Point(175, 158);
            this.tb_unitNameEng.Name = "tb_unitNameEng";
            this.tb_unitNameEng.Size = new System.Drawing.Size(372, 22);
            this.tb_unitNameEng.TabIndex = 31;
            this.tb_unitNameEng.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // tb_unitName
            // 
            this.tb_unitName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_unitName.Border.Class = "TextBoxBorder";
            this.tb_unitName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_unitName.ForeColor = System.Drawing.Color.Black;
            this.tb_unitName.Location = new System.Drawing.Point(175, 128);
            this.tb_unitName.Name = "tb_unitName";
            this.tb_unitName.Size = new System.Drawing.Size(372, 22);
            this.tb_unitName.TabIndex = 30;
            this.tb_unitName.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_unitName.Leave += new System.EventHandler(this.tb_unitName_Leave);
            // 
            // tb_verification
            // 
            this.tb_verification.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_verification.Border.Class = "TextBoxBorder";
            this.tb_verification.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_verification.ForeColor = System.Drawing.Color.Black;
            this.tb_verification.Location = new System.Drawing.Point(175, 71);
            this.tb_verification.Name = "tb_verification";
            this.tb_verification.Size = new System.Drawing.Size(372, 22);
            this.tb_verification.TabIndex = 27;
            this.tb_verification.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_verification.Leave += new System.EventHandler(this.tb_verification_Leave);
            // 
            // tb_standard1
            // 
            this.tb_standard1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_standard1.Border.Class = "TextBoxBorder";
            this.tb_standard1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_standard1.ForeColor = System.Drawing.Color.Black;
            this.tb_standard1.Location = new System.Drawing.Point(175, 41);
            this.tb_standard1.Name = "tb_standard1";
            this.tb_standard1.Size = new System.Drawing.Size(372, 22);
            this.tb_standard1.TabIndex = 25;
            this.tb_standard1.TextChanged += new System.EventHandler(this.Form_TextChanged);
            this.tb_standard1.Leave += new System.EventHandler(this.tb_standard1_Leave);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(23, 12);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(134, 23);
            this.labelX5.TabIndex = 46;
            this.labelX5.Text = "当前设定:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btn_ok
            // 
            this.btn_ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ok.Location = new System.Drawing.Point(452, 361);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ok.TabIndex = 48;
            this.btn_ok.Text = "确定";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancle.Location = new System.Drawing.Point(534, 361);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancle.TabIndex = 49;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // lnk_new
            // 
            this.lnk_new.AutoSize = true;
            this.lnk_new.BackColor = System.Drawing.Color.White;
            this.lnk_new.ForeColor = System.Drawing.Color.Black;
            this.lnk_new.Location = new System.Drawing.Point(326, 17);
            this.lnk_new.Name = "lnk_new";
            this.lnk_new.Size = new System.Drawing.Size(55, 13);
            this.lnk_new.TabIndex = 50;
            this.lnk_new.TabStop = true;
            this.lnk_new.Text = "新建设定";
            this.lnk_new.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_new_LinkClicked);
            this.lnk_new.MouseHover += new System.EventHandler(this.lnk_new_MouseHover);
            // 
            // tb_setName
            // 
            this.tb_setName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_setName.Border.Class = "TextBoxBorder";
            this.tb_setName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_setName.ForeColor = System.Drawing.Color.Black;
            this.tb_setName.Location = new System.Drawing.Point(175, 12);
            this.tb_setName.Name = "tb_setName";
            this.tb_setName.Size = new System.Drawing.Size(151, 22);
            this.tb_setName.TabIndex = 51;
            this.tb_setName.Visible = false;
            this.tb_setName.Leave += new System.EventHandler(this.tb_setName_Leave);
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_sysSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.lnk_new);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tb_standard2);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tb_fax);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_zipcode);
            this.Controls.Add(this.tb_addressEng);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_unitNameEng);
            this.Controls.Add(this.tb_unitName);
            this.Controls.Add(this.tb_verification);
            this.Controls.Add(this.tb_standard1);
            this.Controls.Add(this.comboTree1);
            this.Controls.Add(this.tb_setName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_sysSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统全局设定";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboTree comboTree1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_standard2;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_fax;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_tel;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_email;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_zipcode;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_addressEng;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_address;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_unitNameEng;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_unitName;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_verification;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_standard1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btn_ok;
        private DevComponents.DotNetBar.ButtonX btn_cancle;
        private System.Windows.Forms.LinkLabel lnk_new;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_setName;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}