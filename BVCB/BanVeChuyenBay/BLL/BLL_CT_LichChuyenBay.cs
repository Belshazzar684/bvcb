using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_CT_LichChuyenBay
    {
        private static DAL.DAL_CT_LichChuyenBay ct_lcb = new DAL.DAL_CT_LichChuyenBay();

         public static DataTable SelectAtCT_LichChuyenBay(String MaChuyenBay)
        {
             return ct_lcb.SelectAtCT_LichChuyenBay(MaChuyenBay);
        }

        static public int UpdateCT_LichChuyenBay(String MaChuyenBay, String MaSanBayTrungGian, int ThoiGianDung, String GhiChu)
         {
             return ct_lcb.UpdateCT_LichChuyenBay(MaChuyenBay, MaSanBayTrungGian, ThoiGianDung, GhiChu);
         }

        static  public int DeleteCT_LichChuyenBay(String MaChuyenBay)
        {
            return ct_lcb.DeleteCT_LichChuyenBay(MaChuyenBay);
        }

        public static int InsertCT_LichChuyenBay(string MaChuyenBay, string MaSanBayTrungGian, int ThoiGianDung, string GhiChu)
        {
            return ct_lcb.InsertCT_LichChuyenBay(MaChuyenBay, MaSanBayTrungGian, ThoiGianDung, GhiChu);
        }
    }
}
