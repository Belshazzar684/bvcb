using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BanVeChuyenBay.GUI;
using BanVeChuyenBay.BLL;

namespace BanVeChuyenBay
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        static public string TenDangNhap;
        static public string MaNhanVien;
        public static string TienTe;
        public static double TiGia;
        private bool LaKhachHang = false;

        public static DevComponents.DotNetBar.TabControl  m_Tab;
        public frmMain()
        {
            InitializeComponent();
        }

        #region truyền tham số từ form con

        string ma;
        public void laydulieu()
        {
            lbTenDangNhap.Text = TenDangNhap;
            ma = MaNhanVien;
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (checkTab("Giơi thiệu") == false)
            {
                TabItem tab = tabControl.CreateTab("Giơi thiệu");
                tab.CloseButtonVisible = false;
                frmGioiThieu frm01 = new frmGioiThieu();
                frm01.Dock = DockStyle.Fill;
                frm01.FormBorderStyle = FormBorderStyle.None;
                frm01.TopLevel = false;
                tab.AttachedControl.Controls.Add(frm01);
                frm01.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }

            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                btDangNhap.Enabled = true;
                btDangXuat.Enabled = false;
                btDoiMatKhau.Enabled = false;
                btnSaoLuuPhucHoi.Enabled = false;
                // MessageBox.Show("Chưa đăng nhập");
            }
            else
            {
                btDangNhap.Enabled = false;
                btDangXuat.Enabled = true;
                btDoiMatKhau.Enabled = true;                
                // MessageBox.Show("da đăng nhập");
            }
            lbthoigian.Text = Convert.ToDateTime(DateTime.Today).ToString("dd/MM/yyyy");


            frmDangNhap f = new frmDangNhap();
            
            //f.truyendulieu = new frmDangNhap.TruyenLaiDuLieu(laydulieu);
            f.ShowDialog();
            laydulieu();
             
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                BatTat(false);
                btnTraCuu.Enabled = true;
                btnThoat.Enabled = true;
                btnTaoTaiKhoan.Enabled = true;
            }
            else
            {
                BatTat(true);
                btnTaoTaiKhoan.Enabled = false;
            }

            XuLyQuyenHan();

            TienTe = "VND";
            TiGia = 1;
        }

        #region Su ly Bật Tắt
        public void BatTat(Boolean xl)
        {
            rbpDanhMuc.Enabled = xl;
            rbpBaoCao.Enabled = xl;
            rbpThayDoi.Enabled = xl;
            rbpPhanQuyen.Enabled = xl;
            btnNhanLich.Enabled = xl;
            btnVe.Enabled = xl;
            btnDatVe.Enabled = xl;
            btnBaoCaoThang.Enabled = xl;
            btnBaoCaoNam.Enabled = xl;
            btnSaoLuuPhucHoi.Enabled = xl;
        }
        #endregion

        #region xuly quyen han

        public void BatTatQTV()
        {
            rbpDanhMuc.Enabled = false;
            rbpTraCuu.Enabled = false;
            rbpBaoCao.Enabled = false;
            rbpThayDoi.Enabled = false;
            rbpPhanQuyen.Enabled = true;
            btnNhanLich.Enabled = false;
            btnVe.Enabled = false;
            btnDatVe.Enabled = false;
            btnTraCuu.Enabled = false;
            btnBaoCaoThang.Enabled = false;
            btnBaoCaoNam.Enabled = false;
            btnSaoLuuPhucHoi.Enabled = true;
        }

        public void BatTatBGD()
        {
            rbpDanhMuc.Enabled = false;
            rbpTraCuu.Enabled = true;
            rbpBaoCao.Enabled = false;
            rbpThayDoi.Enabled = true;
            rbpPhanQuyen.Enabled = false;
            btnNhanLich.Enabled = false;
            btnVe.Enabled = false;
            btnDatVe.Enabled = false;
            btnTraCuu.Enabled = true;
            btnBaoCaoThang.Enabled = false;
            btnBaoCaoNam.Enabled = false;
            btnSaoLuuPhucHoi.Enabled = false;
        }

        public void BatTatNV()
        {
            rbpDanhMuc.Enabled = true;

            //--Nhat
            btLichChuyenBay.Enabled = true;
            btQLChuyenBay.Enabled = true;
            btQLSanBay.Enabled = true;
            btQLTuyenBay.Enabled = true;
            btnKhachHang.Enabled = true;
            btnVeDat.Enabled = false;
            btnDiaDiem.Enabled = true;
            btnHangHangKhong.Enabled = true;
            btnQDNhapFile.Enabled = true;
            //---

            rbpTraCuu.Enabled = true;
            rbpBaoCao.Enabled = true;
            rbpThayDoi.Enabled = false;
            rbpPhanQuyen.Enabled = false;
            btnNhanLich.Enabled = true;
            btnVe.Enabled = true;
            btnDatVe.Enabled = true;
            btnTraCuu.Enabled = true;
            btnBaoCaoThang.Enabled = true;
            btnBaoCaoNam.Enabled = true;
            btnSaoLuuPhucHoi.Enabled = false;
        }

        public void BatTatKH()
        {
            rbpDanhMuc.Enabled = true;

            //--Nhat
            btLichChuyenBay.Enabled = false;
            btQLChuyenBay.Enabled = false;
            btQLSanBay.Enabled = false;
            btQLTuyenBay.Enabled = false;
            btnKhachHang.Enabled = false;
            btnVeDat.Enabled = true;
            btnDiaDiem.Enabled = false;
            btnHangHangKhong.Enabled = false;
            btnQDNhapFile.Enabled = false;
            //---

            rbpTraCuu.Enabled = true;
            rbpBaoCao.Enabled = false;
            rbpThayDoi.Enabled = false;
            rbpPhanQuyen.Enabled = false;
            btnNhanLich.Enabled = false;
            btnVe.Enabled = true;
            btnDatVe.Enabled = true;
            btnTraCuu.Enabled = true;
            btnBaoCaoThang.Enabled = false;
            btnBaoCaoNam.Enabled = false;
            btnSaoLuuPhucHoi.Enabled = false;
        }

        public void XuLyQuyenHan()
        {
            DataTable td = BLL_NhanVien.Select_MaNhanVien(ma);
            if (td.Rows.Count > 0)
            {
                LaKhachHang = false;
                DataRow tr = td.Rows[0];

                int QuyenHan = Convert.ToInt32(tr["QuyenHan"]);
                //MessageBox.Show(QuyenHan.ToString());
                if (QuyenHan == 1)
                {
                    BatTatQTV();
                }
                else 
                    if (QuyenHan == 2)
                    {
                        BatTatBGD();
                    }
                    else
                    {
                        if (QuyenHan == 0)
                        {
                            BatTatNV();
                        }
                        else
                        {
                            BatTatKH();
                            LaKhachHang = true;
                        }
                    }
            
            }
        }
        #endregion

        #region đăng nhập
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        public void DangNhap()
        {
            frmDangNhap f = new frmDangNhap();
            
            f.ShowDialog();
            laydulieu();
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                BatTat(false);
            }
            else
            {
                BatTat(true);
                btDangNhap.Enabled = false;
                btDangXuat.Enabled = true;
                btDoiMatKhau.Enabled = true;
                btnTaoTaiKhoan.Enabled = false;
                XuLyQuyenHan();
            }
        }
        #endregion
           
        #region đăng xuất
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        public void DangXuat()
        {
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                btDangXuat.Enabled = false;
                btDoiMatKhau.Enabled = true;               
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    BatTat(false);
                    lbTenDangNhap.Text = "Chưa đăng nhập";
                    //for (int i = 0; i < TabCtrl_main.Tabs.Count-1; i++)
                    //{
                    // TabCtrl_main.Tabs.Remove(TabCtrl_main.SelectedTab);
                    tabControl.Tabs.Clear();
                    //}

                    if (checkTab("Giơi thiệu") == false)
                    {
                        TabItem tab = tabControl.CreateTab("Giơi thiệu");
                        tab.CloseButtonVisible = false;
                        frmGioiThieu frm01 = new frmGioiThieu();
                        frm01.Dock = DockStyle.Fill;
                        frm01.FormBorderStyle = FormBorderStyle.None;
                        frm01.TopLevel = false;
                        tab.AttachedControl.Controls.Add(frm01);
                        frm01.Show();
                        tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
                        btDangXuat.Enabled = false;
                        btDoiMatKhau.Enabled = false;                        
                    }
                    btDangNhap.Enabled = true;
                    btnTaoTaiKhoan.Enabled = true;
                    DangNhap();
                }
            }
        }
        #endregion

        #region đổi mật khẩu
        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(ma);
            frm.ShowDialog();
        }
        #endregion

        #region sự kiên thay đổi lbTenDangNhap
        private void lbTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            btDangNhap.Enabled = false;
            btDangXuat.Enabled = true;
            btDoiMatKhau.Enabled = true;
        }
     
        #endregion

        #region nhân viên
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL_NhanVien.Select_MaNhanVien(ma);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                int QuyenHan = Convert.ToInt32(dr["QuyenHan"]);
                //MessageBox.Show(QuyenHan.ToString());
                if (QuyenHan == 0)
                {
                    MessageBox.Show("Chỉ có quản trị viên mới được vào phần này");
                }
                else
                {

                    if (checkTab("Nhân viên") == false)
                    {
                        frmNhanVien form = new frmNhanVien();
                        AddTabControl(form, "Nhân viên");
                    }
                }
            }
        }
        #endregion

        public void AddTabControl(Form form, string nameTab)
        {
            TabItem tab = tabControl.CreateTab(nameTab);
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            tab.AttachedControl.Controls.Add(form);
            form.Show();
            tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            m_Tab = tabControl;
        }

        private bool checkTab(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Text == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void tabControl_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }

        private void btLichChuyenBay_Click(object sender, EventArgs e)
        {
            if(checkTab("Lịch Chuyến Bay")==false)
            {
                frmLichChuyenBay form = new frmLichChuyenBay();
                AddTabControl(form, "Lịch Chuyến Bay");
            }
        }

        private void btVeChuyenBay_Click(object sender, EventArgs e)
        {
            if (checkTab("Vé Chuyến Bay") == false)
            {
                frmVeChuyenBay form;
                if (!LaKhachHang)
                {
                    form = new frmVeChuyenBay();
                    
                }
                else
                {
                    form = new frmVeChuyenBay(MaNhanVien);
                }
                AddTabControl(form, "Vé Chuyến Bay");
            }
        }

        private void btPhieuDatCho_Click(object sender, EventArgs e)
        {
            if (checkTab("Phiếu Đặt Chỗ") == false)
            {
                frmPhieuDatCho form;
                if (!LaKhachHang)
                {
                    form = new frmPhieuDatCho();
                }
                else
                {
                    form = new frmPhieuDatCho(MaNhanVien);
                }
                AddTabControl(form, "Phiếu Đặt Chỗ");
            }
        }

        private void btTraCuuChuyenBay_Click(object sender, EventArgs e)
        {
            if (checkTab("Tra Cứu Chuyến Bay") == false)
            {
                frmTraCuuChuyenBay form = new frmTraCuuChuyenBay();
                AddTabControl(form, "Tra Cứu Chuyến Bay");
            }
        }

        private void btDTThang_Click(object sender, EventArgs e)
        {
            if (checkTab("Báo Cáo Doanh Thu Tháng") == false)
            {
                frmBCDoanhThuThang form = new frmBCDoanhThuThang();
                AddTabControl(form, "Báo Cáo Doanh Thu Tháng");
            }
        }

        private void btDTNam_Click(object sender, EventArgs e)
        {
            if (checkTab("Báo Cáo Doanh Thu Năm") == false)
            {
                frmBCDoanhThuNam form = new frmBCDoanhThuNam();
                AddTabControl(form, "Báo Cáo Doanh Thu Năm");
            }
          
        }

        private void btQuyDinh1_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định 1") == false)
            {
                frmThayDoiQD1 form = new frmThayDoiQD1();
                AddTabControl(form, "Thay Đổi Quy Định 1");
            }
        }

        private void btQuyDinh2_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định 2") == false)
            {
                frmThayDoiQD2 form = new frmThayDoiQD2();
                AddTabControl(form, "Thay Đổi Quy Định 2");
            }
        }

        private void btQuyDinh3_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định 3") == false)
            {
                frmThayDoiQD3 form = new frmThayDoiQD3();
                AddTabControl(form, "Thay Đổi Quy Định 3");
            }
        }

        private void btQLChuyenBay_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Chuyến Bay") == false)
            {
                frmQuanLyChuyenBay form = new frmQuanLyChuyenBay();
                AddTabControl(form, "Quản Lý Chuyến Bay");
            }
        }

        private void btQLSanBay_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Sân Bay") == false)
            {
                frmQuanLySanBay form = new frmQuanLySanBay();
                AddTabControl(form, "Quản Lý Sân Bay");
            }
        }

        private void btQLTuyenBay_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Tuyến Bay") == false)
            {
                frmQuanLyTuyenBay form = new frmQuanLyTuyenBay();
                AddTabControl(form, "Quản Lý Tuyến Bay");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {   
               this.Close();
        }

        private void btnNhanLich_Click(object sender, EventArgs e)
        {
            btLichChuyenBay_Click(sender, e);
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            btVeChuyenBay_Click(sender, e);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            btPhieuDatCho_Click(sender, e);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            btTraCuuChuyenBay_Click(sender, e);
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            btDTThang_Click(sender, e);
        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            btDTNam_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btThoat_Click(sender, e);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTin form = new frmThongTin();
            form.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        ///sự kiện click btnSaoLuuPhucHoi
        ///chức năng: hiển thị frmSaoLuuPhucHoi
        ///mô tả:
        private void btnSaoLuuDL_Click(object sender, EventArgs e)
        {
            new frmSaoLuuPhucHoi().Show();
        }

        ///sự kiện click btnChangeCurrency
        ///chức năng: hiển thị frmThayDoiTienTe
        ///mô tả:
        private void btnChangeCurrency_Click(object sender, EventArgs e)
        {
            new frmThayDoiTienTe().ShowDialog();
        }

        ///sự kiện click btnTDTienTe
        ///chức năng: hiển thị frmThayDoiTienTe
        ///mô tả:
        private void btnTDTienTe_Click(object sender, EventArgs e)
        {
            new frmThayDoiTienTe().ShowDialog();
        }

        ///sự kiện click btnKhachHang
        ///chức năng: hiển thị frmQuanLyKhachHang
        ///mô tả:
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Khách Hàng") == false)
            {
                frmQuanLyKhachHang form = new frmQuanLyKhachHang();
                AddTabControl(form, "Quản Lý Khách Hàng");
            }
        }

        ///sự kiện click btnHangHangKhong
        ///chức năng: hiển thị frmQuanLyHangHangKhong
        ///mô tả:
        private void btnHangHangKhong_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Hãng Hàng Không") == false)
            {
                frmQuanLyHangHangKhong form = new frmQuanLyHangHangKhong();
                AddTabControl(form, "Quản Lý Hãng Hàng Không");
            }
        }

        ///sự kiện click btnVeDat
        ///chức năng: hiển thị frmXemThongTinVe
        ///mô tả:
        private void btnVeDat_Click(object sender, EventArgs e)
        {
            if (checkTab("Thông Tin Vé Đặt") == false)
            {
                frmXemThongTinVe form = new frmXemThongTinVe();
                AddTabControl(form, "Thông Tin Vé Đặt");
            }
        }

        private void btnDiaDiem_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Địa Điểm") == false)
            {
                frmQuanLyDiaDiem form = new frmQuanLyDiaDiem();
                AddTabControl(form, "Quản Lý Địa Điểm");
            }
        }

        ///sự kiện click nút Định Dạng File Nhập
        ///chức năng: hiển thị thông tin hỗ trợ nhập file
        ///mô tả:
        private void btnQDNhapFile_Click(object sender, EventArgs e)
        {
            frmDinhDangFileNhap.Instance.Visible = true;
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            new frmTaoTaiKhoan().ShowDialog();
        }

    }
}