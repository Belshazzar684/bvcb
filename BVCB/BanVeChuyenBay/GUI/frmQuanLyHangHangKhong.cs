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
    public partial class frmQuanLyHangHangKhong : Form
    {
        public frmQuanLyHangHangKhong()
        {
            InitializeComponent();
        }

        ///sự kiện click btThem
        ///chức năng: hiển thị frmThemHangHangKhong
        ///mô tả:
        private void btThem_Click(object sender, EventArgs e)
        {
            new frmThemHangHangKhong().Show();
        }

        ///sự kiện click btSua
        ///chức năng: hiển thị frmSuaHangHangKhong
        ///mô tả:
        private void btSua_Click(object sender, EventArgs e)
        {
            new frmSuaHangHangKhong().Show();
        }
    }
}
