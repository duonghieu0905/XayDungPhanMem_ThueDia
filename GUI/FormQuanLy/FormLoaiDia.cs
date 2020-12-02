using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using Entities;

namespace GUI.FormQuanLy
{
    public partial class FormLoaiDia : DevExpress.XtraEditors.XtraForm
    {
        private DiskTypeBUL db;
        private BindingSource binding;
        public FormLoaiDia()
        {
            InitializeComponent();
            db = new DiskTypeBUL();
            binding = new BindingSource();
        }

        private void FormLoaiDia_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
            LoadView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(grv_LoaiDia);
        }
        private void LoadView()
        {
            binding.DataSource = db.GetDiskTypes();
            ExpressionMethod.LoadGridControl(grd_LoaiDia, grv_LoaiDia, binding);
        }

        private void grv_LoaiDia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadToTextBox(grv_LoaiDia.GetSelectedRows()[0]);
        }
        private void LoadToTextBox(int indexSelected)
        {
            DiskType diskType = binding[indexSelected] as DiskType;
            pictureBox1.Tag = diskType.IdDiskType;
            txt_GiaThue.Text = diskType.Price.ToString();
            txt_PhiTre.Text = diskType.LateFee.ToString();
            txt_SoNgayThue.Text = diskType.TimeRented.ToString();
            txt_TenLoaiDia.Text = diskType.TypeName;
        }
    }
}
