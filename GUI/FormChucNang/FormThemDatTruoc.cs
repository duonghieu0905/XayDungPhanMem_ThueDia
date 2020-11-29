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
    public partial class FormThemDatTruoc : Form
    {
        private string matd;
        public FormThemDatTruoc(string matd)
        {
            InitializeComponent();
            this.matd = matd;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
