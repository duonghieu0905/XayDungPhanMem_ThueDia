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
    public partial class FormCD : DevExpress.XtraEditors.XtraForm
    {
        private string auth;
        public FormCD(string auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void FormCD_Load(object sender, EventArgs e)
        {
            AddInfoToSuccessForm();
        }
        private void AddInfoToSuccessForm() {
            ExpressionMethod.AddToComboBoxStatusCD(cbx_TrangThaiDia);
            ExpressionMethod.AddToComboBoxStatusRentCD(cbx_TrangThaiThue);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {

            }
        }
    }
}
