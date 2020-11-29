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

namespace GUI.FormDichVu
{
    public partial class FormThueDia : DevExpress.XtraEditors.XtraForm
    {
        public FormThueDia()
        {
            InitializeComponent();
        }

        private void FormThueDia_Load(object sender, EventArgs e)
        {
            AddInfoToAccessForm();
        }
        private void AddInfoToAccessForm()
        {
            tablePnl.Rows[4].Height = 610;
            ExpressionMethod.EditGridView(gridView1);
        }

        private void btn_TimKiemKhachHang_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (true)
            {
                DialogResult result = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormThanhToan frm = new FormThanhToan(null, null);
                    frm.ShowDialog();
                }
            }

        }
    }
}
