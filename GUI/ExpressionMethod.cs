﻿using DevExpress.XtraBars.FluentDesignSystem;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public static class ExpressionMethod
    {
        /// <summary>
        /// Config ComboBox
        /// </summary>
        /// <param name="cbx"></param>
        public static void ConfigComboBox(ComboBox cbx)
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
        public static void AddToComboBoxGender(ComboBox cbx)
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
        public static void AddToComboBoxKindOfTitle(ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Đĩa Phim" });
            lst.Add(new { id = 2, value = "Đĩa Game" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        /// Thêm vào combobox các trạng thái thuê: Trên giá đang chờ và đã thuê
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddToComboBoxStatusRentCD(ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Trên Giá" });
            lst.Add(new { id = 2, value = "Đang Chờ" });
            lst.Add(new { id = 3, value = "Đã Thuê" });
            cbx.DataSource = lst;
            cbx.DisplayMember = "value";
            cbx.ValueMember = "id";
        }
        /// <summary>
        ///  Thêm vào combobox các trạng thái hiện tại của đĩa : Tốt , bị mất , hỏng
        /// </summary>
        /// <param name="cbx"></param>
        public static void AddToComboBoxStatusCD(ComboBox cbx)
        {
            ConfigComboBox(cbx);
            List<dynamic> lst = new List<dynamic>();
            lst.Add(new { id = 1, value = "Tốt" });
            lst.Add(new { id = 2, value = "Bị Mất" });
            lst.Add(new { id = 3, value = "Bị Hỏng" });
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
        public static void AddOptionToReportCustomer(ComboBox cbx)
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
        public static void AddOptionToReportTitle(ComboBox cbx)
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
    }
}
