namespace 质监局证书管理系统
{
    partial class frm_userSettings
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
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.comb_role = new DevComponents.DotNetBar.Controls.ComboTree();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.tb_password2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_realname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_id = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_edit = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.adv_realnameList = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tb_autoRealname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_newuser = new DevComponents.DotNetBar.ButtonX();
            this.btn_saveUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adv_realnameList)).BeginInit();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(625, 396);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.splitContainer1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(65, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(560, 396);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.btn_newuser);
            this.splitContainer1.Panel2.Controls.Add(this.btn_saveUser);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(560, 396);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.ForeColor = System.Drawing.Color.Black;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel1.Controls.Add(this.comb_role);
            this.splitContainer3.Panel1.Controls.Add(this.tb_password2);
            this.splitContainer3.Panel1.Controls.Add(this.tb_password);
            this.splitContainer3.Panel1.Controls.Add(this.tb_realname);
            this.splitContainer3.Panel1.Controls.Add(this.tb_username);
            this.splitContainer3.Panel1.Controls.Add(this.lb_id);
            this.splitContainer3.Panel1.Controls.Add(this.labelX6);
            this.splitContainer3.Panel1.Controls.Add(this.labelX5);
            this.splitContainer3.Panel1.Controls.Add(this.labelX4);
            this.splitContainer3.Panel1.Controls.Add(this.labelX3);
            this.splitContainer3.Panel1.Controls.Add(this.labelX2);
            this.splitContainer3.Panel1.Controls.Add(this.labelX1);
            this.splitContainer3.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer3.Panel2.Controls.Add(this.adv_realnameList);
            this.splitContainer3.Panel2.Controls.Add(this.tb_autoRealname);
            this.splitContainer3.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer3.Size = new System.Drawing.Size(560, 351);
            this.splitContainer3.SplitterDistance = 445;
            this.splitContainer3.TabIndex = 0;
            // 
            // comb_role
            // 
            this.comb_role.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.comb_role.BackgroundStyle.Class = "TextBoxBorder";
            this.comb_role.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.comb_role.ButtonDropDown.Visible = true;
            this.comb_role.Columns.Add(this.columnHeader2);
            this.comb_role.ColumnsVisible = false;
            this.comb_role.DisplayMembers = "rolename,roleValue";
            this.comb_role.ForeColor = System.Drawing.Color.Black;
            this.comb_role.GridColumnLines = false;
            this.comb_role.Location = new System.Drawing.Point(81, 170);
            this.comb_role.Name = "comb_role";
            this.comb_role.SelectedDisplayMember = "rolename";
            this.comb_role.Size = new System.Drawing.Size(188, 23);
            this.comb_role.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comb_role.TabIndex = 26;
            this.comb_role.ValueMember = "id";
            this.comb_role.SelectionChanged += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.comb_role_SelectionChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Editable = false;
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.SortingEnabled = false;
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width.Relative = 100;
            // 
            // tb_password2
            // 
            this.tb_password2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password2.Border.Class = "TextBoxBorder";
            this.tb_password2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password2.ForeColor = System.Drawing.Color.Black;
            this.tb_password2.Location = new System.Drawing.Point(81, 142);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.PasswordChar = '*';
            this.tb_password2.Size = new System.Drawing.Size(188, 22);
            this.tb_password2.TabIndex = 22;
            this.tb_password2.TextChanged += new System.EventHandler(this.tb_password2_TextChanged);
            this.tb_password2.Leave += new System.EventHandler(this.tb_password2_Leave);
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
            this.tb_password.Location = new System.Drawing.Point(81, 115);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(188, 22);
            this.tb_password.TabIndex = 21;
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
            this.tb_realname.Location = new System.Drawing.Point(81, 87);
            this.tb_realname.Name = "tb_realname";
            this.tb_realname.Size = new System.Drawing.Size(188, 22);
            this.tb_realname.TabIndex = 20;
            this.tb_realname.TextChanged += new System.EventHandler(this.tb_realname_TextChanged);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_username.Border.Class = "TextBoxBorder";
            this.tb_username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(81, 58);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(188, 22);
            this.tb_username.TabIndex = 19;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // lb_id
            // 
            // 
            // 
            // 
            this.lb_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_id.ForeColor = System.Drawing.Color.Black;
            this.lb_id.Location = new System.Drawing.Point(81, 26);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(75, 23);
            this.lb_id.TabIndex = 18;
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(43, 170);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(27, 17);
            this.labelX6.TabIndex = 17;
            this.labelX6.Text = "角色:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(19, 142);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(49, 17);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "确认密码:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(43, 119);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(27, 17);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "密码:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(19, 90);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(49, 17);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "真实姓名:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(31, 59);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(38, 17);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "用户名:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(55, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(16, 17);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "ID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_edit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 324);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(111, 27);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(3, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(49, 21);
            this.btn_edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "修改";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(58, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 21);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // adv_realnameList
            // 
            this.adv_realnameList.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.adv_realnameList.AllowDrop = true;
            this.adv_realnameList.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.adv_realnameList.BackgroundStyle.Class = "TreeBorderKey";
            this.adv_realnameList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adv_realnameList.Columns.Add(this.columnHeader1);
            this.adv_realnameList.ColumnsVisible = false;
            this.adv_realnameList.Dock = System.Windows.Forms.DockStyle.Top;
            this.adv_realnameList.ExpandWidth = 0;
            this.adv_realnameList.ForeColor = System.Drawing.Color.Black;
            this.adv_realnameList.Location = new System.Drawing.Point(0, 22);
            this.adv_realnameList.Name = "adv_realnameList";
            this.adv_realnameList.NodesConnector = this.nodeConnector1;
            this.adv_realnameList.NodeStyle = this.elementStyle1;
            this.adv_realnameList.PathSeparator = ";";
            this.adv_realnameList.Size = new System.Drawing.Size(111, 302);
            this.adv_realnameList.Styles.Add(this.elementStyle1);
            this.adv_realnameList.TabIndex = 1;
            this.adv_realnameList.Text = "advTree1";
            this.adv_realnameList.AfterNodeDeselect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.adv_realnameList_AfterNodeDeselect);
            this.adv_realnameList.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.adv_realnameList_NodeClick);
            this.adv_realnameList.Leave += new System.EventHandler(this.adv_realnameList_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "姓名";
            this.columnHeader1.Width.Relative = 100;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.Color.Black;
            // 
            // tb_autoRealname
            // 
            this.tb_autoRealname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_autoRealname.Border.Class = "TextBoxBorder";
            this.tb_autoRealname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_autoRealname.ButtonCustom.Text = "搜索";
            this.tb_autoRealname.ButtonCustom.Visible = true;
            this.tb_autoRealname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_autoRealname.ForeColor = System.Drawing.Color.Black;
            this.tb_autoRealname.Location = new System.Drawing.Point(0, 0);
            this.tb_autoRealname.Name = "tb_autoRealname";
            this.tb_autoRealname.Size = new System.Drawing.Size(111, 22);
            this.tb_autoRealname.TabIndex = 0;
            this.tb_autoRealname.WatermarkText = "姓名";
            this.tb_autoRealname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_autoRealname_KeyUp);
            // 
            // btn_newuser
            // 
            this.btn_newuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_newuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_newuser.Location = new System.Drawing.Point(287, 6);
            this.btn_newuser.Name = "btn_newuser";
            this.btn_newuser.Size = new System.Drawing.Size(75, 23);
            this.btn_newuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_newuser.TabIndex = 11;
            this.btn_newuser.Text = "新建";
            this.btn_newuser.Click += new System.EventHandler(this.btn_newuser_Click);
            // 
            // btn_saveUser
            // 
            this.btn_saveUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveUser.Enabled = false;
            this.btn_saveUser.Location = new System.Drawing.Point(368, 6);
            this.btn_saveUser.Name = "btn_saveUser";
            this.btn_saveUser.Size = new System.Drawing.Size(75, 23);
            this.btn_saveUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_saveUser.TabIndex = 10;
            this.btn_saveUser.Text = "保存";
            this.btn_saveUser.Click += new System.EventHandler(this.btn_saveUser_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Location = new System.Drawing.Point(449, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "退出";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "用户管理";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.splitContainer2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(65, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(560, 396);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer2.Size = new System.Drawing.Size(560, 396);
            this.splitContainer2.SplitterDistance = 351;
            this.splitContainer2.TabIndex = 1;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "角色管理";
            this.superTabItem2.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Near;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.superTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_userSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "权限管理";
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adv_realnameList)).EndInit();
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private DevComponents.AdvTree.AdvTree adv_realnameList;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_autoRealname;
        private DevComponents.DotNetBar.ButtonX btn_newuser;
        private DevComponents.DotNetBar.ButtonX btn_saveUser;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_realname;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_username;
        private DevComponents.DotNetBar.LabelX lb_id;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX btn_edit;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Controls.ComboTree comb_role;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;

    }
}