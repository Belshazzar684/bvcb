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
    public partial class frmSuaSanBay : Form
    {

        DataTable DanhSachSanBay;
        public frmSuaSanBay()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaSanBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaSanBay.Items.Clear();

            DanhSachSanBay = BLL.BLL_SanBay.SelectAllSanBay();

            foreach(DataRow row in DanhSachSanBay.Rows)
            {
                cbMaSanBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
            }
        }

        private void cbMaSanBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbMaSanBay.Text.Equals(""))
            {
                DataRow[] row = DanhSachSanBay.Select("MaSanBay='" + cbMaSanBay.Text + "'");

                txtTenSanBay.Text = row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(cbMaSanBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mã sân bay muốn sửa", "Lỗi");
                return;
            }

            if(txtTenSanBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên sân bay", "Lỗi");
                return;
            }

            try
            {
                BLL.BLL_SanBay.UpdateSanBayAt(cbMaSanBay.Text, txtTenSanBay.Text);

                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
            }
            catch
            {

            }
        }
    }
}
