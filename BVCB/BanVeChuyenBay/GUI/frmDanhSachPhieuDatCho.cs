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
    public partial class frmDanhSachPhieuDatCho : Form
    {
        public frmDanhSachPhieuDatCho()
        {
            InitializeComponent();
        }

    
        private void cbDanhSachChuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbDanhSachChuyenBay.Items.Clear();
            DataTable dt = BLL.BLL_CT_PhieuDatCho.SelectAllCT_PhieuDatCho();

            foreach(DataRow row in dt.Rows)
            {
                bool Exists = false;
                for (int i = 0; i < cbDanhSachChuyenBay.Items.Count; i++)
                {
                    if( cbDanhSachChuyenBay.Items[i].Equals(row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaChuyenBay]))
                    {
                        Exists = true;
                        break;
                    }
                }

                if(!Exists)
                    cbDanhSachChuyenBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaChuyenBay]);
            }
        }

        private void cbDanhSachChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MaPhieuDat, TenNguoiDat, CMND, DienThoai, NgayDat;
            String TenHanhKhach, CMND2, DienThoai2, HangVe;

            if(!cbDanhSachChuyenBay.Text.Equals(""))
            {
                dataGridView1.Rows.Clear();

                DataTable ct_pdc = BLL.BLL_CT_PhieuDatCho.SelectAtCT_PhieuDatCho(cbDanhSachChuyenBay.Text, false);
                DataTable pdc = BLL.BLL_PhieuDatCho.SelectAllPhieuDatCho();

                foreach(DataRow row in ct_pdc.Rows)
                {
                    if (dataGridView1.Rows.Count == ct_pdc.Rows.Count)
                        dataGridView1.AllowUserToAddRows = false;

                    DataRow[] temp = pdc.Select("MaPhieuDatCho='" + row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaPhieuDat] + "'");

                    MaPhieuDat = temp[0].ItemArray[(int)Support.BLL.Support.IDPhieuDatCho.MaPhieuDat].ToString();
                    TenNguoiDat = temp[0].ItemArray[(int)Support.BLL.Support.IDPhieuDatCho.NguoiDat].ToString();
                    DienThoai = temp[0].ItemArray[(int)Support.BLL.Support.IDPhieuDatCho.DienThoai].ToString();
                    CMND = temp[0].ItemArray[(int)Support.BLL.Support.IDPhieuDatCho.CMND].ToString();
                    NgayDat = temp[0].ItemArray[(int)Support.BLL.Support.IDPhieuDatCho.NgayDat].ToString();

                    TenHanhKhach = row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.HanhKhachBay].ToString();
                    CMND2 = row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.CMND].ToString();
                    DienThoai2 = row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.DienThoai].ToString();
                    HangVe = row.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaHangVe].ToString();

                    dataGridView1.Rows.Add(MaPhieuDat, HangVe, TenNguoiDat, CMND, DienThoai, NgayDat, TenHanhKhach, CMND2, DienThoai2);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu những thay đổi", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if(dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không có dữ liệu để lưu", "Thông báo");
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[9];
                    
                    if ((bool)cell.EditedFormattedValue == true)
                    {
                        try
                        {
                            String MaPhieuDatCho = row.Cells[0].Value.ToString();

                            BLL.BLL_CT_PhieuDatCho.UpdateCT_PhieuDatCho(MaPhieuDatCho, cbDanhSachChuyenBay.Text, row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[1].Value.ToString(), true);

                           
                            //Update DoanhThuChuyenBay
                            DataTable updateDoanhThuChuyenBay = BLL.BLL_BaoCaoDoanhThuChuyenBay.SelectAllDoanhThuChuyenBay(cbDanhSachChuyenBay.Text);

                            foreach (DataRow temp in updateDoanhThuChuyenBay.Rows)
                            {
                                BLL.BLL_BaoCaoDoanhThuChuyenBay.UpdateBaoCaoDoanhThuChuyenBay( int.Parse(temp.ItemArray[1].ToString()),  int.Parse(temp.ItemArray[2].ToString()), cbDanhSachChuyenBay.Text.ToString(), Convert.ToInt32(temp.ItemArray[3].ToString()), Convert.ToInt32(temp.ItemArray[4].ToString()), 0.0f);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                MessageBox.Show("Cập nhật thành công", "Thông báo");
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thay đổi danh sách phiếu đặt chổ " );

                cbDanhSachChuyenBay_SelectedIndexChanged(sender, e);
            }
        }
    }
}
