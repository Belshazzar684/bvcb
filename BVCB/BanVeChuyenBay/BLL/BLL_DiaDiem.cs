using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_DiaDiem
    {
        private static DAL.DAL_DiaDiem dd = new DAL.DAL_DiaDiem();

        //Select MaDiaDiem theo QuocGia va ThanhPho
        public static DataTable SelectMaDiaDiemBy_QuocGia_ThanhPho(String QuocGia, String ThanhPho)
        {
            return dd.SelectMaDiaDiemBy_QuocGia_ThanhPho(QuocGia, ThanhPho);
        }

        //Select địa điểm
        public static DataTable SelectDiaDiem(String MaDiaDiem)
        {
            return dd.SelectDiaDiem(MaDiaDiem);
        }

        //Select thành phố theo quốc gia
        public static DataTable SelectThanhPhoBy_QuocGia(String QuocGia)
        {
            return dd.SelectThanhPhoBy_QuocGia(QuocGia);
        }

        //Select tất cả địa điểm
        public static DataTable SelectAllDiaDiem()
        {
            return dd.SelectAllDiaDiem();
        }

        //Insert địa điểm
        public static int InsertDiaDiem(String QuocGia, String ThanhPho)
        {
            return dd.InsertDiaDiem(QuocGia, ThanhPho);
        }

        //Update địa điểm
        public static int UpdateDiaDiem(String MaDiaDiem, String QuocGia, String ThanhPho)
        {
            return dd.UpdateDiaDiem(MaDiaDiem, QuocGia, ThanhPho);
        }

        //Delete địa điểm
        public static int DeleteDiaDiem(String MaDiaDiem)
        {
            return dd.DeleteDiaDiem(MaDiaDiem);
        }
    }
}
