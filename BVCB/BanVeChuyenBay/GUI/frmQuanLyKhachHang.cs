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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        int vitri = 0;

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dtKhachHang.CurrentRow != null)
            {
                new frmChiTietKhachHang(dtKhachHang.CurrentRow.Cells["MaKhachHang"].Value.ToString()).ShowDialog();
            }
            else
            {
                new frmChiTietKhachHang().ShowDialog();
            }
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = (BLL_BoDem.SelectBoDem("NHANVIEN") + 1).ToString();
            LoadDataGridView();
            Gan_click();
            if (chkPass.Checked)
            {
                this.txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.UseSystemPasswordChar = true;
            }    
        }

        Boolean KiemTraThem = false;
        public void LoadDataGridView()
        {
            try
            {
                this.dtKhachHang.AutoGenerateColumns = false;
                dtKhachHang.DataSource = BLL_NhanVien.SelectALLKhachHang();
                txtMaKhachHang.ReadOnly = true;
                lbTongLoaiThuoc.Text = dtKhachHang.RowCount.ToString();
                this.dtKhachHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //-----------Gán nguồn từ DataGridView cho textbox khi lick chuột-------------
        public void Gan_click()
        {
            try
            {
                if (this.dtKhachHang.SelectedRows.Count == 0)
                {
                    lblMatKhau.Text = "Mật Khẩu";
                    return;
                }
                DataGridViewRow r = this.dtKhachHang.SelectedRows[0];

                GanDK(r);
            }
            catch (Exception ex)
            {
                lblMatKhau.Text = "Mật Khẩu";
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {

                if (dtKhachHang.Rows.Count != 0)
                {
                    this.txtMaKhachHang.Text = r.Cells["MaKhachHang"].Value.ToString();
                    this.txtTenKhachHang.Text = r.Cells["TenKhachHang"].Value.ToString();
                    this.txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
                    this.txtDienThoai.Text = r.Cells["DienThoai"].Value.ToString();
                    this.txtTenDangNhap.Text = r.Cells["TenDangNhap"].Value.ToString();
                    this.txtMatKhau.Text = "";
                    this.txtCMND.Text = r.Cells["CMND"].Value.ToString();
                    this.cbGioiTinh.SelectedItem = r.Cells["GioiTinh"].Value.ToString();
                    this.dtpNgaySinh.Value = DateTime.Parse(r.Cells["NgaySinh"].Value.ToString());
                    lblMatKhau.Text = "Mật Khẩu Mới";
                    //MessageBox.Show(r.Cells["SoLuongVeDat"].Value.ToString());
                }
                else
                {
                    this.txtMaKhachHang.Text = "";
                    this.txtTenKhachHang.Text = "";
                    this.txtDiaChi.Text = "";
                    this.txtDienThoai.Text = "";
                    this.txtTenDangNhap.Text = "";
                    this.txtMatKhau.Text = "";
                    this.txtCMND.Text = "";
                    lblMatKhau.Text = "Mật Khẩu";
                }
            }
            catch (Exception ex)
            {
                lblMatKhau.Text = "Mật Khẩu";
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            reset();
            KiemTraThem = true;
            dtKhachHang.Enabled = false;
            btxoa.Enabled = false;
            txtMaKhachHang.Text = (BLL_BoDem.SelectBoDem("NHANVIEN") + 1).ToString();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {

                //Ma random cho ma tu dong
                string MaKhachHang = txtMaKhachHang.Text;
                string TenKhachHang = txtTenKhachHang.Text;
                string DiaChi = txtDiaChi.Text;
                string DienThoai = txtDienThoai.Text;
                string MatKhau = txtMatKhau.Text;
                string TenDangNhap = txtTenDangNhap.Text;

                if (KiemTraThem == true || dtKhachHang.RowCount == 0)//luu thêm
                {
                    if (string.IsNullOrEmpty(MaKhachHang) || string.IsNullOrEmpty(TenKhachHang)
                        || string.IsNullOrEmpty(TenDangNhap) || string.IsNullOrEmpty(MatKhau))
                        MessageBox.Show("Vui lòng nhập đầy đủ mã nhân viên, tên nhân viên, tên đăng nhập, mật khẩu");
                    else
                    {
                        BLL_NhanVien.Insert(MaKhachHang, TenKhachHang, TenDangNhap, Utilities.Instance.MaHoa(MatKhau), 3, DiaChi, DienThoai);
                        BLL_KhachHang.Insert_ThongTinKhachHang(MaKhachHang, dtpNgaySinh.Value, cbGioiTinh.Text, txtCMND.Text);
                        MessageBox.Show("Tạo khách hàng thành công.");
                        BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thêm khách hàng " + MaKhachHang);
                        if (dtKhachHang.RowCount > 0)
                        {
                            DataGridViewRow r = this.dtKhachHang.SelectedRows[0];
                            reset();
                            Gan_click();
                        }
                    }
                }
                else//update 
                {
                    if (string.IsNullOrEmpty(MaKhachHang) || string.IsNullOrEmpty(TenKhachHang)
                        || string.IsNullOrEmpty(TenDangNhap))
                        MessageBox.Show("Vui lòng không bỏ trống mã nhân viên, tên nhân viên, tên đăng nhập");
                    else
                    {
                        if (string.IsNullOrEmpty(MatKhau))
                        {
                            BLL_NhanVien.Update(MaKhachHang, TenKhachHang, TenDangNhap, MatKhau, 3, DiaChi, DienThoai);
                            BLL_KhachHang.Update_ThongTinKhachHang(MaKhachHang, dtpNgaySinh.Value, cbGioiTinh.Text, txtCMND.Text);
                        }
                        else
                        {
                            BLL_NhanVien.Update(MaKhachHang, TenKhachHang, TenDangNhap, Utilities.Instance.MaHoa(MatKhau), 3, DiaChi, DienThoai);
                            BLL_KhachHang.Update_ThongTinKhachHang(MaKhachHang, dtpNgaySinh.Value, cbGioiTinh.Text, txtCMND.Text);
                        }
                        MessageBox.Show("Cập nhật khách hàng thành công.");
                        BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Cập nhật thông tin khách hàng " + MaKhachHang);

                        reset();
                        dtKhachHang.CurrentCell = dtKhachHang.Rows[vitri].Cells[0];
                        dtKhachHang.Rows[vitri].Selected = true;
                        Gan_click();
                    }
                }

                KiemTraThem = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKhachHang.Text))
                {
                    MessageBox.Show("Tên khách hàng không tồn tại");
                }
                else
                {
                    int MaKhachHang = int.Parse(txtMaKhachHang.Text.ToString());

                    if (MessageBox.Show("Bạn có muốn xóa khách hàng'" + txtTenKhachHang.Text + "'không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_NhanVien.Delete(MaKhachHang);
                        reset();
                        if (vitri > 0)
                        {
                            dtKhachHang.CurrentCell = dtKhachHang.Rows[vitri - 1].Cells[0];
                            dtKhachHang.Rows[vitri - 1].Selected = true;
                            Gan_click();
                        }
                        BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Xóa khách hàng " + MaKhachHang);

                    }
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btThietLapLai_Click(object sender, EventArgs e)
        {
            reset();
            Gan_click();
            //Fix bug 1.7.1, 1.7.2 - gán lại flag
            KiemTraThem = false;
        }
        public void reset()
        {
            this.txtMaKhachHang.Text = "";
            this.txtTenKhachHang.Text = "";
            this.txtDiaChi.Text = "";
            this.txtDienThoai.Text = "";
            this.txtTenDangNhap.Text = "";
            this.txtMatKhau.Text = "";
            this.txtCMND.Text = "";
            lblMatKhau.Text = "Mật Khẩu";
            LoadDataGridView();

            dtKhachHang.Enabled = true;
            btxoa.Enabled = true;
            // Gan_click();
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                this.txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (txtDienThoai.Text.Length > 20)
            {
                MessageBox.Show("điện thoại nhập vào vượt quá giới hạn cho chép (<20 ký tự)");
                txtDienThoai.Focus();
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ nhập vào vượt quá giới hạn cho chép (<100 ký tự)");
                txtDiaChi.Focus();
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenDangNhap.Text.Length > 30)
            {
                MessageBox.Show("Tên đăng nhập vượt quá giới hạn cho chép (<30 ký tự)");
                txtTenDangNhap.Focus();
            }
            DataTable dt = BLL_NhanVien.SelectALL();
            // MessageBox.Show(dt.Rows.Count.ToString());
            string TenNV = txtTenDangNhap.Text;
            if (KiemTraThem == true)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string abc = dr["TenDangNhap"].ToString();
                    if (TenNV.Equals(abc))
                    {
                        MessageBox.Show("Tên đăng nhập '" + TenNV.ToString() + "' đã tồn tại");
                        txtTenDangNhap.Focus();
                    }
                }

            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txtMatKhau.Text.Length > 30 || txtMatKhau.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu từ 3 đến 30 ký tự");
                txtMatKhau.Focus();
            }

        }

        private void txtTenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenKhachHang.Text.Length > 50)
            {
                MessageBox.Show("Tên khách hàng nhập vào vượt quá giới hạn cho chép (<50 ký tự)");
                txtTenKhachHang.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void dtKhachHang_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dtKhachHang.CurrentCell != null)
            {
                Gan_click();
                vitri = dtKhachHang.CurrentCell.RowIndex;
            }
        }
    }
}
