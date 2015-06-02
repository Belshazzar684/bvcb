using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BanVeChuyenBay.DAL
{
    class DAL_CT_Ghe: DAL_KetNoi
    {
        public int InsertCT_Ghe(string MaChuyenBay, string MaHangVe, int SoGhe, int SoGheDat, int SoGheTrong)
        {
            SqlCommand cm = new SqlCommand("INSERT_CT_GHE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);
            cm.Parameters.AddWithValue("@SoGhe", SoGhe);
            cm.Parameters.AddWithValue("@SoGheDat", SoGheDat);
            cm.Parameters.AddWithValue("@SoGheTrong", SoGheTrong);
            return cm.ExecuteNonQuery();
        }

        public int UpdateCT_Ghe(string MaChuyenBay, string MaHangVe, int SoGhe, int SoGheDat, int SoGheTrong)
        {
            SqlCommand cm = new SqlCommand("UPDATE_CT_GHE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);
            cm.Parameters.AddWithValue("@SoGhe", SoGhe);
            cm.Parameters.AddWithValue("@SoGheDat", SoGheDat);
            cm.Parameters.AddWithValue("@SoGheTrong", SoGheTrong);
            return cm.ExecuteNonQuery();
        }

         public int DeleteCT_Ghe(string MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_CT_GHE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
           
            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAtCT_Ghe(String MaChuyenBay, String MaHangVe)
        {
            SqlCommand cm = new SqlCommand("SELECT_AT_CT_GHE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAtCT_Ghe(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_AT_CT_GHE_BY_MACHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }


    }
}
