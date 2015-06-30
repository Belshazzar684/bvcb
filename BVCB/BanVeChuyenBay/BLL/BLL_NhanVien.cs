using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_NhanVien
    {
        private static readonly DAL.DAL_NhanVien nv = new DAL.DAL_NhanVien();

        public static DataTable Select_DangNhap(string TenDangNhap, string MatKhau)
        {
            return nv.Select_DangNhap(TenDangNhap, MatKhau);
        }
        public static DataTable SelectALL()
        {
            return nv.SelectAll();
        }

        public static DataTable SelectALLKhachHang()
        {
            return nv.SelectAllKhachHang();
        }

        public static DataTable Select_MaNhanVien(string MaNhanVien)
        {
            return nv.SelectMaNhanVien(MaNhanVien);
        }
        public static int Insert(string MaNhanVien, string TenNhanVien, string TenDangNhap, string MatKhau, int QuyenHan, string DiaChi, string DienThoai)
        {
            // nhao nan, che bien du lieu roi goi ham tu tang DAL de luu tru
            return nv.Insert(MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, QuyenHan, DiaChi, DienThoai);
        }
        public static int Delete(int MaNhanVien)
        {
            return nv.Delete(MaNhanVien);

        }
        public static int UpdateMatKhau(string MaNhanVien, string MatKhau)
        {
            return nv.UpdateMatKhau(MaNhanVien, MatKhau);
        }
        public static int Update(string MaNhanVien, string TenNhanVien, string TenDangNhap, string MatKhau, int QuyenHan, string DiaChi, string DienThoai)
        {
            return nv.Update(MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, QuyenHan, DiaChi, DienThoai);
        }
    }
}
