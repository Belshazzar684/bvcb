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
    public partial class frmThemSanBay : Form
    {
        public frmThemSanBay()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Equals("") || txtTenSanBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                return;
            }


            try
            {
                BLL.BLL_SanBay.InsertSanBay(txtMaSanBay.Text, txtTenSanBay.Text);

                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Mã sân bay đã tồn tại", "Lỗi");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
