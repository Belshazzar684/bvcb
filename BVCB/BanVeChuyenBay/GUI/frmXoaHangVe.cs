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
    public partial class frmXoaHangVe : Form
    {
        public frmXoaHangVe()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaHangVe_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaHangVe.Items.Clear();

            DataTable dt = BLL.BLL_HangVe.SelectAllHangVe();

            foreach(DataRow row in dt.Rows)
            {
                cbMaHangVe.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDHangVe.MaHangVe]);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if(cbMaHangVe.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn hạng vé muốn xóa", "Lỗi");
                return;
            }

            BLL.BLL_HangVe.DeleteHangVe(cbMaHangVe.Text);
            MessageBox.Show("Xóa thành công", "Thông báo");
            BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Xóa hạng vé " + cbMaHangVe.Text);

            cbMaHangVe.Text = "";
            textBox1.Text = "";
        }
    }
}
