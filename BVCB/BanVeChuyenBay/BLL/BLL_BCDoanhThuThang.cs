using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeChuyenBay.DAL;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_BCDoanhThuThang
    {
        private static DAL_BCDoanhThuThang bc = new DAL_BCDoanhThuThang();

        public static DataTable InBCDoanhThuThang(int thang, int nam)
        {
            return bc.InBCDoanhThuThang(thang, nam);
        }

        public static DataTable SelectBCDoanhThuThang(int thang, int nam)
        {
            return bc.SelectBaoCaoDoanhThuThang(thang, nam);
        }

        static  public int InsertBaoCaoDoanhThuThang(int Thang, int Nam, int SoChuyenBay, int DoanhThu, float TiLe)
        {
            return bc.InsertBaoCaoDoanhThuThang(Thang, Nam, SoChuyenBay, DoanhThu, TiLe);
        }

        static public int UpdateBaoCaoDoanhThuThang(int Thang, int Nam, int SoChuyenBay, int DoanhThu, float TiLe)
        {
            return bc.UpdateBaoCaoDoanhThuThang(Thang, Nam, SoChuyenBay, DoanhThu, TiLe);
        }
    }
}
