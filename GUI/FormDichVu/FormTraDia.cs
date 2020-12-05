using GUI.FormChucNang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormDichVu
{
    public partial class FormTraDia : DevExpress.XtraEditors.XtraForm
    {
        public FormTraDia()
        {
            InitializeComponent();
        }

        private void btn_XacNhanTraDia_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Không tìm thấy mã đĩa", "Mã đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThucHienTraDia_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DialogResult result = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormThanhToan frm = new FormThanhToan(null, null,null);
                    frm.ShowDialog();
                }
            }
        }
    }
}
