﻿namespace GUI.FormQuanLy
{
    partial class FormTieuDe
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_TieuDe = new DevExpress.XtraGrid.GridControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DatTruoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_ThemDia = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiaTrenKe = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.cbx_LoaiDia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_ThemTieuDe = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.navButton5 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaTrenKe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(825, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Tiêu Đề";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 539;
            this.gridView1.GridControl = this.grd_TieuDe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // grd_TieuDe
            // 
            this.tablePanel1.SetColumn(this.grd_TieuDe, 1);
            this.grd_TieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_TieuDe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd_TieuDe.Location = new System.Drawing.Point(37, 131);
            this.grd_TieuDe.MainView = this.gridView1;
            this.grd_TieuDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd_TieuDe.Name = "grd_TieuDe";
            this.tablePanel1.SetRow(this.grd_TieuDe, 2);
            this.grd_TieuDe.Size = new System.Drawing.Size(825, 888);
            this.grd_TieuDe.TabIndex = 2;
            this.grd_TieuDe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pictureBox1
            // 
            this.tablePanel2.SetColumn(this.pictureBox1, 1);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources._109222l;
            this.pictureBox1.Location = new System.Drawing.Point(202, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel2.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(388, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DatTruoc
            // 
            this.btn_DatTruoc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatTruoc.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DatTruoc.Appearance.Options.UseFont = true;
            this.btn_DatTruoc.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btn_DatTruoc, 0);
            this.btn_DatTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DatTruoc.ImageOptions.Image = global::GUI.Properties.Resources.icons8_administrative_tools_32;
            this.btn_DatTruoc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_DatTruoc.Location = new System.Drawing.Point(4, 5);
            this.btn_DatTruoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DatTruoc.Name = "btn_DatTruoc";
            this.btn_DatTruoc.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_DatTruoc, 0);
            this.btn_DatTruoc.Size = new System.Drawing.Size(121, 105);
            this.btn_DatTruoc.TabIndex = 0;
            this.btn_DatTruoc.Text = "Đặt Trước";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btn_Xoa, 1);
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.ImageOptions.Image = global::GUI.Properties.Resources.icons8_delete_file_32;
            this.btn_Xoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Xoa.Location = new System.Drawing.Point(133, 5);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Xoa, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(121, 105);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            // 
            // tablePanel4
            // 
            this.tablePanel2.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.btn_ThemDia);
            this.tablePanel4.Controls.Add(this.btn_DatTruoc);
            this.tablePanel4.Controls.Add(this.btn_Xoa);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(202, 632);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel2.SetRow(this.tablePanel4, 4);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(388, 115);
            this.tablePanel4.TabIndex = 3;
            // 
            // btn_ThemDia
            // 
            this.btn_ThemDia.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDia.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ThemDia.Appearance.Options.UseFont = true;
            this.btn_ThemDia.Appearance.Options.UseForeColor = true;
            this.tablePanel4.SetColumn(this.btn_ThemDia, 2);
            this.btn_ThemDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ThemDia.ImageOptions.Image = global::GUI.Properties.Resources.icons8_cd_32;
            this.btn_ThemDia.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_ThemDia.Location = new System.Drawing.Point(263, 2);
            this.btn_ThemDia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_ThemDia.Name = "btn_ThemDia";
            this.btn_ThemDia.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_ThemDia, 0);
            this.btn_ThemDia.Size = new System.Drawing.Size(121, 111);
            this.btn_ThemDia.TabIndex = 1;
            this.btn_ThemDia.Text = "Thêm Đĩa";
            this.btn_ThemDia.Click += new System.EventHandler(this.btn_ThemDia_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 2);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel2.Controls.Add(this.tablePanel6);
            this.tablePanel2.Controls.Add(this.tablePanel5);
            this.tablePanel2.Controls.Add(this.tablePanel4);
            this.tablePanel2.Controls.Add(this.tablePanel3);
            this.tablePanel2.Controls.Add(this.pictureBox1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(870, 131);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 350F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F)});
            this.tablePanel2.Size = new System.Drawing.Size(792, 888);
            this.tablePanel2.TabIndex = 3;
            // 
            // tablePanel6
            // 
            this.tablePanel2.SetColumn(this.tablePanel6, 1);
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel6.Controls.Add(this.label4);
            this.tablePanel6.Controls.Add(this.txt_DiaTrenKe);
            this.tablePanel6.Location = new System.Drawing.Point(202, 506);
            this.tablePanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel2.SetRow(this.tablePanel6, 2);
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel6.Size = new System.Drawing.Size(388, 52);
            this.tablePanel6.TabIndex = 5;
            // 
            // label4
            // 
            this.tablePanel6.SetColumn(this.label4, 0);
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.tablePanel6.SetRow(this.label4, 0);
            this.label4.Size = new System.Drawing.Size(147, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "SL Trên Kệ";
            // 
            // txt_DiaTrenKe
            // 
            this.tablePanel6.SetColumn(this.txt_DiaTrenKe, 1);
            this.txt_DiaTrenKe.Location = new System.Drawing.Point(159, 11);
            this.txt_DiaTrenKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiaTrenKe.Name = "txt_DiaTrenKe";
            this.txt_DiaTrenKe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaTrenKe.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaTrenKe.Properties.NullValuePrompt = "Số lượng trên kệ";
            this.txt_DiaTrenKe.Properties.ReadOnly = true;
            this.tablePanel6.SetRow(this.txt_DiaTrenKe, 0);
            this.txt_DiaTrenKe.Size = new System.Drawing.Size(225, 30);
            this.txt_DiaTrenKe.TabIndex = 2;
            // 
            // tablePanel5
            // 
            this.tablePanel2.SetColumn(this.tablePanel5, 1);
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel5.Controls.Add(this.label3);
            this.tablePanel5.Controls.Add(this.txt_TenTieuDe);
            this.tablePanel5.Location = new System.Drawing.Point(202, 443);
            this.tablePanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel2.SetRow(this.tablePanel5, 1);
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel5.Size = new System.Drawing.Size(388, 52);
            this.tablePanel5.TabIndex = 4;
            // 
            // label3
            // 
            this.tablePanel5.SetColumn(this.label3, 0);
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.tablePanel5.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(147, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Tiêu Đề";
            // 
            // txt_TenTieuDe
            // 
            this.tablePanel5.SetColumn(this.txt_TenTieuDe, 1);
            this.txt_TenTieuDe.Location = new System.Drawing.Point(159, 11);
            this.txt_TenTieuDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenTieuDe.Name = "txt_TenTieuDe";
            this.txt_TenTieuDe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTieuDe.Properties.Appearance.Options.UseFont = true;
            this.txt_TenTieuDe.Properties.NullValuePrompt = "Tên Tiêu Đề";
            this.txt_TenTieuDe.Properties.ReadOnly = true;
            this.tablePanel5.SetRow(this.txt_TenTieuDe, 0);
            this.txt_TenTieuDe.Size = new System.Drawing.Size(225, 30);
            this.txt_TenTieuDe.TabIndex = 2;
            // 
            // tablePanel3
            // 
            this.tablePanel2.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel3.Controls.Add(this.cbx_LoaiDia);
            this.tablePanel3.Controls.Add(this.label5);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(202, 569);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel2.SetRow(this.tablePanel3, 3);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(388, 53);
            this.tablePanel3.TabIndex = 2;
            // 
            // cbx_LoaiDia
            // 
            this.tablePanel3.SetColumn(this.cbx_LoaiDia, 1);
            this.cbx_LoaiDia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LoaiDia.FormattingEnabled = true;
            this.cbx_LoaiDia.Location = new System.Drawing.Point(159, 10);
            this.cbx_LoaiDia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbx_LoaiDia.Name = "cbx_LoaiDia";
            this.tablePanel3.SetRow(this.cbx_LoaiDia, 0);
            this.cbx_LoaiDia.Size = new System.Drawing.Size(225, 32);
            this.cbx_LoaiDia.TabIndex = 4;
            // 
            // label5
            // 
            this.tablePanel3.SetColumn(this.label5, 0);
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.tablePanel3.SetRow(this.label5, 0);
            this.label5.Size = new System.Drawing.Size(147, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại Đĩa";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.grd_TieuDe);
            this.tablePanel1.Controls.Add(this.btn_ThemTieuDe);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1666, 1024);
            this.tablePanel1.TabIndex = 1;
            // 
            // btn_ThemTieuDe
            // 
            this.btn_ThemTieuDe.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTieuDe.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ThemTieuDe.Appearance.Options.UseFont = true;
            this.btn_ThemTieuDe.Appearance.Options.UseForeColor = true;
            this.btn_ThemTieuDe.AutoSize = true;
            this.tablePanel1.SetColumn(this.btn_ThemTieuDe, 1);
            this.btn_ThemTieuDe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ThemTieuDe.ImageOptions.Image = global::GUI.Properties.Resources.icons8_create_321;
            this.btn_ThemTieuDe.Location = new System.Drawing.Point(38, 69);
            this.btn_ThemTieuDe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_ThemTieuDe.Name = "btn_ThemTieuDe";
            this.btn_ThemTieuDe.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel1.SetRow(this.btn_ThemTieuDe, 1);
            this.btn_ThemTieuDe.Size = new System.Drawing.Size(206, 51);
            this.btn_ThemTieuDe.TabIndex = 1;
            this.btn_ThemTieuDe.Text = "Thêm Tiêu Đề Mới";
            // 
            // label2
            // 
            this.tablePanel1.SetColumn(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(870, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(792, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Tin Tiêu Đề";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // navButton5
            // 
            this.navButton5.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton5.Caption = "navButton5";
            this.navButton5.Name = "navButton5";
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton3.Caption = "navButton3";
            this.navButton3.Name = "navButton3";
            // 
            // navButton2
            // 
            this.navButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton2.Caption = "navButton2";
            this.navButton2.Name = "navButton2";
            // 
            // navButton4
            // 
            this.navButton4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton4.Caption = "navButton4";
            this.navButton4.Name = "navButton4";
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // FormTieuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1024);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTieuDe";
            this.Text = "FormTieuDe";
            this.Load += new System.EventHandler(this.FormTieuDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaTrenKe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_DatTruoc;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl grd_TieuDe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemTieuDe;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Navigation.NavButton navButton5;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_DiaTrenKe;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_TenTieuDe;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.ComboBox cbx_LoaiDia;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_ThemDia;
    }
}