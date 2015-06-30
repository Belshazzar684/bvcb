using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_TuyenBay
    {
        private static DAL.DAL_TuyenBay tb = new DAL.DAL_TuyenBay();

         public static int InsertTuyenBay(String MaTuyenBay, String MaSanBayDi, String MaSanBayDen)
        {
            return tb.InsertTuyenBay(MaTuyenBay, MaSanBayDi, MaSanBayDen);
        }

         public static DataTable SelectAllTuyenBay()
         {
             return tb.SelectAllTuyenBay();
         }

        static   public int DeleteTuyenBay(String MaTuyenBay)
         {
             return tb.DeleteTuyenBay(MaTuyenBay);
         }

        public static DataTable SelectAtColumnsTuyenBay(string columns)
        {
            return tb.SelectAtColumnsTuyenBay(columns);
        }

        ///hàm thêm tuyến bay
        ///chức năng: thêm tuyến bay khi đã có MaSanBayDi và MaSanBayDen
        ///mô tả: kiểm tra tồn tại trước khi thêm
        public static int InsertTuyenBay(String MaSanBayDi, String MaSanBayDen)
        {
            string MaTuyenBay = MaSanBayDi + "_" + MaSanBayDen;
            return tb.InsertTuyenBay(MaTuyenBay, MaSanBayDi, MaSanBayDen);
        }

        ///hàm kiểm tra tuyến bay
        ///chức năng: kiểm tra tuyến bay đã tồn tại chưa
        ///mô tả: kiểm tra theo MaSanBayDi và MaSanBayDen
        public static int KiemTraTuyenBay(String MaSanBayDi, String MaSanBayDen)
        {
            return tb.KiemTraTuyenBay(MaSanBayDi, MaSanBayDen);
        }
    }
}
