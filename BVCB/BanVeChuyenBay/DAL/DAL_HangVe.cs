using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_HangVe : DAL_KetNoi
    {
        public int InsertHangVe(String MaHangVe, String TenHangVe, float TiLeDonGia)
        {
            SqlCommand cm = new SqlCommand("INSERT_HANGVE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);
            cm.Parameters.AddWithValue("@TenHangVe", TenHangVe);
            cm.Parameters.AddWithValue("@GiaVe", TiLeDonGia);

            return cm.ExecuteNonQuery();
        }

        public int DeleteHangVe(String MaHangVe)
        {
            SqlCommand cm = new SqlCommand("DELETE_HANGVE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAllHangVe()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_HANGVE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public int UpdateHangVe(String MaHangVe, String TenHangVe, float TiLeDonGia)
        {
            SqlCommand cm = new SqlCommand("UPDATE_HANGVE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHangVe", MaHangVe);
            cm.Parameters.AddWithValue("@TenHangVe", TenHangVe);
            cm.Parameters.AddWithValue("@GiaVe", TiLeDonGia);

            return cm.ExecuteNonQuery();
        }
    }
}
