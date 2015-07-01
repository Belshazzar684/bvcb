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
        DataTable dtDiaDiem = new DataTable();

        public frmThemSanBay()
        {
            InitializeComponent();
        }

        private void LoadDiaDiem()
        {
            dtDiaDiem = BLL.BLL_DiaDiem.SelectAllDiaDiem();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Equals("") || txtTenSanBay.Text.Equals("") || cbQuocGia.SelectedIndex == -1 || cbThanhPho.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
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
                BLL.BLL_SanBay.InsertSanBay(txtMaSanBay.Text, txtTenSanBay.Text, MaDiaDiem);

                MessageBox.Show("Thêm thành công", "Thông báo");
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thêm sân bay " + txtMaSanBay.Text);
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

        //Load form
        private void frmThemSanBay_Load(object sender, EventArgs e)
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

        //Event chọn quốc gia
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
