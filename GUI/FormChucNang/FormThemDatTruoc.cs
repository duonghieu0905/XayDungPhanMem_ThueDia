﻿using System;
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

namespace GUI.FormChucNang
{
    public partial class FormThemDatTruoc : Form
    {
        private int idTitle;
        private ListTitlePreOrderBUL db;
        public FormThemDatTruoc(int idTitle)
        {
            InitializeComponent();
            this.idTitle = idTitle;
            db = new ListTitlePreOrderBUL();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemDatTruoc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận đặt trước tiêu đề trên", "Đặt trước", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ListTitlePreOrder listTitlePreOrder = new ListTitlePreOrder { IdCustomer = Int32.Parse(txt_MaKhachHang.Text.ToString()), IdTitle = this.idTitle, NumberOfDisk = Int32.Parse(txt_SoLuong.Text.ToString()) };
                    if (db.AddListTitlePreOrder(listTitlePreOrder))
                    {
                        MessageBox.Show("Thêm đặt trước thành công", "Đặt trước", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Thêm đặt trước thất bại", "Đặt trước", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadView()
        {
            txt_TieuDe.Text = this.idTitle.ToString();
        }

        private void FormThemDatTruoc_Load(object sender, EventArgs e)
        {
            LoadView();
        }
    }
}
