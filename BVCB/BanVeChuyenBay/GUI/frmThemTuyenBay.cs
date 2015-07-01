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
    public partial class frmThemTuyenBay : Form
    {
        DataTable DSSanBay;

        public frmThemTuyenBay()
        {
            InitializeComponent();
            DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();

            foreach(DataRow row in DSSanBay.Rows)
            {
                cbMaSanBayDi.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
                cbMaSanBayDen.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if(cbMaSanBayDen.Text.Equals("") || cbMaSanBayDi.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi");
                return;
            }

            if (cbMaSanBayDen.Text.Equals(cbMaSanBayDi.Text))
            {
                MessageBox.Show("Sân bay đến phải khác với sấn bay đi", "Lỗi");
                return;
            }

            try
            {
                BLL.BLL_TuyenBay.InsertTuyenBay(txtMaTuyenBay.Text, cbMaSanBayDi.Text, cbMaSanBayDen.Text);

                MessageBox.Show("Thêm tuyến bay thành công", "Thông báo");
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thêm tuyến bay mới " + txtMaTuyenBay.Text.Trim());

            }catch
            {
                MessageBox.Show("Tuyến bay đã tôn tại", "Thông báo");
            }
           
        }

        private void cbMaSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbMaSanBayDen.Text.Equals("") && !cbMaSanBayDi.Text.Equals(""))
            {
                String temp = cbMaSanBayDi.Text.ToString() + "_" + cbMaSanBayDen.Text.ToString();
                txtMaTuyenBay.Text = temp;
            }
        }

        private void cbMaSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbMaSanBayDen.Text.Equals("") && !cbMaSanBayDi.Text.Equals(""))
            {
                String temp = cbMaSanBayDi.Text.ToString() + "_" + cbMaSanBayDen.Text.ToString();
                txtMaTuyenBay.Text = temp;
            }
        }
    }
}
