using GUI.FormChucNang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BUL;

namespace GUI.FormDichVu
{
    public partial class FormTraDia : DevExpress.XtraEditors.XtraForm
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private ListRentedBUL dbListRented;
        private List<DiskInfoReturn> db;
        private BindingSource binding;
        public FormTraDia()
        {
            InitializeComponent();
            dbListRented = new ListRentedBUL();
            db = ExpressionMethod.DBDiskReturn();
            binding = new BindingSource();
            binding.DataSource = new List<DiskInfoReturn>();
        }

        private void btn_XacNhanTraDia_Click(object sender, EventArgs e)
        {
            int dianhap = Int32.Parse(txt_NhapMaDia.Text.ToString());
            DiskInfoReturn infoReturn = db.FirstOrDefault(x => x.IdDisk == dianhap);
            if (infoReturn is null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin\nKhông có đĩa thuê này", "Mã đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadData(infoReturn);
            }
        }
        private void LoadData(DiskInfoReturn infoReturn)
        {
            txt_TieuDe.Text = infoReturn.Title;
            txt_NgayMuon.Text = infoReturn.ExpectedDate.ToString(DATE_FORMAT);
            txtNgayTraDuKien.Text = infoReturn.ExpectedDate.ToString(DATE_FORMAT);
            txtSoDienThoai.Text = infoReturn.PhoneNumber;
            txt_MaDia.Text = infoReturn.IdDisk.ToString();
            txtDiaChi.Text = infoReturn.Address;
            txtMaKH.Text = infoReturn.IdCustomer.ToString();
            txtTenKH.Text = infoReturn.CustomerName;
            binding.Add(infoReturn);
        }
        private void LoadView()
        {
            binding.DataSource = new List<DiskInfoReturn>();
            ExpressionMethod.LoadGridControl(grc_TraDia, grv_TraDia, binding);
        }

        private void btnThucHienTraDia_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DialogResult result = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormThanhToan frm = new FormThanhToan(null, null,null);
                    frm.ShowDialog();
                    db = ExpressionMethod.DBDiskReturn();
                }
            }
        }

        private void FormTraDia_Load(object sender, EventArgs e)
        {
            ConfigToSuccessView();
            tablePanel1.Rows[4].Height = 600;
            LoadView();
        }
        private void ConfigToSuccessView()
        {
            ExpressionMethod.EditGridView(grv_TraDia);
        }

        private void btnHuyMuc_Click(object sender, EventArgs e)
        {
            binding.RemoveAt(grv_TraDia.GetSelectedRows()[0]);
        }
        private void ThucHienTraDia()
        {
            foreach (var item in binding.DataSource as List<DiskInfoReturn>)
            {

            }
        }
    }
}
