using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_BaoCaoDoanhThuChuyenBay
    {
        private static DAL.DAL_BaoCaoDoanhThuChuyenBay bcdt = new DAL.DAL_BaoCaoDoanhThuChuyenBay();

        static public int InsertBaoCaoDoanhThuChuyenBay(int Thang, int Nam ,String MaChuyenBay, int SoVe, int DoanhThu, float TiLe)
        {
            return bcdt.InsertBaoCaoDoanhThuChuyenBay(Thang, Nam, MaChuyenBay, SoVe, DoanhThu, TiLe);
        }

        static public int UpdateBaoCaoDoanhThuChuyenBay(int Thang, int Nam, String MaChuyenBay, int SoVe, int DoanhThu, float TiLe)
        {
            return bcdt.UpdateBaoCaoDoanhThuChuyenBay(Thang,Nam ,MaChuyenBay, SoVe, DoanhThu, TiLe);
        }

        static public DataTable SelectAllDoanhThuChuyenBay(String MaChuyenBay)
        {
            return bcdt.SelectAllDoanhThuChuyenBay(MaChuyenBay);
        }

        static  public int DeleteBaoCaoDoanhThuChuyenBay(String MaChuyenBay)
        {
            return bcdt.DeleteBaoCaoDoanhThuChuyenBay(MaChuyenBay);
        }

        static public DataTable SelectAllDoanhThuChuyenBay(int Nam)
        {
            return bcdt.SelectAllDoanhThuChuyenBay(Nam);
        }
    }
}
