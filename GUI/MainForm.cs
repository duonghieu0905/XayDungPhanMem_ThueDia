using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using GUI.FormQuanLy;
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
        
        private void bar_BtnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm frm = new LoginForm();
            ExpressionMethod.AddFormToFluent(fluent_label,frm);
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
            FormKhachHang frm = new FormKhachHang();
            ExpressionMethod.AddFormToFluent(fluent_label,frm);
        }

        private void acdeTieuDe_Click(object sender, EventArgs e)
        {
            FormTieuDe frm = new FormTieuDe();
            ExpressionMethod.AddFormToFluent(fluent_label,frm);
        }

        private void acdeCD_Click(object sender, EventArgs e)
        {
            FormCD frm = new FormCD();
            ExpressionMethod.AddFormToFluent(fluent_label, frm);
        }

        private void adceBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
