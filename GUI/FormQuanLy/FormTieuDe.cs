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
using Entities;

namespace GUI.FormQuanLy
{
    public partial class FormTieuDe : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        public FormTieuDe(string auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void FormTieuDe_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemDia_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
                FormThemDiaBS frm = new FormThemDiaBS();
                frm.ShowDialog();
            }
          
        }

        private void btn_ThemTieuDe_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
                FormThemTD frm = new FormThemTD();
                frm.ShowDialog();
            }
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {

            }
        }

        private void btn_DatTruoc_Click(object sender, EventArgs e)
        {
            FormThemDatTruoc frm = new FormThemDatTruoc(null);
            frm.ShowDialog();
        }
    }
}
