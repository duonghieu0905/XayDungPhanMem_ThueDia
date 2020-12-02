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

namespace GUI.FormChucNang
{
    public partial class FormThanhToan : Form
    {
        private string idCustomer;
        private string auth;
        public FormThanhToan(string idCustomer,string auth)
        {
            InitializeComponent();
            this.idCustomer = idCustomer;
            this.auth = auth;
        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            AddInfoToSuccessForm();
            tablePnl.Rows[2].Height = this.Height - 150;
        }
        private void AddInfoToSuccessForm()
        {
            ExpressionMethod.ConfigListView(lstvThanhToanTreHan);
            AddColumnToListView();
        }
        private void AddColumnToListView()
        {
            lstvThanhToanTreHan.Columns.Add("Mã Đĩa", this.Width/6);
            lstvThanhToanTreHan.Columns.Add("Tiêu Đề", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("TG Thuê", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("TG Dự Tính", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("TG Trả", this.Width / 6);
            lstvThanhToanTreHan.Columns.Add("Phí Trễ", this.Width / 6);
            AddInfo();
            AddInfo();
        }
        private void AddInfo()
        {
            ListViewItem listViewItem = new ListViewItem(new string[] { "123", "123", "123", "123","123","123" });
            lstvThanhToanTreHan.Items.Add(listViewItem);
        }

        private void btnHuyKhoanTre_Click(object sender, EventArgs e)
        {
            if (ExpressionMethod.CheckAuth(this.auth))
            {
                
            }
        }

        private void lstvThanhToanTreHan_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            double tong=0;
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
            {
                if(lstvThanhToanTreHan.Items[i].Checked)
                tong += Int32.Parse(lstvThanhToanTreHan.Items[i].SubItems[5].Text.ToString());
            }
            txtTongTien.Text = tong.ToString();
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
                lstvThanhToanTreHan.Items[i].Checked = true;
            
        }

        private void btnHuyTatCa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvThanhToanTreHan.Items.Count; i++)
                lstvThanhToanTreHan.Items[i].Checked = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
