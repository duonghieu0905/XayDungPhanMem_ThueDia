using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;
using BUL;
using Entities;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;

namespace GUI
{
    public static class ExpressionMethod
    {
        /// <summary>
        /// Config ComboBox
        /// </summary>
        /// <param name="cbx"></param>
        public static void ConfigComboBox(System.Windows.Forms.ComboBox cbx)
        {
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Config Form To SubForm
        /// </summary>
        /// <param name="frm"></param>
        public static void ConfigForm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Thêm vào combo box các giá trị giới tính
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddToComboBoxGender(System.Windows.Forms.ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Nam" });
            lst.Add(new { id = 2, value = "Nữ" });
            lst.Add(new { id = 3, value = "Khác" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        /// Thêm vào combobox các loại đĩa : Phim và Game
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddToComboBoxKindOfTitle(System.Windows.Forms.ComboBox cbx)
        {
            ConfigComboBox(cbx);
            var lst = new DiskTypeBUL().GetDiskTypes();
            cbx.DataSource = lst;
            cbx.DisplayMember = "TypeName";
            cbx.ValueMember = "IdDiskType";
        }
        /// <summary>
        /// Thêm vào combobox các trạng thái thuê: Trên giá đang chờ và đã thuê
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddToComboBoxStatusRentCD(System.Windows.Forms.ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "OnShelf" });
            lst.Add(new { id = 2, value = "OnHold" });
            lst.Add(new { id = 3, value = "Rented" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        ///  Thêm vào combobox các trạng thái hiện tại của đĩa : Tốt , bị mất , hỏng
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddToComboBoxStatusCD(System.Windows.Forms.ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Good" });
            lst.Add(new { id = 2, value = "Damage" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        /// Add Sub Form to the fluent
        /// </summary>
        /// <param name="fluent"></param>
        /// <param name="frm"></param>
        public static void AddFormToFluent(FluentDesignFormContainer fluent, Form frm)
        {
            fluent.Controls.Clear();
            ConfigForm(frm);
            fluent.Controls.Add(frm);
            frm.Show();
        }
        public static void AddFormToPanel(Panel panel, Form frm)
        {
            panel.Controls.Clear();
            ConfigForm(frm);
            panel.Controls.Add(frm);
            frm.Show();
        }
        /// <summary>
        /// List bắt đầu cho đăng nhập
        /// </summary>
        /// <returns></returns>
        public static List<string> ListBegin()
        {
            List<string> lst = new List<string>();
            lst.Add("Nhóm 11 - App Cho Thuê Đĩa");
            lst.Add("Nhân Viên");
            lst.Add("Quản Lý");
            lst.Add("Đăng Nhập Vào Tài Khoản Quản Lý");
            lst.Add("Đăng Xuất");
            return lst;
        }
        /// <summary>
        ///  Thêm các lựa chọn cho bản báo cáo cho khách hàng
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddOptionToReportCustomer(System.Windows.Forms.ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Tất Cả Khách Hàng" });
            lst.Add(new { id = 2, value = "Khách Hàng Có Mặt Hàng Quá Hạn" });
            lst.Add(new { id = 3, value = "Khách Hàng Nợ Phí Trả Chậm" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        /// Thêm lựa chọn cho bản báo cáo tiêu đề
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddOptionToReportTitle(System.Windows.Forms.ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Số Lượng Bản Sao Đã Được Thuê" });
            lst.Add(new { id = 2, value = "Số Lượng Bản Sao Đang Được Khách Hàng Đặt Trước" });
            lst.Add(new { id = 3, value = "Số Lượng Hiện Trong Kho" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        /// Sửa grid view của dev  express
        /// </summary>
        /// <param name="grd"></param>
        public static void EditGridView(GridView grd)
        {
            grd.OptionsBehavior.Editable = false;
            grd.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            grd.GroupPanelText = " ";
            grd.OptionsCustomization.AllowGroup = false;
            grd.OptionsView.ShowGroupPanel = false;

            grd.OptionsFind.AlwaysVisible = true;
            grd.OptionsFind.ShowFindButton = false;
            grd.OptionsFind.FindPanelLocation = GridFindPanelLocation.Panel;
            grd.OptionsFind.FindNullPrompt = "Thực Hiện Tìm Kiếm";

            grd.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grd.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        /// <summary>
        /// Load data to grid control
        /// </summary>
        /// <param name="grdc"></param>
        /// <param name="grdv"></param>
        /// <param name="binding"></param>
        public static void LoadGridControl(GridControl grdc,GridView grdv,BindingSource binding)
        {
            grdc.DataSource = null;
            grdc.DataSource = binding;
            grdv.BestFitColumns();
        }
        /// <summary>
        /// Check quyền quản lí
        /// true là quản lí
        /// false là nhân viên
        /// </summary>
        /// <param name="auth"></param>
        /// <returns></returns>
        public static bool CheckAuth(string auth)
        {
            if (auth.Equals("Nhân Viên"))
            {
                MessageBox.Show("Chỉ quản lý có quyền thực hiện chức này.\nVui lòng đăng nhập để thực hiện", "Phân Quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Config list view
        /// </summary>
        /// <param name="lstv"></param>
        public static void ConfigListView(ListView lstv)
        {
            lstv.GridLines = true;
            lstv.View = View.Details;
            lstv.CheckBoxes = true;
            lstv.FullRowSelect = true;
        }
        /// <summary>
        /// Kiểm tra số điện thoại
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            return false;
        }
        /// <summary>
        /// Join and return a db DiskRent
        /// </summary>
        /// <returns></returns>
        public static List<DiskInfoRent> DBDiskRent()
        {
            DiskTypeBUL dbDiskType= new DiskTypeBUL();
            TitleBUL dbTitle = new TitleBUL();
            DiskBUL dbDisk = new DiskBUL();
            List<DiskInfoRent> lst = new List<DiskInfoRent>();
            List<Disk> disks = dbDisk.GetDisks();
            List<DiskType> diskTypes = dbDiskType.GetDiskTypes();
            List<Title> titles = dbTitle.GetTitles();
            var db = dbDisk.GetDisks()
                .Join(dbTitle.GetTitles(), d => d.IdTitle, t => t.IdTitle, (d, t) => new { d, t })
                .Join(dbDiskType.GetDiskTypes(), dt => dt.t.IdDiskType, ty => ty.IdDiskType, (dt, ty) => new { dt, ty })
                .Select(x => new
                {
                    IdDisk = x.dt.d.IdDisk,
                    Title = x.dt.t.NameTitle,
                    TypeName = x.ty.TypeName,
                    TimeRented = x.ty.TimeRented,
                    LateFee = x.ty.LateFee,
                    Price = x.ty.Price,
                    DiskRentalStatus = x.dt.d.DiskRentalStatus
                }).ToList();
            foreach (var item in db)
                lst.Add(new DiskInfoRent { IdDisk = item.IdDisk, LateFee = (int)item.LateFee, Price = (int)item.Price, TimeRented = (int)item.TimeRented, Title = item.Title, TypeName = item.TypeName, DiskRentalStatus = item.DiskRentalStatus });
            return lst;
        }
        /// <summary>
        /// Trả về cái list có return db join từ 3 bảng và thông tin của khách hahgnf đó
        /// </summary>
        /// <returns></returns>
        public static List<DiskInfoReturn> DBDiskReturn()
        {
            List<DiskInfoReturn> lst = new List<DiskInfoReturn>();
            CustomerBUL dbCustomer = new CustomerBUL();
            TitleBUL dbTitle = new TitleBUL();
            DiskBUL dbDisk = new DiskBUL();
            ListRentedBUL dbRented = new ListRentedBUL();
            var db = dbRented.GetListRenteds().Where(x => x.StatusOnBill == null)
                .Join(dbDisk.GetDisks(), rt => rt.IdDisk, d => d.IdDisk, (rt, d) => new { rt, d })
                .Join(dbTitle.GetTitles(), rtd => rtd.d.IdTitle, t => t.IdTitle, (rtd, t) => new { rtd, t })
                .Join(dbCustomer.GetCustomers(), rtdt => rtdt.rtd.rt.IdCustomer, c => c.IdCustomer, (rtdt, c) => new { rtdt, c });
            foreach (var item in db)
            {
                lst.Add(new DiskInfoReturn { Address = item.c.Address, CustomerName = item.c.CustomerName, ExpectedDate = (DateTime)item.rtdt.rtd.rt.ExpectedReturnDate, IdCustomer = (int)item.rtdt.rtd.rt.IdCustomer, IdDisk = (int)item.rtdt.rtd.rt.IdDisk, PhoneNumber = item.c.PhoneNumber, RentedDate = (DateTime)item.rtdt.rtd.rt.RentalDate, Title = item.rtdt.t.NameTitle,IdListRented=item.rtdt.rtd.rt.IdListRented });
            }
            return lst;
        }
        // Regurlar expression

        /// <summary>
        /// Check số điện thoại nhập vào 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool CheckSDT(this TextEdit txt)
        {
            bool result= Regex.Match(txt.Text.ToString(), @"^0\d{9,11}$").Success;
            if(result==false)
                MessageBox.Show("Kiểm tra lại định dạng số điện thoại", "Định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }
        /// <summary>
        /// Check mã khách hàng
        /// </summary>
        /// <param name="makh"></param>
        /// <returns></returns>
        public static bool CheckMa(this TextEdit txt)
        {
            int temp;
            bool result= Int32.TryParse(txt.Text.ToString(), out temp);
            if (result == false)
                MessageBox.Show("Vui lòng kiểm tra lại định dạng nhập vào", "Định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }
        public static bool CheckSoLuong(this TextEdit txt)
        {
            int temp;
            bool result = Int32.TryParse(txt.Text.ToString(), out temp);
            if (result == false)
                MessageBox.Show("Vui lòng kiểm tra lại định dạng số lượng nhập vào", "Định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }

    }
}
