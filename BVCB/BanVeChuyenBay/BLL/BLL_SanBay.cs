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

        public static int InsertSanBay(String MaSanBay, String TenSanBay, String MaDiaDiem)
        {
            return sanbay.InsertSanBay(MaSanBay, TenSanBay, MaDiaDiem);
        }

        public static int DeleteSanBayAt(String MaSanBay)
        {
            return sanbay.DeleteSanBayAt(MaSanBay);
        }

        public static int UpdateSanBayAt(String MaSanBay, String newTenSanBay, String MaDiaDiem)
        {
            return sanbay.UpdateSanBayAt(MaSanBay, newTenSanBay, MaDiaDiem);
        }

        public static DataTable SelectAllSanBay()
        {
            return sanbay.SelectAllSanBay();
        }

        ///hàm kiểm tra tuyến bay
        ///chức năng: kiểm tra tuyến bay đã tồn tại chưa
        ///mô tả: kiểm tra theo MaSanBay
        public static int KiemTraSanBay(String MaSanBay)
        {
            return sanbay.KiemTraSanBay(MaSanBay);
        }
    }
}
