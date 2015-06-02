using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_CT_LichChuyenBay : DAL_KetNoi
    {
        public DataTable SelectAtCT_LichChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_AT_CT_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public int UpdateCT_LichChuyenBay(String MaChuyenBay, String MaSanBayTrungGian, int ThoiGianDung, String GhiChu)
        {
            SqlCommand cm = new SqlCommand("INSERT_CT_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaSanBayTrungGian", MaSanBayTrungGian);
            cm.Parameters.AddWithValue("@ThoiGianDung", ThoiGianDung);
            cm.Parameters.AddWithValue("@GhiChu", GhiChu);
            return cm.ExecuteNonQuery();
        }

        public int InsertCT_LichChuyenBay(string MaChuyenBay, string MaSanBayTrungGian, int ThoiGianDung, string GhiChu)
        {
            SqlCommand cm = new SqlCommand("INSERT_CT_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaSanBayTrungGian", MaSanBayTrungGian);
            cm.Parameters.AddWithValue("@ThoiGianDung", ThoiGianDung);
            cm.Parameters.AddWithValue("@GhiChu", GhiChu);
            return cm.ExecuteNonQuery();
        }


        public int DeleteCT_LichChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_CT_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            return cm.ExecuteNonQuery();
        }
    }
}
