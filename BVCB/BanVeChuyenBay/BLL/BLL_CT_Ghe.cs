using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_CT_Ghe
    {
        static DAL.DAL_CT_Ghe ct_ghe = new DAL.DAL_CT_Ghe();
        static public int InsertCT_Ghe(string MaChuyenBay, string MaHangVe, int SoGhe, int SoGheDat, int SoGheTrong)
        {
            return ct_ghe.InsertCT_Ghe(MaChuyenBay, MaHangVe, SoGhe, SoGheDat, SoGheTrong);
        }

        public static int UpdateCT_Ghe(string MaChuyenBay, string MaHangVe, int SoGhe, int SoGheDat, int SoGheTrong)
        {
            return ct_ghe.UpdateCT_Ghe(MaChuyenBay, MaHangVe, SoGhe, SoGheDat, SoGheTrong);
        }

        static public int DeleteCT_Ghe(string MaChuyenBay)
        {
           return ct_ghe.DeleteCT_Ghe(MaChuyenBay);
        }
        public static DataTable SelectAtCT_Ghe(String MaChuyenBay, String MaHangVe)
         {
             return ct_ghe.SelectAtCT_Ghe(MaChuyenBay, MaHangVe);
         }

        public static DataTable SelectAtCT_Ghe(String MaChuyenBay)
        {
            return ct_ghe.SelectAtCT_Ghe(MaChuyenBay);
        }
    }
}
