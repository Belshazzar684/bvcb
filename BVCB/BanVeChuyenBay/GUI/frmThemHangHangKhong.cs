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
    public partial class frmThemHangHangKhong : Form
    {
        public frmThemHangHangKhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_HangHangKhong.KiemTraHang(txtTenHang.Text))
            {
                BLL.BLL_HangHangKhong.InsertHangHangKhong(txtMaHang.Text, txtTenHang.Text);
                MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMaHang();
            }
            else
            {
                MessageBox.Show("Hãng đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThemHangHangKhong_Load(object sender, EventArgs e)
        {
            LoadMaHang();
        }

        //Load ma hang
        private void LoadMaHang()
        {
            txtMaHang.Text = "HHK" + (BLL.BLL_BoDem.SelectBoDem("HANGHANGKHONG") + 1);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
