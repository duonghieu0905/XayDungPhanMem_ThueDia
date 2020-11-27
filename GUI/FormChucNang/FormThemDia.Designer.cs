namespace GUI.FormChucNang
{
    partial class FormThemDia
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.txt_TieuDe = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoLuongDia = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 80F)});
            this.tablePanel1.Size = new System.Drawing.Size(1013, 600);
            this.tablePanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(553, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm CD/DVD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel2.Controls.Add(this.label4);
            this.tablePanel2.Controls.Add(this.txt_TieuDe);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(229, 204);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(555, 92);
            this.tablePanel2.TabIndex = 2;
            // 
            // txt_TieuDe
            // 
            this.tablePanel2.SetColumn(this.txt_TieuDe, 1);
            this.txt_TieuDe.Location = new System.Drawing.Point(230, 31);
            this.txt_TieuDe.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TieuDe.Properties.Appearance.Options.UseFont = true;
            this.txt_TieuDe.Properties.NullValuePrompt = "Tiêu Đề";
            this.txt_TieuDe.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.txt_TieuDe, 0);
            this.txt_TieuDe.Size = new System.Drawing.Size(317, 30);
            this.txt_TieuDe.TabIndex = 4;
            // 
            // label4
            // 
            this.tablePanel2.SetColumn(this.label4, 0);
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.tablePanel2.SetRow(this.label4, 0);
            this.label4.Size = new System.Drawing.Size(214, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiêu Đề";
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F)});
            this.tablePanel3.Controls.Add(this.label2);
            this.tablePanel3.Controls.Add(this.txt_SoLuongDia);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(229, 304);
            this.tablePanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 3);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(555, 92);
            this.tablePanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.tablePanel3.SetColumn(this.label2, 0);
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.tablePanel3.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(214, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Lượng Đĩa";
            // 
            // txt_SoLuongDia
            // 
            this.tablePanel3.SetColumn(this.txt_SoLuongDia, 1);
            this.txt_SoLuongDia.Location = new System.Drawing.Point(232, 31);
            this.txt_SoLuongDia.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txt_SoLuongDia.Name = "txt_SoLuongDia";
            this.txt_SoLuongDia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongDia.Properties.Appearance.Options.UseFont = true;
            this.txt_SoLuongDia.Properties.NullValuePrompt = "Tiêu Đề";
            this.txt_SoLuongDia.Properties.ReadOnly = true;
            this.tablePanel3.SetRow(this.txt_SoLuongDia, 0);
            this.txt_SoLuongDia.Size = new System.Drawing.Size(313, 30);
            this.txt_SoLuongDia.TabIndex = 4;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.btn_Them);
            this.tablePanel4.Controls.Add(this.btn_Dong);
            this.tablePanel4.Location = new System.Drawing.Point(229, 404);
            this.tablePanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 4);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(555, 92);
            this.tablePanel4.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_Them, 0);
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Them.ImageOptions.Image = global::GUI.Properties.Resources.icons8_add_property_32;
            this.btn_Them.Location = new System.Drawing.Point(4, 4);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Them, 0);
            this.btn_Them.Size = new System.Drawing.Size(270, 84);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm Bản Sao";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Appearance.Options.UseFont = true;
            this.tablePanel4.SetColumn(this.btn_Dong, 1);
            this.btn_Dong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dong.ImageOptions.Image = global::GUI.Properties.Resources.icons8_close_pane_32;
            this.btn_Dong.Location = new System.Drawing.Point(282, 4);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel4.SetRow(this.btn_Dong, 0);
            this.btn_Dong.Size = new System.Drawing.Size(270, 84);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "Đóng";
            // 
            // FormThemDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 600);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemDia";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.TextEdit txt_TieuDe;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_SoLuongDia;
        private System.Windows.Forms.Label label4;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
    }
}