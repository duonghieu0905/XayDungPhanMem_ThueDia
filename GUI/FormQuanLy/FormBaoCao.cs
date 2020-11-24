using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.FormQuanLy
{
    public partial class FormBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            AddInfoToSuccessForm();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }
        private void AddInfoToSuccessForm()
        {
            ExpressionMethod.AddOptionToReportCustomer(cbx_ThongKeKH);
            ExpressionMethod.AddOptionToReportTitle(cbx_BaoCaoTieuDe);
        }

       
    }
}