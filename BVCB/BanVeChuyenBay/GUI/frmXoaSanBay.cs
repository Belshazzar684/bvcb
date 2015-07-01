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
    public partial class frmXoaSanBay : Form
    {
        DataTable data;
        public frmXoaSanBay()
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
            cbMaSanBay.Text = "";
            data = BLL.BLL_SanBay.SelectAllSanBay();

            foreach (DataRow row in data.Rows)
            {
                cbMaSanBay.Items.Add(row.ItemArray[0].ToString());
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbMaSanBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mã sân bay muốn xóa", "Lỗi");
                return;
            }

            DialogResult result = MessageBox.Show("Việc xóa sẽ làm mất dữ liệu khác, bạn chắc muốn xóa?","Thông báo", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
            {
                DataTable dsTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();
                DataRow[] tuyenbay = dsTuyenBay.Select("MaSanBayDi='" + cbMaSanBay.Text +"' OR MaSanBayDen='" +cbMaSanBay.Text + "'");
                for (int i = 0; i < tuyenbay.Count(); i++)
                {
                    String matuyenbay = tuyenbay[i].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaTuyenBay].ToString();

                    frmXoaTuyenBay.XoaTuyenBay(matuyenbay);  
                }


                BLL.BLL_SanBay.DeleteSanBayAt(cbMaSanBay.Text);

                MessageBox.Show("Xóa thành công.", "Thông báo");
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Xóa sân bay " + cbMaSanBay.Text);
                cbMaSanBay.Text = "";
            }
        }
    }
}
