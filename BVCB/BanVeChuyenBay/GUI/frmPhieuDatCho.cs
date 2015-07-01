using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeChuyenBay;

namespace BanVeChuyenBay.GUI
{
    public partial class frmPhieuDatCho : Form
    {
        DataTable DSSanBay;
        DataTable DSTuyenBay;
        DataTable DSHangVe;
        DataTable DSCTGhe;

        String MaSanBayDi = "";
        String MaSanBayDen = "";
        int DonGia;
        bool LaKhachHang = false;
        string MaKhachHang = null;
        

        public frmPhieuDatCho()
        {
            InitializeComponent();
            DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
            DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();


            // xoa danh sach phieu dat cho khi chuyen bay di
            // lay danh sach chuyen bay đa bay roi
            DataTable thamso = BLL.BLL_ThamSo.SelectAllThamSo();
            if(Boolean.Parse(thamso.Rows[0].ItemArray[(int)Support.BLL.Support.IDThamSo.TGHuyVe].ToString()))
            {
                DataTable dschuyenbay = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBayPlaned();

                foreach (DataRow row in dschuyenbay.Rows)
                {
                    String machuyenbay = row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay].ToString();
                    DataTable dt = BLL.BLL_CT_PhieuDatCho.SelectAtCT_PhieuDatCho(machuyenbay);
                    foreach (DataRow temp in dt.Rows)
                    {
                        String maphieudatcho = temp.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaPhieuDat].ToString();
                        BLL.BLL_CT_PhieuDatCho.DeleteCT_PhieuDatCho(maphieudatcho);
                        BLL.BLL_PhieuDatCho.DeletePhieuDatCho(maphieudatcho);
                    }
                }
            }
        }

        public frmPhieuDatCho(string _MaKhachHang)
        {
            InitializeComponent();
            DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
            DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();


            // xoa danh sach phieu dat cho khi chuyen bay di
            // lay danh sach chuyen bay đa bay roi
            DataTable thamso = BLL.BLL_ThamSo.SelectAllThamSo();
            if (Boolean.Parse(thamso.Rows[0].ItemArray[(int)Support.BLL.Support.IDThamSo.TGHuyVe].ToString()))
            {
                DataTable dschuyenbay = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBayPlaned();

                foreach (DataRow row in dschuyenbay.Rows)
                {
                    String machuyenbay = row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay].ToString();
                    DataTable dt = BLL.BLL_CT_PhieuDatCho.SelectAtCT_PhieuDatCho(machuyenbay);
                    foreach (DataRow temp in dt.Rows)
                    {
                        String maphieudatcho = temp.ItemArray[(int)Support.BLL.Support.IDCTPhieuDatCho.MaPhieuDat].ToString();
                        BLL.BLL_CT_PhieuDatCho.DeleteCT_PhieuDatCho(maphieudatcho);
                        BLL.BLL_PhieuDatCho.DeletePhieuDatCho(maphieudatcho);
                    }
                }
            }

            //Khachhang
            LaKhachHang = true;
            DataTable dt2 = BLL.BLL_NhanVien.Select_MaNhanVien(_MaKhachHang);
            DataTable dt3 = BLL.BLL_KhachHang.Select_ThongTinKhachHang(_MaKhachHang);
            if (dt2.Rows.Count > 0)
            {
                DataRow tr1 = dt2.Rows[0];
                DataRow tr2 = dt3.Rows[0];
                txtNguoiDat.Text = tr1["TenNhanVien"].ToString();
                txtDienThoai.Text = tr1["DienThoai"].ToString();
                txtCMND.Text = tr2["CMND"].ToString();
            }
            MaKhachHang = _MaKhachHang;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void cbMaChuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaChuyenBay.Items.Clear();

            DataTable dt = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBay_BY_QD3();

            foreach (DataRow row in dt.Rows)
            {
                cbMaChuyenBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay]);
            }
        }

        private void cbMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbMaChuyenBay.Text.Equals(""))
            {
                DataTable dt = BLL.BLL_LichChuyenBay.SelectAtLichChuyenBay(cbMaChuyenBay.Text);

                DataRow rowLichChuyenBay = dt.Rows[0];
                txtNgayGio.Text = rowLichChuyenBay.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.KhoiHanh].ToString();
                DonGia = Convert.ToInt32(rowLichChuyenBay.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.GiaVe]);

                DataRow[] rows = DSTuyenBay.Select("MaTuyenBay='" + rowLichChuyenBay.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaTuyenBay] + "'");
                MaSanBayDi = rows[0].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDi].ToString();
                MaSanBayDen = rows[0].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDen].ToString();

                rows = DSSanBay.Select("MaSanBay='" + MaSanBayDi + "'");
                txtSanBayDi.Text = rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();

                rows = DSSanBay.Select("MaSanBay='" + MaSanBayDen + "'");
                txtSanBayDen.Text = rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
                //Hang hang khong
                string TenHang = BLL.BLL_HangHangKhong.SelectHangHangKhong(rowLichChuyenBay.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaHang].ToString()).Rows[0].ItemArray[1].ToString();
                txtHangHangKhong.Text = TenHang;

                if (!cbHangVe.Text.Equals(""))
                {
                    setTextGiaTien();
                    setTextTinhTrangVe();
                }
            }
        }

        void setTextGiaTien()
        {
            DataRow[] rows = DSHangVe.Select("MaHangVe='" + cbHangVe.Text + "'");
            txtHangVe.Text = rows[0].ItemArray[(int)Support.BLL.Support.IDHangVe.TenHangVe].ToString();

            double giatien = Math.Round((double)DonGia * Convert.ToDouble(rows[0].ItemArray[(int)Support.BLL.Support.IDHangVe.TiLeDonGia]) / frmMain.TiGia,1);
            txtGiaTien.Text = giatien.ToString() + frmMain.TienTe;
        }

        void setTextTinhTrangVe()
        {
            DSCTGhe = BLL.BLL_CT_Ghe.SelectAtCT_Ghe(cbMaChuyenBay.Text, cbHangVe.Text);

            foreach (DataRow row in DSCTGhe.Rows)
            {
                txtTinhTrangVe.Text = row.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGheDat].ToString() + "/" + row.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGhe].ToString();
            }
        }

        private void cbHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbHangVe.Text.Equals(""))
            {
                setTextGiaTien();
                setTextTinhTrangVe();
            }
        }

        private void cbHangVe_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbMaChuyenBay.Text.Equals("")) return;

            cbHangVe.Items.Clear();
            DSHangVe = BLL.BLL_HangVe.SelectAllHangVe();

            DSCTGhe = BLL.BLL_CT_Ghe.SelectAtCT_Ghe(cbMaChuyenBay.Text);

            foreach (DataRow row in DSHangVe.Rows)
            {
                DataRow[] temp = DSCTGhe.Select("MaHangVe='" + row.ItemArray[(int)Support.BLL.Support.IDHangVe.MaHangVe] + "'");
                //Fix bug 1.3.2
                if (temp.Count() > 0)
                {
                    int soghetrong = Convert.ToInt32(temp[0].ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGheTrong]);

                    if (soghetrong > 0)
                        cbHangVe.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDHangVe.MaHangVe]);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNguoiDat.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tên người đặt", "Lỗi");
                    return;
                }

                if(txtNguoiBay.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tên hành khách bay", "Lỗi");
                    return;
                }
                    
                if(cbMaChuyenBay.Text.Equals("") || cbMaChuyenBay.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin mã chuyến bay", "Lỗi");
                    return;
                }

                if (cbHangVe.Text.Equals("") || cbHangVe.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin hạng vé", "Lỗi");
                    return;
                }


                DataTable dt = BLL.BLL_PhieuDatCho.SelectAllPhieuDatCho();
                //DataTable dt = BLL.BLL_PhieuDatCho.SelectMaxSTTPhieuDatCho();
                //int stt = 0;
                //if(dt.Rows.Count != 0)
                //    stt = int.Parse(dt.Rows[0].ItemArray[0].ToString());

                //Nhat - fix bug 1.5.1
                String MaPhieuDat = Support.BLL.Support.MaPhieuDat + (BLL.BLL_BoDem.SelectBoDem("PHIEUDATCHO") + 1);


                BLL.BLL_PhieuDatCho.InsertPhieuDatCho(MaPhieuDat, txtNguoiDat.Text, txtCMND.Text, txtDienThoai.Text, DateTime.Now);
                BLL.BLL_CT_PhieuDatCho.InsertCT_PhieuDatCho(MaPhieuDat, cbMaChuyenBay.Text, txtNguoiBay.Text, txtCMND_Di.Text, txtDienThoai_Di.Text, cbHangVe.Text, false);


                dt.Clear();
                dt = BLL.BLL_CT_Ghe.SelectAtCT_Ghe(cbMaChuyenBay.Text, cbHangVe.Text);

                foreach(DataRow row in dt.Rows)
                {
                    int n = Convert.ToInt32(row.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGheDat]);
                    n++;

                    int soghetrong = Convert.ToInt32(row.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGheTrong]);
                    soghetrong--;

                    BLL.BLL_CT_Ghe.UpdateCT_Ghe(cbMaChuyenBay.Text, cbHangVe.Text, Convert.ToInt32(row.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGhe]), n, soghetrong);
                }
                if (LaKhachHang)
                {
                    BLL.BLL_KhachHang.Insert_ChiTietKhachHang(MaKhachHang, MaPhieuDat);
                }

                MessageBox.Show("Đặt vé thành công");
                btnTaoMoi_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập bị trùng thông tin", "Lỗi");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            cbMaChuyenBay.Items.Clear();
            txtSanBayDi.Clear();
            txtSanBayDen.Clear();
            txtNgayGio.Clear();
            cbHangVe.Items.Clear();
            txtHangVe.Clear();
            txtGiaTien.Clear();
            txtTinhTrangVe.Clear();

            if (!LaKhachHang)
            {
                txtNguoiDat.Clear();
                txtCMND.Clear();
                txtDienThoai.Clear();
            }
            txtNguoiBay.Clear();
            txtCMND_Di.Clear();
            txtDienThoai_Di.Clear();
        }
    }
}
