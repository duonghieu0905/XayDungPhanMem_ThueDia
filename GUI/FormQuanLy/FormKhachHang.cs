using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormQuanLy
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            AddInfoToSuccessForm();
        }
        private void AddInfoToSuccessForm()
        {
            ExpressionMethod.AddToComboBoxGender(cbx_GioiTinh);
        }
        
    }
}
