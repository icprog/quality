namespace 质监局证书管理系统
{
    partial class frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroToolbar1 = new DevComponents.DotNetBar.Metro.MetroToolbar();
            this.btn_tool_download = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btn_tool_New = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.btn_tool_delete = new DevComponents.DotNetBar.ButtonItem();
            this.btn_tool_preview = new DevComponents.DotNetBar.ButtonItem();
            this.btn_tool_print = new DevComponents.DotNetBar.ButtonItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.advTree_licenseList = new DevComponents.AdvTree.AdvTree();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroAppButton1 = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.btn_newLicense = new DevComponents.DotNetBar.ButtonItem();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.columnHeader4 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader5 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader6 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader7 = new DevComponents.AdvTree.ColumnHeader();
            this.metroShell1.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree_licenseList)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 637);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(959, 22);
            this.metroStatusBar1.TabIndex = 4;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.CausesValidation = false;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = "帮助";
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroAppButton1,
            this.metroTabItem1,
            this.metroTabItem2});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(0, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.metroShell1.SettingsButtonText = "设置";
            this.metroShell1.Size = new System.Drawing.Size(959, 636);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 2;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            this.metroShell1.SettingsButtonClick += new System.EventHandler(this.metroShell1_SettingsButtonClick);
            this.metroShell1.SizeChanged += new System.EventHandler(this.metroShell1_SizeChanged);
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.metroToolbar1);
            this.metroTabPanel1.Controls.Add(this.webBrowser1);
            this.metroTabPanel1.Controls.Add(this.expandableSplitter1);
            this.metroTabPanel1.Controls.Add(this.advTree_licenseList);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(16, 3, 16, 40);
            this.metroTabPanel1.Size = new System.Drawing.Size(959, 585);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            this.metroTabPanel1.Visible = false;
            // 
            // metroToolbar1
            // 
            this.metroToolbar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroToolbar1.ContainerControlProcessDialogKey = true;
            this.metroToolbar1.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top;
            this.metroToolbar1.ExtraItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_tool_download,
            this.buttonItem2});
            this.metroToolbar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroToolbar1.ForeColor = System.Drawing.Color.Black;
            this.metroToolbar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_tool_New,
            this.buttonItem7,
            this.btn_tool_delete,
            this.btn_tool_preview,
            this.btn_tool_print});
            this.metroToolbar1.ItemSpacing = 20;
            this.metroToolbar1.Location = new System.Drawing.Point(279, 541);
            this.metroToolbar1.Name = "metroToolbar1";
            this.metroToolbar1.Size = new System.Drawing.Size(319, 38);
            this.metroToolbar1.TabIndex = 4;
            this.metroToolbar1.Text = "metroToolbar1";
            this.metroToolbar1.MouseEnter += new System.EventHandler(this.metroToolbar1_MouseHover);
            // 
            // btn_tool_download
            // 
            this.btn_tool_download.Image = global::质监局证书管理系统.Properties.Resources.icon_download;
            this.btn_tool_download.Name = "btn_tool_download";
            this.btn_tool_download.Text = "buttonItem6";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "buttonItem2";
            // 
            // btn_tool_New
            // 
            this.btn_tool_New.HoverImage = global::质监局证书管理系统.Properties.Resources.icon_plus;
            this.btn_tool_New.Image = global::质监局证书管理系统.Properties.Resources.icon_plus_alt;
            this.btn_tool_New.Name = "btn_tool_New";
            this.btn_tool_New.Text = "buttonItem2";
            this.btn_tool_New.Tooltip = "新建证书";
            // 
            // buttonItem7
            // 
            this.buttonItem7.Image = global::质监局证书管理系统.Properties.Resources.icon_pencil_edit;
            this.buttonItem7.ImageAlt = global::质监局证书管理系统.Properties.Resources.icon_pencil_edit_alt;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.Text = "buttonItem7";
            this.buttonItem7.Tooltip = "修改证书";
            // 
            // btn_tool_delete
            // 
            this.btn_tool_delete.HoverImage = global::质监局证书管理系统.Properties.Resources.icon_trash_alt;
            this.btn_tool_delete.Image = global::质监局证书管理系统.Properties.Resources.icon_trash;
            this.btn_tool_delete.Name = "btn_tool_delete";
            this.btn_tool_delete.Text = "buttonItem4";
            this.btn_tool_delete.Tooltip = "删除证书";
            // 
            // btn_tool_preview
            // 
            this.btn_tool_preview.HoverImage = global::质监局证书管理系统.Properties.Resources.icon_search;
            this.btn_tool_preview.Image = global::质监局证书管理系统.Properties.Resources.icon_search_alt;
            this.btn_tool_preview.Name = "btn_tool_preview";
            this.btn_tool_preview.Text = "buttonItem3";
            this.btn_tool_preview.Tooltip = "预览";
            // 
            // btn_tool_print
            // 
            this.btn_tool_print.HoverImage = global::质监局证书管理系统.Properties.Resources.icon_printer;
            this.btn_tool_print.Image = global::质监局证书管理系统.Properties.Resources.icon_printer_alt;
            this.btn_tool_print.Name = "btn_tool_print";
            this.btn_tool_print.Text = "buttonItem5";
            this.btn_tool_print.Tooltip = "打印";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(16, 223);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(927, 322);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.Empty;
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.Empty;
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.White;
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.Empty;
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.Empty;
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.Empty;
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.White;
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(16, 217);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(927, 6);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 5;
            this.expandableSplitter1.TabStop = false;
            // 
            // advTree_licenseList
            // 
            this.advTree_licenseList.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree_licenseList.AllowDrop = true;
            this.advTree_licenseList.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.advTree_licenseList.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree_licenseList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree_licenseList.Columns.Add(this.columnHeader2);
            this.advTree_licenseList.Columns.Add(this.columnHeader3);
            this.advTree_licenseList.Columns.Add(this.columnHeader4);
            this.advTree_licenseList.Columns.Add(this.columnHeader6);
            this.advTree_licenseList.Columns.Add(this.columnHeader7);
            this.advTree_licenseList.Columns.Add(this.columnHeader5);
            this.advTree_licenseList.Columns.Add(this.columnHeader1);
            this.advTree_licenseList.Dock = System.Windows.Forms.DockStyle.Top;
            this.advTree_licenseList.ExpandWidth = 0;
            this.advTree_licenseList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.advTree_licenseList.ForeColor = System.Drawing.Color.Black;
            this.advTree_licenseList.GridColumnLines = false;
            this.advTree_licenseList.Indent = 0;
            this.advTree_licenseList.Location = new System.Drawing.Point(16, 3);
            this.advTree_licenseList.Margin = new System.Windows.Forms.Padding(10);
            this.advTree_licenseList.Name = "advTree_licenseList";
            this.advTree_licenseList.NodesConnector = this.nodeConnector1;
            this.advTree_licenseList.NodeStyle = this.elementStyle1;
            this.advTree_licenseList.PathSeparator = ";";
            this.advTree_licenseList.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.advTree_licenseList.Size = new System.Drawing.Size(927, 214);
            this.advTree_licenseList.Styles.Add(this.elementStyle1);
            this.advTree_licenseList.TabIndex = 0;
            this.advTree_licenseList.Text = "advTree1";
            this.advTree_licenseList.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree_licenseList_AfterNodeSelect);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "证书编号";
            this.columnHeader2.Width.Relative = 10;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "受检/委托方";
            this.columnHeader3.Width.Relative = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.MinimumWidth = 70;
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "日期";
            this.columnHeader1.Width.Relative = 10;
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
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(959, 607);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            // 
            // metroAppButton1
            // 
            this.metroAppButton1.AutoExpandOnClick = true;
            this.metroAppButton1.CanCustomize = false;
            this.metroAppButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.metroAppButton1.ImagePaddingHorizontal = 0;
            this.metroAppButton1.ImagePaddingVertical = 0;
            this.metroAppButton1.Name = "metroAppButton1";
            this.metroAppButton1.ShowSubItems = false;
            this.metroAppButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_newLicense});
            this.metroAppButton1.Text = "&File";
            this.metroAppButton1.Click += new System.EventHandler(this.metroAppButton1_Click);
            // 
            // btn_newLicense
            // 
            this.btn_newLicense.Image = ((System.Drawing.Image)(resources.GetObject("btn_newLicense.Image")));
            this.btn_newLicense.Name = "btn_newLicense";
            this.btn_newLicense.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btn_newLicense.Text = "新建证书";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Checked = true;
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&证书";
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&VIEW";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.BeginGroup = true;
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "计量器具名称";
            this.columnHeader4.Width.Relative = 10;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "登陆者";
            this.columnHeader5.Width.Relative = 10;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "型号规格";
            this.columnHeader6.Width.Relative = 10;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.Text = "编号";
            this.columnHeader7.Width.Relative = 10;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.metroStatusBar1);
            this.Name = "frm_main";
            this.Text = "Form1";
            this.MaximumSizeChanged += new System.EventHandler(this.frm_main_MaximumSizeChanged);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree_licenseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroAppButton metroAppButton1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.AdvTree.AdvTree advTree_licenseList;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ButtonItem btn_newLicense;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.Metro.MetroToolbar metroToolbar1;
        private DevComponents.DotNetBar.ButtonItem btn_tool_download;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btn_tool_New;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.ButtonItem btn_tool_delete;
        private DevComponents.DotNetBar.ButtonItem btn_tool_preview;
        private DevComponents.DotNetBar.ButtonItem btn_tool_print;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.AdvTree.ColumnHeader columnHeader4;
        private DevComponents.AdvTree.ColumnHeader columnHeader6;
        private DevComponents.AdvTree.ColumnHeader columnHeader7;
        private DevComponents.AdvTree.ColumnHeader columnHeader5;
    }
}

