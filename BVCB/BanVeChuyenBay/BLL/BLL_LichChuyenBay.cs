using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeChuyenBay.DAL;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_LichChuyenBay
    {
        private static DAL_LichChuyenBay lcb = new DAL_LichChuyenBay();
        public static DataTable SelectAllThamSo()
        {
            return lcb.SelectAllThamSo();
        }

        static  public int DeleteLichChuyenBay(string MaChuyenBay)
        {
            return lcb.DeleteLichChuyenBay(MaChuyenBay);
        }
        public static DataTable SelectAllLichChuyenBay()
        {
            return lcb.SelectAllLichChuyenBay();
        }

        public static DataTable SelectTraCuuWithDateTime(DateTime tuNgay, DateTime denNgay)
        {
            return lcb.SelectTraCuuWithDateTime(tuNgay, denNgay);
        }
        public static int InsertLichChuyenBay(string MaChuyenBay, string MaTuyenBay, DateTime KhoiHanh, int ThoiGianBay, int DonGia)
        {
            return lcb.InsertLichChuyenBay(MaChuyenBay, MaTuyenBay, KhoiHanh, ThoiGianBay, DonGia);
        }

        public static DataTable SelectAllLichChuyenBayNotPlane()
        {
            return lcb.SelectAllLichChuyenBayNotPlane();
        }

        public static DataTable SelectAllLichChuyenBayPlaned()
        {
            return lcb.SelectAllLichChuyenBayPlaned();
        }

        public static DataTable SelectAllLichChuyenBay_BY_QD3()
        {
            return lcb.SelectAllLichChuyenBay_By_QD3();
        }

        public static DataTable SelectAtLichChuyenBay(String MaChuyenBay)
        {
            return lcb.SelectAtLichChuyenBay(MaChuyenBay);
        }

        static public int UpdateLichChuyenBay(string MaChuyenBay, string MaTuyenBay, DateTime KhoiHanh, int ThoiGianBay, int DonGia)
        {
            return lcb.UpdateLichChuyenBay(MaChuyenBay, MaTuyenBay, KhoiHanh, ThoiGianBay, DonGia);
        }

        ///Hàm tìm kiếm lịch chuyến bay
        ///chức năng: tìm kiếm theo các điều kiện được chọn
        ///mô tả: gọi đến hàm SearchLichChuyenBay của lớp DAL_LichChuyenBay
        public static DataTable SearchLichChuyenBay(string maChuyenBay, string maSanBayDi, string maSanBayDen,
            DateTime? ngayKhoiHanhMin, DateTime? ngayKhoiHanhMax, double? giaVeMin, double? giaVeMax, bool? tinhTrangGheTrong)
        {
            return lcb.SearchLichChuyenBay(maChuyenBay, maSanBayDi, maSanBayDen, ngayKhoiHanhMin,
                ngayKhoiHanhMax, giaVeMin, giaVeMax, tinhTrangGheTrong);
        }
    }
}
