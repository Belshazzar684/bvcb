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
        DataTable dtDiaDiem = new DataTable();
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
                DataTable dd = BLL.BLL_DiaDiem.SelectDiaDiem(row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.MaDiaDiem].ToString());
                cbQuocGia.SelectedItem = dd.Rows[0].ItemArray[(int)Support.BLL.Support.IDDiaDiem.QuocGia];
                cbThanhPho.SelectedItem = dd.Rows[0].ItemArray[(int)Support.BLL.Support.IDDiaDiem.ThanhPho];
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
                String MaDiaDiem = null;
                try
                {
                    MaDiaDiem = BLL.BLL_DiaDiem.SelectMaDiaDiemBy_QuocGia_ThanhPho(cbQuocGia.Text, cbThanhPho.Text).Rows[0].ItemArray[0].ToString();
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy địa điểm", "Lỗi");
                }
                BLL.BLL_SanBay.UpdateSanBayAt(cbMaSanBay.Text, txtTenSanBay.Text,MaDiaDiem);

                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Sửa sân bay " + cbMaSanBay.Text);
            }
            catch
            {

            }
        }

        private void frmSuaSanBay_Load(object sender, EventArgs e)
        {
            dtDiaDiem = BLL.BLL_DiaDiem.SelectAllDiaDiem();

            //Trả lại danh sách quốc gia không trùng
            DataView view = new DataView(dtDiaDiem);
            DataTable distinctValues = new DataTable();
            distinctValues = view.ToTable(true, "QuocGia");

            foreach (DataRow row in distinctValues.Rows)
            {
                cbQuocGia.Items.Add(row.ItemArray[0]);
            }
        }

        private void cbQuocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuocGia.SelectedIndex >= 0)
            {
                cbThanhPho.Items.Clear();
                DataTable dt = BLL.BLL_DiaDiem.SelectThanhPhoBy_QuocGia(cbQuocGia.Text);
                foreach (DataRow row in dt.Rows)
                {
                    cbThanhPho.Items.Add(row.ItemArray[0]);
                }
            }
        }
    }
}
