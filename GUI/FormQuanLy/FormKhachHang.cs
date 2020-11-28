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
        public FormKhachHang()
        {
            InitializeComponent();
        }
        public FormKhachHang(string auth)
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKH frm = new FormThemKH();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
