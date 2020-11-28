namespace GUI.FormChucNang
{
    partial class FormThemKH
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
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDienThoai.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel3.Controls.Add(this.label2);
            this.tablePanel3.Controls.Add(this.txt_SoDienThoai);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(181, 163);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 2);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(438, 74);
            this.tablePanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.tablePanel3.SetColumn(this.label2, 0);
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.tablePanel3.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Điện Thoại";
            // 
            // txt_SoDienThoai
            // 
            this.tablePanel3.SetColumn(this.txt_SoDienThoai, 1);
            this.txt_SoDienThoai.Location = new System.Drawing.Point(183, 24);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Properties.Appearance.Options.UseFont = true;
            this.txt_SoDienThoai.Properties.NullValuePrompt = "Số Lượng Đĩa";
            this.txt_SoDienThoai.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.txt_SoDienThoai, 0);
            this.txt_SoDienThoai.Size = new System.Drawing.Size(247, 26);
            this.txt_SoDienThoai.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Controls.Add(this.tablePanel5);
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F)});
            this.tablePanel1.Size = new System.Drawing.Size(800, 450);
            this.tablePanel1.TabIndex = 1;
            // 
            // tablePanel5
            // 
            this.tablePanel1.SetColumn(this.tablePanel5, 1);
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel5.Controls.Add(this.label3);
            this.tablePanel5.Controls.Add(this.txt_DiaChi);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(181, 243);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel1.SetRow(this.tablePanel5, 3);
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel5.Size = new System.Drawing.Size(438, 74);
            this.tablePanel5.TabIndex = 5;
            // 
            // label3
            // 
            this.tablePanel5.SetColumn(this.label3, 0);
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.tablePanel5.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa Chỉ";
            // 
            // txt_DiaChi
            // 
            this.tablePanel5.SetColumn(this.txt_DiaChi, 1);
            this.txt_DiaChi.Location = new System.Drawing.Point(183, 24);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Properties.NullValuePrompt = "Địa Chỉ";
            this.txt_DiaChi.Properties.ReadOnly = true;
            this.tablePanel5.SetRow(this.txt_DiaChi, 0);
            this.txt_DiaChi.Size = new System.Drawing.Size(247, 26);
            this.txt_DiaChi.TabIndex = 4;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.btn_Them);
            this.tablePanel4.Controls.Add(this.btn_Dong);
            this.tablePanel4.Location = new System.Drawing.Point(181, 354);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 4);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(438, 61);
            this.tablePanel4.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_Them, 0);
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Them.ImageOptions.Image = global::GUI.Properties.Resources.icons8_add_property_32;
            this.btn_Them.Location = new System.Drawing.Point(3, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Them, 0);
            this.btn_Them.Size = new System.Drawing.Size(213, 55);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm Khách Hàng";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_Dong, 1);
            this.btn_Dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dong.ImageOptions.Image = global::GUI.Properties.Resources.icons8_close_pane_32;
            this.btn_Dong.Location = new System.Drawing.Point(222, 3);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Dong, 0);
            this.btn_Dong.Size = new System.Drawing.Size(213, 55);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "Đóng";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel2.Controls.Add(this.label4);
            this.tablePanel2.Controls.Add(this.txt_TenKhachHang);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(181, 83);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(438, 74);
            this.tablePanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.tablePanel2.SetColumn(this.label4, 0);
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.tablePanel2.SetRow(this.label4, 0);
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // txt_TenKhachHang
            // 
            this.tablePanel2.SetColumn(this.txt_TenKhachHang, 1);
            this.txt_TenKhachHang.Location = new System.Drawing.Point(181, 24);
            this.txt_TenKhachHang.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhachHang.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKhachHang.Properties.NullValuePrompt = "Tiêu Đề";
            this.txt_TenKhachHang.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.txt_TenKhachHang, 0);
            this.txt_TenKhachHang.Size = new System.Drawing.Size(251, 26);
            this.txt_TenKhachHang.TabIndex = 4;
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(436, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormThemKH";
            this.Text = "FormThemKH";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDienThoai.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_TenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_SoDienThoai;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
    }
}