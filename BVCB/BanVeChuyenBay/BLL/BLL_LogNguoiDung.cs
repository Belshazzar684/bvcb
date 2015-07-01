using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.BLL
{
    class BLL_LogNguoiDung
    {
        public static DAL.DAL_LogNguoiDung log = new DAL.DAL_LogNguoiDung();

        public static int InsertLogNguoiDung(String TenDangNhap, DateTime ThoiGian, String HanhDong)
        {
            return log.InsertLogNguoiDung(TenDangNhap, ThoiGian, HanhDong);
        }

        public static DataTable SelectAllLogNguoDung()
        {
            return log.SelectAllLogNguoiDung();
        }
    }
}
