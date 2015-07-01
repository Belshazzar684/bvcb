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
    public partial class frmXoaTuyenBay : Form
    {
        public frmXoaTuyenBay()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static public void XoaTuyenBay(String MaTuyenBay)
        {
            DataTable dt = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBay();
            DataRow[] rows = dt.Select("MaTuyenBay='" + MaTuyenBay + "'");

            for(int i = 0; i < rows.Count(); i++)
            {
                String MaChuyenBay = rows[i].ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay].ToString();

                frmXoaChuyenBay.XoaChuyenBay(MaChuyenBay);
            }

            // xoa tuyen bay
            BLL.BLL_TuyenBay.DeleteTuyenBay(MaTuyenBay);    
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(cbMaTuyenBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn tuyến bay muốn xóa", "Lỗi");
                return;
            }

            XoaTuyenBay(cbMaTuyenBay.Text);

            MessageBox.Show("Xóa thành công", "Thông báo");
            BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Xóa tuyến bay " + cbMaTuyenBay.Text);
            cbMaTuyenBay.Text = "";
        }

        private void cbMaTuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaTuyenBay.Items.Clear();
            cbMaTuyenBay.Text = "";

            DataTable dt = BLL.BLL_TuyenBay.SelectAllTuyenBay();

            foreach (DataRow row in dt.Rows)
            {
                cbMaTuyenBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaTuyenBay]);
            }
        }
    }
}
