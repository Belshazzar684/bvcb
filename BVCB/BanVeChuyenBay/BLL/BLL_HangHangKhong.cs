using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_HangHangKhong
    {
        private static DAL.DAL_HangHangKhong hhk = new DAL.DAL_HangHangKhong();

        //Select hang hang khong theo ma chuyen bay
        public static DataTable SelecHangHangKhongByMaChuyenBay(String MaChuyenBay)
        {
            return hhk.SelecHangHangKhongByMaChuyenBay(MaChuyenBay);
        }

        //Select hang hang khong
        public static DataTable SelectHangHangKhong(String MaHang)
        {
            return hhk.SelectHangHangKhong(MaHang);
        }

        //Select tất cả hang hang khong
        public static DataTable SelectAllHangHangKhong()
        {
            return hhk.SelectAllHangHangKhong();
        }

        //Insert hang hang khong
        public static int InsertHangHangKhong(String MaHang, String TenHang)
        {
            return hhk.InsertHangHangKhong(MaHang, TenHang);
        }

        //Update hang hang khong
        public static int UpdateHangHangKhong(String MaHang, String TenHang)
        {
            return hhk.UpdateHangHangKhong( MaHang, TenHang);
        }

        //Delete hang hang khong
        public static int DeleteHangHangKhong(String MaHang)
        {
            return hhk.DeleteHangHangKhong(MaHang);
        }

        //Kiem tra hang hang khong
        //True la chua ton tai, false la da ton tai
        public static bool KiemTraHang(String TenHang)
        {
            foreach (DataRow row in hhk.SelectAllHangHangKhong().Rows)
            {
                if (row["TenHang"].ToString().ToLower() == TenHang.ToLower())
                    return false;
            }
            return true;
        }
    }
}
