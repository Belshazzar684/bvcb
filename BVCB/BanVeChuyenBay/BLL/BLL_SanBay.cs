using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeChuyenBay.DAL;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_SanBay
    {
        static DAL_SanBay sanbay = new DAL_SanBay();

        public static int InsertSanBay(String MaSanBay, String TenSanBay)
        {
            return sanbay.InsertSanBay(MaSanBay, TenSanBay);
        }

        public static int DeleteSanBayAt(String MaSanBay)
        {
            return sanbay.DeleteSanBayAt(MaSanBay);
        }

        public static int UpdateSanBayAt(String MaSanBay, String newTenSanBay)
        {
            return sanbay.UpdateSanBayAt(MaSanBay, newTenSanBay);
        }

        public static DataTable SelectAllSanBay()
        {
            return sanbay.SelectAllSanBay();
        }
    }
}
