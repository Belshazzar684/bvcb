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
    public partial class frmDangNhap : Form
    {
        //public delegate void TruyenLaiDuLieu(string MaNhanVien, string data);
        //public static TruyenLaiDuLieu truyendulieu;
        public frmDangNhap()
        {
            InitializeComponent();
            frmMain.TenDangNhap = "Chưa đăng nhập";
            frmMain.MaNhanVien = "";
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin");
                txtTenDangNhap.Focus();
            }
            else
            {
                
                DataTable dt = BLL_NhanVien.Select_DangNhap(TenDangNhap, Utilities.Instance.MaHoa(MatKhau));

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    MessageBox.Show("Đăng nhập thành công");
                    this.DialogResult = DialogResult.OK;
                    string dlCon = dr["TenNhanVien"].ToString();
                    string MaNV = dr["MaNhanVien"].ToString();
                    this.DialogResult = DialogResult.OK;
                    frmMain.MaNhanVien = MaNV;
                    frmMain.TenDangNhap = dlCon;
                    BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Đăng Nhập Vào Hệ Thống");

                  
                    frmMain f = new frmMain();
                    f.BatTat(true);
                }
                else
                {
                    MessageBox.Show("\tĐăng nhập thất bại! \nVui lòng kiểm tra lại thông tin đăng nhập!");
                    txtTenDangNhap.Focus();
                }
            }
            
        }

        private void txtMatKhau_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.Focus();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
