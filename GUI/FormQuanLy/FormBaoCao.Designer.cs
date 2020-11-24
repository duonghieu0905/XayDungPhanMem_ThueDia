namespace GUI.FormQuanLy
{
    partial class FormBaoCao
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.btn_ThongKeKhachHang = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_BaoCaoTieuDe = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_ThongKe = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_ThongKeKH = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_ThongKeKH = new System.Windows.Forms.ComboBox();
            this.grd_ThongKeKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_ThongKeTieuDe = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_BaoCaoTieuDe = new System.Windows.Forms.ComboBox();
            this.grd_BaoCaoTieuDe = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.grd_ThongKe = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ccThongKe = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ThongKeKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCaoTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tileBar.MaxId = 4;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 135);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 135);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 14, 34, 14);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.btn_ThongKeKhachHang;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1163, 135);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.btn_ThongKeKhachHang);
            this.tileBarGroupTables.Items.Add(this.btn_BaoCaoTieuDe);
            this.tileBarGroupTables.Items.Add(this.btn_ThongKe);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // btn_ThongKeKhachHang
            // 
            this.btn_ThongKeKhachHang.AppearanceItem.Normal.BackColor = System.Drawing.Color.Silver;
            this.btn_ThongKeKhachHang.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DarkGoldenrod;
            this.btn_ThongKeKhachHang.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_ThongKeKhachHang.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement1.ImageOptions.ImageUri.Uri = "EditWrapPoints;Size32x32;GrayScaled";
            tileItemElement1.Text = "Thống Kê Khách Hàng";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.btn_ThongKeKhachHang.Elements.Add(tileItemElement1);
            this.btn_ThongKeKhachHang.Name = "btn_ThongKeKhachHang";
            // 
            // btn_BaoCaoTieuDe
            // 
            this.btn_BaoCaoTieuDe.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.btn_BaoCaoTieuDe.AppearanceItem.Normal.BackColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_BaoCaoTieuDe.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_BaoCaoTieuDe.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement2.ImageOptions.ImageUri.Uri = "Paste;Size32x32;GrayScaled";
            tileItemElement2.Text = "Báo Cáo Tiêu Đề";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.btn_BaoCaoTieuDe.Elements.Add(tileItemElement2);
            this.btn_BaoCaoTieuDe.Id = 2;
            this.btn_BaoCaoTieuDe.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_BaoCaoTieuDe.Name = "btn_BaoCaoTieuDe";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.AppearanceItem.Normal.BackColor = System.Drawing.Color.Silver;
            this.btn_ThongKe.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Navy;
            this.btn_ThongKe.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btn_ThongKe.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement3.ImageOptions.ImageUri.Uri = "Chart";
            tileItemElement3.Text = "Thống Kê";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.btn_ThongKe.Elements.Add(tileItemElement3);
            this.btn_ThongKe.Id = 3;
            this.btn_ThongKe.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_ThongKe.Name = "btn_ThongKe";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 135);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage,
            this.navigationPage1});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1163, 570);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.tablePanel1);
            this.employeesNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(1357, 702);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.grd_ThongKeKhachHang);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1357, 702);
            this.tablePanel1.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 65F)});
            this.tablePanel2.Controls.Add(this.btn_ThongKeKH);
            this.tablePanel2.Controls.Add(this.cbx_ThongKeKH);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 2);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1351, 45);
            this.tablePanel2.TabIndex = 1;
            // 
            // btn_ThongKeKH
            // 
            this.btn_ThongKeKH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeKH.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btn_ThongKeKH.Appearance.Options.UseFont = true;
            this.btn_ThongKeKH.Appearance.Options.UseForeColor = true;
            this.btn_ThongKeKH.AutoSize = true;
            this.tablePanel2.SetColumn(this.btn_ThongKeKH, 1);
            this.btn_ThongKeKH.ImageOptions.Image = global::GUI.Properties.Resources.icons8_print_32;
            this.btn_ThongKeKH.Location = new System.Drawing.Point(476, 4);
            this.btn_ThongKeKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongKeKH.Name = "btn_ThongKeKH";
            this.btn_ThongKeKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel2.SetRow(this.btn_ThongKeKH, 0);
            this.btn_ThongKeKH.Size = new System.Drawing.Size(182, 36);
            this.btn_ThongKeKH.TabIndex = 1;
            this.btn_ThongKeKH.Text = "In Thống Kê Khách Hàng";
            // 
            // cbx_ThongKeKH
            // 
            this.tablePanel2.SetColumn(this.cbx_ThongKeKH, 0);
            this.cbx_ThongKeKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_ThongKeKH.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ThongKeKH.FormattingEnabled = true;
            this.cbx_ThongKeKH.Location = new System.Drawing.Point(3, 2);
            this.cbx_ThongKeKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_ThongKeKH.Name = "cbx_ThongKeKH";
            this.tablePanel2.SetRow(this.cbx_ThongKeKH, 0);
            this.cbx_ThongKeKH.Size = new System.Drawing.Size(467, 31);
            this.cbx_ThongKeKH.TabIndex = 0;
            // 
            // grd_ThongKeKhachHang
            // 
            this.tablePanel1.SetColumn(this.grd_ThongKeKhachHang, 0);
            this.grd_ThongKeKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ThongKeKhachHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_ThongKeKhachHang.Location = new System.Drawing.Point(3, 51);
            this.grd_ThongKeKhachHang.MainView = this.gridView1;
            this.grd_ThongKeKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_ThongKeKhachHang.Name = "grd_ThongKeKhachHang";
            this.tablePanel1.SetRow(this.grd_ThongKeKhachHang, 1);
            this.grd_ThongKeKhachHang.Size = new System.Drawing.Size(1351, 649);
            this.grd_ThongKeKhachHang.TabIndex = 0;
            this.grd_ThongKeKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_ThongKeKhachHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.tablePanel3);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(1357, 702);
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel3.Controls.Add(this.tablePanel4);
            this.tablePanel3.Controls.Add(this.grd_BaoCaoTieuDe);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(1357, 702);
            this.tablePanel3.TabIndex = 1;
            // 
            // tablePanel4
            // 
            this.tablePanel3.SetColumn(this.tablePanel4, 0);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 65F)});
            this.tablePanel4.Controls.Add(this.btn_ThongKeTieuDe);
            this.tablePanel4.Controls.Add(this.cbx_BaoCaoTieuDe);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(3, 2);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel3.SetRow(this.tablePanel4, 0);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(1351, 46);
            this.tablePanel4.TabIndex = 1;
            // 
            // btn_ThongKeTieuDe
            // 
            this.btn_ThongKeTieuDe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeTieuDe.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ThongKeTieuDe.Appearance.Options.UseFont = true;
            this.btn_ThongKeTieuDe.Appearance.Options.UseForeColor = true;
            this.btn_ThongKeTieuDe.AutoSize = true;
            this.tablePanel4.SetColumn(this.btn_ThongKeTieuDe, 1);
            this.btn_ThongKeTieuDe.ImageOptions.Image = global::GUI.Properties.Resources.icons8_print_32;
            this.btn_ThongKeTieuDe.Location = new System.Drawing.Point(476, 5);
            this.btn_ThongKeTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongKeTieuDe.Name = "btn_ThongKeTieuDe";
            this.btn_ThongKeTieuDe.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_ThongKeTieuDe, 0);
            this.btn_ThongKeTieuDe.Size = new System.Drawing.Size(160, 36);
            this.btn_ThongKeTieuDe.TabIndex = 1;
            this.btn_ThongKeTieuDe.Text = "In Thống Kê Tiêu Đề";
            // 
            // cbx_BaoCaoTieuDe
            // 
            this.tablePanel4.SetColumn(this.cbx_BaoCaoTieuDe, 0);
            this.cbx_BaoCaoTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_BaoCaoTieuDe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_BaoCaoTieuDe.FormattingEnabled = true;
            this.cbx_BaoCaoTieuDe.Location = new System.Drawing.Point(3, 2);
            this.cbx_BaoCaoTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_BaoCaoTieuDe.Name = "cbx_BaoCaoTieuDe";
            this.tablePanel4.SetRow(this.cbx_BaoCaoTieuDe, 0);
            this.cbx_BaoCaoTieuDe.Size = new System.Drawing.Size(467, 31);
            this.cbx_BaoCaoTieuDe.TabIndex = 0;
            // 
            // grd_BaoCaoTieuDe
            // 
            this.tablePanel3.SetColumn(this.grd_BaoCaoTieuDe, 0);
            this.grd_BaoCaoTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_BaoCaoTieuDe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_BaoCaoTieuDe.Location = new System.Drawing.Point(3, 52);
            this.grd_BaoCaoTieuDe.MainView = this.gridView2;
            this.grd_BaoCaoTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_BaoCaoTieuDe.Name = "grd_BaoCaoTieuDe";
            this.tablePanel3.SetRow(this.grd_BaoCaoTieuDe, 1);
            this.grd_BaoCaoTieuDe.Size = new System.Drawing.Size(1351, 648);
            this.grd_BaoCaoTieuDe.TabIndex = 0;
            this.grd_BaoCaoTieuDe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grd_BaoCaoTieuDe;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.tablePanel5);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1357, 702);
            // 
            // tablePanel5
            // 
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F)});
            this.tablePanel5.Controls.Add(this.grd_ThongKe);
            this.tablePanel5.Controls.Add(this.ccThongKe);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(0, 0);
            this.tablePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel5.Size = new System.Drawing.Size(1357, 702);
            this.tablePanel5.TabIndex = 0;
            // 
            // grd_ThongKe
            // 
            this.tablePanel5.SetColumn(this.grd_ThongKe, 1);
            this.grd_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_ThongKe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_ThongKe.Location = new System.Drawing.Point(817, 2);
            this.grd_ThongKe.MainView = this.gridView3;
            this.grd_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_ThongKe.Name = "grd_ThongKe";
            this.tablePanel5.SetRow(this.grd_ThongKe, 0);
            this.grd_ThongKe.Size = new System.Drawing.Size(537, 698);
            this.grd_ThongKe.TabIndex = 2;
            this.grd_ThongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grd_ThongKe;
            this.gridView3.Name = "gridView3";
            // 
            // ccThongKe
            // 
            this.tablePanel5.SetColumn(this.ccThongKe, 0);
            this.ccThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccThongKe.Legend.Name = "Default Legend";
            this.ccThongKe.Location = new System.Drawing.Point(3, 4);
            this.ccThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccThongKe.Name = "ccThongKe";
            this.tablePanel5.SetRow(this.ccThongKe, 0);
            series1.Name = "Series 1";
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.View = pieSeriesView1;
            this.ccThongKe.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ccThongKe.Size = new System.Drawing.Size(808, 694);
            this.ccThongKe.TabIndex = 1;
            // 
            // FormBaoCao
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 705);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ThongKeKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BaoCaoTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_ThongKeKhachHang;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_BaoCaoTieuDe;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_ThongKe;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton btn_ThongKeKH;
        private System.Windows.Forms.ComboBox cbx_ThongKeKH;
        private DevExpress.XtraGrid.GridControl grd_ThongKeKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_ThongKeTieuDe;
        private System.Windows.Forms.ComboBox cbx_BaoCaoTieuDe;
        private DevExpress.XtraGrid.GridControl grd_BaoCaoTieuDe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private DevExpress.XtraGrid.GridControl grd_ThongKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraCharts.ChartControl ccThongKe;
    }
}