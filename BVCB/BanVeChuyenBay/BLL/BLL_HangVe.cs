using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_HangVe
    {
        private static DAL.DAL_HangVe hv = new DAL.DAL_HangVe();

        public static int InsertHangVe(String MaHangVe, String TenHangVe, float TiLeDonGia)
        {
            return hv.InsertHangVe(MaHangVe, TenHangVe, TiLeDonGia);
        }

        public static int UpdateHangVe(String MaHangVe, String TenHangVe, float TiLeDonGia)
        {
            return hv.InsertHangVe(MaHangVe, TenHangVe, TiLeDonGia);
        }

        public static int DeleteHangVe(String MaHangVe)
        {
            return hv.DeleteHangVe(MaHangVe);
        }

        public static DataTable SelectAllHangVe()
        {
            return hv.SelectAllHangVe();
        }

        
    }
}
