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
    public partial class FormLienHeDatTruoc : DevExpress.XtraEditors.XtraForm
    {
        public FormLienHeDatTruoc()
        {
            InitializeComponent();
        }

        private void FormLienHeDatTruoc_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(gridView1);
        }
    }
}
