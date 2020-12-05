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
using BUL;
using Entities;

namespace GUI.FormDichVu
{
    public partial class FormThueDia : DevExpress.XtraEditors.XtraForm
    {
        private CustomerBUL dbCus;
        private DiskBUL dbDisk;
        private ListRentedBUL dbRented;
        private DiskTypeBUL dbDiskType;
        private TitleBUL dbTitle;
        private BindingSource binding;
        private string auth;
        private const string STATUS_RENTED = "Rented";
        public FormThueDia(string auth)
        {
            InitializeComponent();
            dbCus = new CustomerBUL();
            dbDisk = new DiskBUL();
            dbRented = new ListRentedBUL();
            dbDiskType = new DiskTypeBUL();
            dbTitle = new TitleBUL();
            this.binding = new BindingSource();
            this.auth = auth;
        }

        private void FormThueDia_Load(object sender, EventArgs e)
        {
            AddInfoToAccessForm();
            LoadView();
        }
        
        private void AddInfoToAccessForm()
        {
            tablePnl.Rows[4].Height = 610;
            ExpressionMethod.EditGridView(grv_ThueDia);
        }
        private void LoadView()
        {
            binding.DataSource = new List<Disk>();
            ExpressionMethod.LoadGridControl(grdc_DSThueDia, grv_ThueDia, binding);
        }
        private void LoadDataCustomerToText(Customer customer)
        {
            txtDiaChi.Text = customer.Address;
            txtMaKH.Text = customer.IdCustomer.ToString();
            txtSoDienThoai.Text = customer.PhoneNumber;
            txtTenKH.Text = customer.CustomerName;
        }
        private void btn_TimKiemKhachHang_Click(object sender, EventArgs e)
        {
            int customerId = Int32.Parse(txt_MaKHNhapVao.Text.ToString());
            Customer customer = dbCus.GetCustomer(customerId);
            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LoadDataCustomerToText(customer);
            }
            var lstLate = new ListRentedBUL().ListLate(customer.IdCustomer);
            if (lstLate.Count > 0)
            {
                DialogResult result = MessageBox.Show("Khách hàng có khoản trễ hạn. Có muốn thực hiện thanh toán không?", "Phí trễ hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    FormThanhToan frm = new FormThanhToan(customer, lstLate, this.auth);
                    frm.ShowDialog();
                }
            }

        }

        private void btn_ThemDia_Click(object sender, EventArgs e)
        {
            int dianhap = Int32.Parse(txt_MaDiaNhapVao.Text.ToString());
            Disk disk = dbDisk.GetDisk(dianhap);
            if (disk == null)
            {
                MessageBox.Show("Không tìm thấy đĩa", "Thông tin đĩa bản sao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AddDiskToListRent(disk);
            }
        }
        private void AddDiskToListRent(Disk disk)
        {
            if (disk.DiskRentalStatus.Equals(STATUS_RENTED))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin\nĐĩa này đã được thuê", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (binding.Contains(disk))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin\nĐĩa này đã tồn tại trong danh sách", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Thêm vào danh sách

            binding.Add(disk);
        }

        private void btnLoaiBoKhoiDS_Click(object sender, EventArgs e)
        {
            binding.RemoveAt(grv_ThueDia.GetSelectedRows()[0]);
        }

        private void grdc_DSThueDia_DataSourceChanged(object sender, EventArgs e)
        {
            
        }
        private void DeDayVeCoiTiep()
        {
            List<Disk> disks = dbDisk.GetDisks();
            List<DiskType> diskTypes = dbDiskType.GetDiskTypes();
            List<Title> titles = dbTitle.GetTitles();
            var db = dbDisk.GetDisks()
                .Join(dbTitle.GetTitles(), d => d.IdTitle, t => t.IdTitle, (d, t) => new { d, t })
                .Join(dbDiskType.GetDiskTypes(), dt => dt.t.IdDiskType, ty => ty.IdDiskType, (dt, ty) => new { dt, ty })
                .Select(x => new {
                    IdDisk = x.dt.d.IdDisk,
                    Title = x.dt.t.NameTitle,
                    TypeName = x.ty.TypeName,
                    TimeRented = x.ty.TimeRented,
                    LateFee = x.ty.LateFee,
                    Price = x.ty.Price,
                }).ToList();
        }
    }
}
