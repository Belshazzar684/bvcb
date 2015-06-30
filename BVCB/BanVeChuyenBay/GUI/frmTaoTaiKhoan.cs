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
using BanVeChuyenBay.SqlHelper;

namespace BanVeChuyenBay.GUI
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhauMoi.Text) || string.IsNullOrEmpty(txtMatKhauXacNhan.Text)
                || string.IsNullOrEmpty(txtTenNguoiDung.Text) || string.IsNullOrEmpty(txtCMND.Text) || dtpNgaySinh.Value == null
                || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else
            {
                if (txtMatKhauMoi.Text == txtMatKhauXacNhan.Text)
                {
                    foreach (DataRow row in BLL_NhanVien.SelectALL().Rows)
                    {
                        if (row["TenNhanVien"].ToString() == txtTenDangNhap.Text)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //Ma nhan vien random cho ma tu dong
                    String NewMaNhanVien = (BLL_BoDem.SelectBoDem("NHANVIEN") + 1).ToString();
                    BLL_NhanVien.Insert(NewMaNhanVien, txtTenNguoiDung.Text, txtTenDangNhap.Text, Utilities.Instance.MaHoa(txtMatKhauMoi.Text), 3, txtDiaChi.Text, txtDienThoai.Text);
                    BLL_KhachHang.Insert_ThongTinKhachHang(NewMaNhanVien, dtpNgaySinh.Value, cbGioiTinh.Text, txtCMND.Text);
                    MessageBox.Show("Tạo nhân tài khoản thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu và mật khẩu xác nhận không trùng nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauMoi.Focus();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
        }
    }
}
