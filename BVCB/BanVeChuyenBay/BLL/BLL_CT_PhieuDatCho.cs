using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_CT_PhieuDatCho
    {
        static DAL.DAL_CT_PhieuDatCho ct_pdc = new DAL.DAL_CT_PhieuDatCho();

        public static int InsertCT_PhieuDatCho(String MaPhieuDatCho, String MaChuyenBay, String HanhKhachBay, String CMND, String DienThoai,String MaHangVe, Boolean Layve)
        {
            return ct_pdc.InsertCT_PhieuDatCho(MaPhieuDatCho, MaChuyenBay, HanhKhachBay, CMND, DienThoai,MaHangVe, Layve);
        }

         public static int UpdateCT_PhieuDatCho(String MaPhieuDatCho, String MaChuyenBay, String HanhKhachBay, String CMND, String DienThoai, String MaHangVe, Boolean Layve)
        {
            return ct_pdc.UpdateCT_PhieuDatCho(MaPhieuDatCho, MaChuyenBay, HanhKhachBay, CMND, DienThoai, MaHangVe, Layve);
        }

         public static int DeleteCT_PhieuDatCho(String MaPhieuDatCho)
         {
             return ct_pdc.DeleteCT_PhieuDatCho(MaPhieuDatCho);
         }

           static public int DeleteCT_PhieuDatCho_At_MaChuyenBay(String MaChuyenBay)
         {
             return ct_pdc.DeleteCT_PhieuDatCho_At_MaChuyenBay(MaChuyenBay);
         }
        public static DataTable SelectAllCT_PhieuDatCho()
         {
             return ct_pdc.SelectAllCT_PhieuDatCho();
         }

        public static DataTable SelectAtCT_PhieuDatCho(String MaChuyenBay, bool LayVe)
        {
            return ct_pdc.SelectAtCT_PhieuDatCho(MaChuyenBay, LayVe);
        }

        public static DataTable SelectAtCT_PhieuDatCho(String MaChuyenBay)
        {
            return ct_pdc.SelectAtCT_PhieuDatCho(MaChuyenBay);
        }
    }
}
