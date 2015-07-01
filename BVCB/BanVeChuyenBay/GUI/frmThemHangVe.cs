using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeChuyenBay.GUI
{
    public partial class frmThemHangVe : Form
    {
        public frmThemHangVe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (txtMaHangVe.Text.Equals("") || txtTenHangVe.Text.Equals("") || txtTiLeGiaVe.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                return;
            }

            float x;
            try
            {
                double b = Convert.ToDouble(txtTiLeGiaVe.Text);
                x = (float)b;

                //Nhat - xét tỉ lệ giá vé phải lớn hơn 0
                if (x <= 0)
                {
                    MessageBox.Show("Tỉ lệ giá vé phải lớn hơn 0", "Lỗi");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu", "Lỗi");
                return;
            }

            try
            {
                BLL.BLL_HangVe.InsertHangVe(txtMaHangVe.Text, txtTenHangVe.Text, x);

                MessageBox.Show("Thêm thành công", "Thông báo");
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thêm hạng vé " + txtMaHangVe.Text);
                buttonX1_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Mã hạng vé đã tồn tại", "Thông báo");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            txtMaHangVe.Text ="HV" + (BLL.BLL_BoDem.SelectBoDem("HANGVE") + 1);
        }

        private void frmThemHangVe_Load(object sender, EventArgs e)
        {
            txtMaHangVe.Text = "HV" + (BLL.BLL_BoDem.SelectBoDem("HANGVE") + 1);
        }
    }
}
