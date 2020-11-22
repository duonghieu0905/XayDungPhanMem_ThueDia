using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        
        public MainForm()
        {
            InitializeComponent();
            ConfigView();
        }
        /// <summary>
        /// Config Design
        /// </summary>
        private void ConfigView()
        {
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "Nhóm 11 - App Thuê Đĩa";
            IconOptions.Image = Properties.Resources.icons8_cd_641;
        }
        /// <summary>
        /// Format Form begin add
        /// </summary>
        /// <param name="frm"></param>
        private void ConfigForm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
        }
        
        /// <summary>
        /// Add Sub Form to the fluent
        /// </summary>
        /// <param name="fluent"></param>
        /// <param name="frm"></param>
        private void AddFormToFluent(FluentDesignFormContainer fluent,Form frm)
        {
            fluent.Controls.Clear();
            ConfigForm(frm);
            fluent.Controls.Add(frm);
            frm.Show();
        }

        private void bar_BtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddFormToFluent(fluent_label, new LoginForm());
        }

        private void acdeThueDia_Click(object sender, EventArgs e)
        {

        }

        private void adceTraDia_Click(object sender, EventArgs e)
        {

        }

        private void adceDatTruoc_Click(object sender, EventArgs e)
        {

        }

        private void adceKhachHang_Click(object sender, EventArgs e)
        {
            AddFormToFluent(fluent_label, new FormQuanLy.FormKhachHang());
        }

        private void acdeTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void acdeCD_Click(object sender, EventArgs e)
        {

        }

        private void adceBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
