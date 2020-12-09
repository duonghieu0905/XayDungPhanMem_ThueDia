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
        private ListRentedBUL dbRented;
        private List<DiskInfoRent> db;
        private BindingSource binding;
        private string auth;
        private const string STATUS_RENTED = "Rented";
        private const string STATUS_ONHOLD = "OnHold";
        private double totalRent = 0;
        private double totalOnHold = 0;
        public FormThueDia(string auth)
        {
            InitializeComponent();
            dbCus = new CustomerBUL();
            dbRented = new ListRentedBUL();
            db = ExpressionMethod.DBDiskRent();
            this.binding = new BindingSource();
            this.auth = auth;
        }

        private void FormThueDia_Load(object sender, EventArgs e)
        {
            try
            {
                AddInfoToAccessForm();
                LoadView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddInfoToAccessForm()
        {
            tablePnl.Rows[4].Height = 450;
            ExpressionMethod.EditGridView(grv_ThueDia);
            ExpressionMethod.ConfigListView(lsvOnHold);
            AddColumnToList();
        }
        private void AddColumnToList()
        {
            lsvOnHold.Columns.Add("Mã Đĩa", this.Width / 7);
            lsvOnHold.Columns.Add("Tiêu Đề", this.Width / 7);
            lsvOnHold.Columns.Add("Loại Đĩa", this.Width / 7);
            lsvOnHold.Columns.Add("Thời Gian Thuê", this.Width / 7);
            lsvOnHold.Columns.Add("Phí Trễ", this.Width / 7);
            lsvOnHold.Columns.Add("Giá Thuê", this.Width / 7);
            lsvOnHold.Columns.Add("Trạng Thái Thuê", this.Width / 7);
        }
        private void LoadView()
        {
            binding.DataSource = new List<DiskInfoRent>();
            ExpressionMethod.LoadGridControl(grdc_DSThueDia, grv_ThueDia, binding);


        }
        private void AddInfoListView()
        {
            //Thieu ne
            lsvOnHold.Items.Clear();
            int IdCustomer = Int32.Parse(txtMaKH.Text.ToString());
            var dbOnHold = db
                .Join(new DetailPreOrderBUL().GetDetailPreOrders().Where(x => x.Accepted == true && x.IdCustomer == IdCustomer), x => x.IdDisk, pre => pre.IdDisk, (x, pre) => new { x, pre });
            //.Join(new ListTitlePreOrderBUL().GetListTitlePreOrders().Where(x => x.IdCustomer == IdCustomer),xpre=>xpre.pre.id)


            foreach (var item in dbOnHold)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.x.IdDisk.ToString(), item.x.Title, item.x.TypeName, item.x.TimeRented.ToString(), item.x.LateFee.ToString(), item.x.Price.ToString(), item.x.DiskRentalStatus });
                listViewItem.Tag = item.pre;
                lsvOnHold.Items.Add(listViewItem);
            }
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
            try
            {
                if (txt_MaKHNhapVao.CheckMa() == false)
                    return;
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
                    AddInfoListView();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ThemDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaDiaNhapVao.CheckMa() == false)
                    return;
                int dianhap = Int32.Parse(txt_MaDiaNhapVao.Text.ToString());
                DiskInfoRent disk = db.Find(x => x.IdDisk == dianhap);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddDiskToListRent(DiskInfoRent disk)
        {
            if (disk.DiskRentalStatus.Equals(STATUS_RENTED))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin\nĐĩa này đã được thuê", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (disk.DiskRentalStatus.Equals(STATUS_ONHOLD))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin\nĐĩa này đã được đặt trước", "Thuê Đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                binding.RemoveAt(grv_ThueDia.GetSelectedRows()[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void grv_ThueDia_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                this.totalRent = 0;
                foreach (var item in binding.DataSource as List<DiskInfoRent>)
                {
                    this.totalRent += item.Price;
                }
                txtTongTien.Text = (totalRent + totalOnHold).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThucHienThueDia()
        {
            if (txtMaKH.CheckMa() == false)
                return;
            ThucHienLayDiaDatTruoc();
            int idCustomer = Int32.Parse(txtMaKH.Text.ToString());
            foreach (var item in binding.DataSource as List<DiskInfoRent>)
            {
                ListRented rented = new ListRented { IdDisk = item.IdDisk, IdCustomer = idCustomer, LateFee = item.LateFee, RentalDate = DateTime.Today, ExpectedReturnDate = DateTime.Today.AddDays(item.TimeRented), ActualReturnDate = null, StatusOnBill = null };
                if (dbRented.AddListRented(rented) == false)
                {
                    MessageBox.Show("Thuê đĩa thất bại", "Thuê đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Thuê đĩa thành công", "Thuê đĩa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db = ExpressionMethod.DBDiskRent();
            binding.DataSource = new List<DiskInfoRent>();

        }
        private void ThucHienLayDiaDatTruoc()
        {

            if (txtMaKH.CheckMa() == false)
                return;
            DetailPreOrderBUL dbpre = new DetailPreOrderBUL();
            int idCustomer = Int32.Parse(txtMaKH.Text.ToString());
            for (int i = 0; i < lsvOnHold.Items.Count; i++)
            {
                if (lsvOnHold.Items[i].Checked)
                {
                    dbRented.AddListRented(ListItemToListRented(lsvOnHold.Items[i]));
                }
                DetailPreOrder pre = lsvOnHold.Items[i].Tag as DetailPreOrder;
                dbpre.DeleteDetailPreOrder(pre.IdDetailPreOrder);
            }
            AddInfoListView();
        }
        private ListRented ListItemToListRented(ListViewItem item)
        {
            int idDisk = Int32.Parse(item.SubItems[0].Text.ToString());
            int idCustomer = Int32.Parse(txtMaKH.Text.ToString());
            int timeRent = Int32.Parse(item.SubItems[3].Text.ToString());
            double lateFee = double.Parse(item.SubItems[4].Text.ToString());
            ListRented rented = new ListRented
            {
                ActualReturnDate = null,
                RentalDate = DateTime.Today,
                ExpectedReturnDate = DateTime.Today.AddDays(timeRent),
                IdCustomer = idCustomer,
                IdDisk = idDisk,
                LateFee = lateFee,
                StatusOnBill = null
            };
            return rented;
        }
        private void btnXacNhanThueDia_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận thuê đĩa", "Thuê đĩa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ThucHienThueDia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvOnHold_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                this.totalOnHold = 0;
                for (int i = 0; i < lsvOnHold.Items.Count; i++)
                {
                    if (lsvOnHold.Items[i].Checked == true)
                        this.totalOnHold += double.Parse(lsvOnHold.Items[i].SubItems[5].Text.ToString());
                }
                txtTongTien.Text = (totalRent + totalOnHold).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lsvOnHold.Items.Count; i++)
                {
                    lsvOnHold.Items[i].Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveAllCheck_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lsvOnHold.Items.Count; i++)
                {
                    lsvOnHold.Items[i].Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
