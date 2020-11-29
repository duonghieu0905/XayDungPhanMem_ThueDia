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
    public partial class FormLoaiDia : DevExpress.XtraEditors.XtraForm
    {
        public FormLoaiDia()
        {
            InitializeComponent();
        }

        private void FormLoaiDia_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(gridView1);
        }
    }
}
