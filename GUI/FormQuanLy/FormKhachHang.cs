using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.FormChucNang;

namespace GUI.FormQuanLy
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        public FormKhachHang(string auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(gridView1);
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKH frm = new FormThemKH();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
                //Thực hiện xóa
            }
            
        }
        
    }
}
