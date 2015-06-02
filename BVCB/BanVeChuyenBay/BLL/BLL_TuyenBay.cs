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
    }
}
