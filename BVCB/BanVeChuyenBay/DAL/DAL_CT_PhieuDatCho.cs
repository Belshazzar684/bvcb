using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_CT_PhieuDatCho: DAL_KetNoi
    {
        public int InsertCT_PhieuDatCho(String MaPhieuDatCho, String MaChuyenBay, String HanhKhachBay, String CMND, String DienThoai, String MaHangVe, Boolean Layve)
        {
            SqlCommand cm = new SqlCommand("INSERT_CT_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@HanhKhachBay", HanhKhachBay);
            cm.Parameters.AddWithValue("@CMND", CMND);
            cm.Parameters.AddWithValue("@DienThoai", DienThoai);
            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);
            cm.Parameters.AddWithValue("@LayVe", Layve);

            return cm.ExecuteNonQuery();
        }

        public int UpdateCT_PhieuDatCho(String MaPhieuDatCho, String MaChuyenBay, String HanhKhachBay, String CMND, String DienThoai, String MaHangVe, Boolean Layve)
        {
            SqlCommand cm = new SqlCommand("UPDATE_CT_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@HanhKhachBay", HanhKhachBay);
            cm.Parameters.AddWithValue("@CMND", CMND);
            cm.Parameters.AddWithValue("@DienThoai", DienThoai);
            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);
            cm.Parameters.AddWithValue("@LayVe", Layve);

            return cm.ExecuteNonQuery();
        }

        public int DeleteCT_PhieuDatCho(String MaPhieuDatCho)
        {
            SqlCommand cm = new SqlCommand("DELETE_CT_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            return cm.ExecuteNonQuery();
        }

        public int DeleteCT_PhieuDatCho_At_MaChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_CT_PHIEUDATCHO_BY_MACHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAtCT_PhieuDatCho(String MaChuyenBay, bool LayVe)
        {
            SqlCommand cm = new SqlCommand("SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY_LAYVE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@LayVe", LayVe);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAtCT_PhieuDatCho(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllCT_PhieuDatCho()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_CT_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
    }
}
