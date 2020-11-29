namespace GUI.FormChucNang
{
    partial class FormDanhSachDatTruoc
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdc_DanhSach = new DevExpress.XtraGrid.GridControl();
            this.contextMenuDS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHuyDatTruoc = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdc_ChiTiet = new DevExpress.XtraGrid.GridControl();
            this.contextMenuCT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHuyMucDatTruoc = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdc_DanhSach)).BeginInit();
            this.contextMenuDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdc_ChiTiet)).BeginInit();
            this.contextMenuCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.groupBox2);
            this.tablePanel1.Controls.Add(this.groupBox1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(900, 534);
            this.tablePanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.tablePanel1.SetColumn(this.groupBox2, 0);
            this.groupBox2.Controls.Add(this.grdc_DanhSach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.tablePanel1.SetRow(this.groupBox2, 0);
            this.groupBox2.Size = new System.Drawing.Size(444, 528);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Đặt Trước";
            // 
            // grdc_DanhSach
            // 
            this.grdc_DanhSach.ContextMenuStrip = this.contextMenuDS;
            this.grdc_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdc_DanhSach.Location = new System.Drawing.Point(3, 23);
            this.grdc_DanhSach.MainView = this.gridView1;
            this.grdc_DanhSach.Name = "grdc_DanhSach";
            this.grdc_DanhSach.Size = new System.Drawing.Size(438, 502);
            this.grdc_DanhSach.TabIndex = 1;
            this.grdc_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuDS
            // 
            this.contextMenuDS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuDS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHuyDatTruoc});
            this.contextMenuDS.Name = "contextMenuDS";
            this.contextMenuDS.Size = new System.Drawing.Size(192, 30);
            // 
            // btnHuyDatTruoc
            // 
            this.btnHuyDatTruoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDatTruoc.Image = global::GUI.Properties.Resources.icons8_unavailable_16;
            this.btnHuyDatTruoc.Name = "btnHuyDatTruoc";
            this.btnHuyDatTruoc.Size = new System.Drawing.Size(191, 26);
            this.btnHuyDatTruoc.Text = "Hủy Đặt Trước";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdc_DanhSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // groupBox1
            // 
            this.tablePanel1.SetColumn(this.groupBox1, 1);
            this.groupBox1.Controls.Add(this.grdc_ChiTiet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(453, 3);
            this.groupBox1.Name = "groupBox1";
            this.tablePanel1.SetRow(this.groupBox1, 0);
            this.groupBox1.Size = new System.Drawing.Size(444, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Đặt Trước";
            // 
            // grdc_ChiTiet
            // 
            this.grdc_ChiTiet.ContextMenuStrip = this.contextMenuCT;
            this.grdc_ChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdc_ChiTiet.Location = new System.Drawing.Point(3, 23);
            this.grdc_ChiTiet.MainView = this.gridView2;
            this.grdc_ChiTiet.Name = "grdc_ChiTiet";
            this.grdc_ChiTiet.Size = new System.Drawing.Size(438, 502);
            this.grdc_ChiTiet.TabIndex = 2;
            this.grdc_ChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextMenuCT
            // 
            this.contextMenuCT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuCT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHuyMucDatTruoc});
            this.contextMenuCT.Name = "contextMenuCT";
            this.contextMenuCT.Size = new System.Drawing.Size(180, 30);
            // 
            // btnHuyMucDatTruoc
            // 
            this.btnHuyMucDatTruoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyMucDatTruoc.Image = global::GUI.Properties.Resources.icons8_unavailable_16;
            this.btnHuyMucDatTruoc.Name = "btnHuyMucDatTruoc";
            this.btnHuyMucDatTruoc.Size = new System.Drawing.Size(179, 26);
            this.btnHuyMucDatTruoc.Text = "Hủy Mục Này";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdc_ChiTiet;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // FormDanhSachDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDanhSachDatTruoc";
            this.Text = "FormDanhSachDatTruoc";
            this.Load += new System.EventHandler(this.FormDanhSachDatTruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdc_DanhSach)).EndInit();
            this.contextMenuDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdc_ChiTiet)).EndInit();
            this.contextMenuCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuDS;
        private System.Windows.Forms.ToolStripMenuItem btnHuyDatTruoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuCT;
        private System.Windows.Forms.ToolStripMenuItem btnHuyMucDatTruoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl grdc_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grdc_ChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}