using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormChucNang
{
    public partial class FormDanhSachDatTruoc : DevExpress.XtraEditors.XtraForm
    {
        public FormDanhSachDatTruoc()
        {
            InitializeComponent();
        }

        private void FormDanhSachDatTruoc_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(gridView1);
            ExpressionMethod.EditGridView(gridView2);
        }
    }
}
