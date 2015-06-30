using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_KhachHang
    {
        private static readonly DAL.DAL_ThongTinKhachHang ttkh = new DAL.DAL_ThongTinKhachHang();
        private static readonly DAL.DAL_ChiTietKhachHang ctkh = new DAL.DAL_ChiTietKhachHang();

        public static DataTable Select_ThongTinKhachHang(string MaKhachHang)
        {
            return ttkh.SelectThongTinKhachHangByMaNhanVien(MaKhachHang);
        }

        public static DataTable Select_AllThongTinKhachHang()
        {
            return ttkh.SelectAll();
        }

        public static int Insert_ThongTinKhachHang(string MaKhachHang, DateTime NgaySinh, String GioiTinh, String CMND)
        {
            return ttkh.Insert(MaKhachHang, NgaySinh, GioiTinh, CMND);
        }

        public static int Delete_ThongTinKhachHang(string MaKhachHang)
        {
            return ttkh.Delete(MaKhachHang);
        }

        public static int Update_ThongTinKhachHang(string MaKhachHang, DateTime NgaySinh, String GioiTinh, String CMND)
        {
            return ttkh.Update(MaKhachHang, NgaySinh, GioiTinh, CMND);
        }

        //----------------------------
        public static DataTable Select_ChiTietKhachHang(string MaKhachHang)
        {
            return ctkh.SelectChiTietKhachHangByMaNhanVien(MaKhachHang);
        }

        //Lay du lieu cho form ChiTietKhachHang
        public static DataTable Select_ChiTietKhachHangAll(string MaKhachHang)
        {
            return ctkh.SelectAllThongTin(MaKhachHang);
        }

        public static DataTable Select_AllChiTietKhachHang()
        {
            return ctkh.SelectAll();
        }

        public static int Insert_ChiTietKhachHang(string MaKhachHang, String MaPhieuDatCho)
        {
            return ctkh.Insert(MaKhachHang, MaPhieuDatCho);
        }

        public static int Delete_ChiTietKhachHang(string MaKhachHang)
        {
            return ctkh.Delete(MaKhachHang);
        }
    }
}
