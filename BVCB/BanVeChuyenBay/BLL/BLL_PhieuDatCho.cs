using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_PhieuDatCho
    {
        static DAL.DAL_PhieuDatCho pdc = new DAL.DAL_PhieuDatCho();

        public static int InsertPhieuDatCho(String MaPhieuDatCho, String NguoiDat, String CMND, String DienThoai, DateTime dateTime)
        {
            return pdc.InsertPhieuDatCho(MaPhieuDatCho, NguoiDat, CMND, DienThoai, dateTime);
        }

        public static int UpdatePhieuDatCho(String MaPhieuDatCho, String NguoiDat, String CMND, String DienThoai)
        {
            return pdc.UpdatePhieuDatCho(MaPhieuDatCho, NguoiDat, CMND, DienThoai);
        }

        public static int DeletePhieuDatCho(String MaPhieuDatCho)
        {
            return pdc.DeletePhieuDatCho(MaPhieuDatCho);
        }

        public static DataTable SelectAllPhieuDatCho()
        {
            return pdc.SelectAllPhieuDatCho();
        }

        public static DataTable SelectMaxSTTPhieuDatCho()
        {
            return pdc.SelectMaxSTTPhieuDatCho();
        }
    }
}
