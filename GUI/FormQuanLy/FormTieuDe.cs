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
    public partial class FormTieuDe : DevExpress.XtraEditors.XtraForm
    {
        public FormTieuDe()
        {
            InitializeComponent();
        }

        private void FormTieuDe_Load(object sender, EventArgs e)
        {
            AddInfoToSuccessForm();
        }
        private void AddInfoToSuccessForm()
        {
            ExpressionMethod.AddToComboBoxKindOfTitle(cbx_LoaiDia);
        }

        private void btn_ThemDia_Click(object sender, EventArgs e)
        {
            FormThemDiaBS frm = new FormThemDiaBS();
            frm.ShowDialog();
        }
    }
}
