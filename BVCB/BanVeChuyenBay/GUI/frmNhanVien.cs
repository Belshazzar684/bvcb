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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        int vitri = 0;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
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
                this.dtNhanVien.AutoGenerateColumns = false;
                dtNhanVien.DataSource = BLL_NhanVien.SelectALL();
                //txtMaNhanVien.ReadOnly = true;
                lbTongLoaiThuoc.Text = dtNhanVien.RowCount.ToString();
                this.dtNhanVien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                if (this.dtNhanVien.SelectedRows.Count == 0)
                    return;
                DataGridViewRow r = this.dtNhanVien.SelectedRows[0];

                GanDK(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {

                if (dtNhanVien.Rows.Count != 0)
                {
                    this.txtMaNhanVien.Text = r.Cells[0].Value.ToString();
                    this.txtTenNhanVien.Text = r.Cells[1].Value.ToString();
                    this.txtDiaChi.Text = r.Cells[2].Value.ToString();
                    this.txtDienThoai.Text = r.Cells[3].Value.ToString();
                    this.txtTenDangNhap.Text = r.Cells[4].Value.ToString();
                    this.txtMatKhau.Text = r.Cells[5].Value.ToString();
                    this.cbQuyenHan.Text = ConvertToStringQuyenHan(r);
                }
                else
                {
                    this.txtMaNhanVien.Text = "";
                    this.txtTenNhanVien.Text = "";
                    this.txtDiaChi.Text = "";
                    this.txtDienThoai.Text = "";
                    this.txtTenDangNhap.Text = "";
                    this.txtMatKhau.Text = "";
                    this.cbQuyenHan.Text = "Nhân Viên";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            reset();
            KiemTraThem = true;
            dtNhanVien.Enabled = false;
            btxoa.Enabled = false;
        }

        int ConvertQuyenHan()
        {
            if (cbQuyenHan.Text.Equals("Quản Trị Viên"))
            {
                return 1;
            }
            else if (cbQuyenHan.Text.Equals("Ban Giám Đốc"))
            {
                return 2;
            }

            return 0;
        }

        string ConvertToStringQuyenHan(DataGridViewRow r)
        {

            if (r.Cells[6].Value.Equals(1))
                return "Quản Trị Viên";
            else if (r.Cells[6].Value.Equals(2))
                return "Ban Giám Đốc";

            return "Nhân Viên";
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtTenNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập nhân viên");
                    txtTenNhanVien.Focus();
                }
                else
                {
                    string MaNhanVien = txtMaNhanVien.Text;
                    string TenNhanVien = txtTenNhanVien.Text;
                    string DiaChi = txtDiaChi.Text;
                    string DienThoai = txtDienThoai.Text;
                    string MatKhau = txtMatKhau.Text;
                    string TenDangNhap = txtTenDangNhap.Text;
                    int QuyenHan = ConvertQuyenHan();


                    if (KiemTraThem == true || dtNhanVien.RowCount == 0)//luu thêm
                    {
                        BLL_NhanVien.Insert(MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, QuyenHan, DiaChi, DienThoai);
                        if (dtNhanVien.RowCount > 0)
                        {
                            DataGridViewRow r = this.dtNhanVien.SelectedRows[0];
                            reset();
                            Gan_click();
                        }


                    }
                    else//update 
                    {                      
                        BLL_NhanVien.Update(MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, QuyenHan, DiaChi, DienThoai);
                        reset();
                        dtNhanVien.CurrentCell = dtNhanVien.Rows[vitri].Cells[0];
                        dtNhanVien.Rows[vitri].Selected = true;
                        Gan_click();

                    }

                    KiemTraThem = false;
                }

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
                if (string.IsNullOrEmpty(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Tên nhân viên không tồn tại");
                }
                else
                {
                    int MaNhanVien = int.Parse(txtMaNhanVien.Text.ToString());

                    if (MessageBox.Show("Bạn có muốn xóa nhân viên'" + txtTenNhanVien.Text + "'không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_NhanVien.Delete(MaNhanVien);
                        reset();
                        if (vitri > 0)
                        {
                            dtNhanVien.CurrentCell = dtNhanVien.Rows[vitri - 1].Cells[0];
                            dtNhanVien.Rows[vitri - 1].Selected = true;
                            Gan_click();
                        }
                    }                 
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btkhong_Click(object sender, EventArgs e)
        {
            reset();
            Gan_click();
        }
        public void reset()
        {
            this.txtMaNhanVien.Text = "";
            this.txtTenNhanVien.Text = "";
            this.txtDiaChi.Text = "";
            this.txtDienThoai.Text = "";
            this.txtTenDangNhap.Text = "";
            this.txtMatKhau.Text = "";
            this.cbQuyenHan.Text = "Nhân Viên";
            LoadDataGridView();

            dtNhanVien.Enabled = true;
            btxoa.Enabled = true;
            // Gan_click();
        }

        private void dtNhanVien_Click(object sender, EventArgs e)
        {
            Gan_click();
            vitri = dtNhanVien.CurrentCell.RowIndex;
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

        private void dtNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value == null || e.Value == DBNull.Value)
                    return;
                if ((int)e.Value == 1)
                {
                    e.Value = Convert.ToInt32(e.Value).ToString("Quản Trị Viên");
                }
                else if((int) e.Value == 2)
                {
                    e.Value = Convert.ToInt32(e.Value).ToString("Ban Giám Đốc");
                }
                else
                {
                    e.Value = Convert.ToInt32(e.Value).ToString("Nhân Viên");
                }

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
            if (txtTenNhanVien.Text.Length > 50)
            {
                MessageBox.Show("Tên nhân viên nhập vào vượt quá giới hạn cho chép (<50 ký tự)");
                txtTenNhanVien.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void cbQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
