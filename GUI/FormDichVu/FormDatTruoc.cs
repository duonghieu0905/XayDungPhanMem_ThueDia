﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.FormChucNang;

namespace GUI.FormDichVu
{
    public partial class FormDatTruoc : DevExpress.XtraEditors.XtraForm
    {
        public FormDatTruoc()
        {
            InitializeComponent();
        }

        private void btn_CheckDatTruoc_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            FormLienHeDatTruoc frm = new FormLienHeDatTruoc();
            ExpressionMethod.AddFormToPanel(pnl, frm);
        }

        private void btn_DanhSachDatTruoc_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            FormDanhSachDatTruoc frm = new FormDanhSachDatTruoc();
            ExpressionMethod.AddFormToPanel(pnl, frm);
        }

        private void FormDatTruoc_Load(object sender, EventArgs e)
        {
            FormLienHeDatTruoc frm = new FormLienHeDatTruoc();
            ExpressionMethod.AddFormToPanel(pnl, frm);
        }
    }
}
