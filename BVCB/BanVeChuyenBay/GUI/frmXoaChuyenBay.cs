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
    public partial class frmXoaChuyenBay : Form
    {
        public frmXoaChuyenBay()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaChuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaChuyenBay.Items.Clear();

            DataTable dt = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBayPlaned();
            foreach(DataRow row in dt.Rows)
            {
                cbMaChuyenBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay]);
            }

            dt = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBayNotPlane();
            foreach (DataRow row in dt.Rows)
            {
                cbMaChuyenBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay]);
            }
        }


        public static void XoaChuyenBay(String MaChuyenBay)
        {
            BLL.BLL_CT_Ghe.DeleteCT_Ghe(MaChuyenBay);

            BLL.BLL_CT_LichChuyenBay.DeleteCT_LichChuyenBay(MaChuyenBay);

            BLL.BLL_BaoCaoDoanhThuChuyenBay.DeleteBaoCaoDoanhThuChuyenBay(MaChuyenBay);

            DataTable dt = BLL.BLL_CT_PhieuDatCho.SelectAtCT_PhieuDatCho(MaChuyenBay);
            BLL.BLL_CT_PhieuDatCho.DeleteCT_PhieuDatCho_At_MaChuyenBay(MaChuyenBay);

            foreach (DataRow row in dt.Rows)
            {
                BLL.BLL_PhieuDatCho.DeletePhieuDatCho(row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaPhieuDat].ToString());
            }

            BLL.BLL_LichChuyenBay.DeleteLichChuyenBay(MaChuyenBay);

            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(cbMaChuyenBay.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mã chuyến bay muốn xóa", "Lỗi");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?\nViệc xóa dữ liệu này sẽ làm mất dữ liệu khác", "Thông báo", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
            {
                try
                {
                    String MaChuyenBay = cbMaChuyenBay.Text.ToString();
                    XoaChuyenBay(MaChuyenBay);
                    BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Xóa chuyến bay " + cbMaChuyenBay.Text.Trim());

                    
                }catch
                { }
            }
        }
    }
}
