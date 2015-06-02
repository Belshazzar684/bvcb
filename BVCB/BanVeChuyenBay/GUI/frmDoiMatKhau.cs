using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeChuyenBay.BLL;

namespace BanVeChuyenBay.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        string ten;
        public frmDoiMatKhau(string strTextBox)
        {
            InitializeComponent();
            ten = strTextBox;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
           //Nhat - fix bug 1.1.1, 1.1.2
            if (txtMatKhauMoi.Text == txtMatKhauXacNhan.Text && String.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                try
                {
                    string id = ten;
                    string MatKhauMoi = txtMatKhauMoi.Text;
                    BLL_NhanVien.UpdateMatKhau(id, MatKhauMoi);
                    MessageBox.Show("Thay đổi mật khẩu thành công");
                    this.DialogResult = DialogResult.Cancel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng nhau","Error");
            }
        }

        private void bttkhong_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.Text = "";
            txtMatKhauXacNhan.Text = "";
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            string id = ten;
            DataTable dt = BLL_NhanVien.Select_MaNhanVien(id);
            DataRow dr = dt.Rows[0];
            txtTenNguoiDung.Text = dr["TenNhanVien"].ToString();
            txtTenDangNhap.Text = dr["TenDangNhap"].ToString();


        }


        private void txtMatKhauNew_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtMatKhauMoi.Text.Length > 15 || txtMatKhauMoi.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải từ 3 đến 15 ký tự");
                txtMatKhauMoi.Focus();
            }
        }

        private void txtMatKhauXacNhan_Validating_1(object sender, CancelEventArgs e)
        {
            if (!txtMatKhauXacNhan.Text.Equals(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Mat Khẩu xác nhận không chính sác");
                txtMatKhauXacNhan.Focus();
            }
        }
    }
}
