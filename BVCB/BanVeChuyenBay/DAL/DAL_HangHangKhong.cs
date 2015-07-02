using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_HangHangKhong : DAL_KetNoi
    {
        public int InsertHangHangKhong(String MaHang, String TenHang)
        {
            SqlCommand cm = new SqlCommand("INSERT_HANGHANGKHONG", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHang", MaHang);
            cm.Parameters.AddWithValue("@TenHang", TenHang);

            return cm.ExecuteNonQuery();
        }

        public int UpdateHangHangKhong(String MaHang, String TenHang)
        {
            SqlCommand cm = new SqlCommand("UPDATE_HANGHANGKHONG", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHang", MaHang);
            cm.Parameters.AddWithValue("@TenHang", TenHang);

            return cm.ExecuteNonQuery();
        }

        public int DeleteHangHangKhong(String MaHang)
        {
            SqlCommand cm = new SqlCommand("DELETE_HANGHANGKHONG", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHang", MaHang);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectHangHangKhong(String MaHang)
        {
            SqlCommand cm = new SqlCommand("SELECT_HANGHANGKHONG", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaHang", MaHang);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelecHangHangKhongByMaChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_HANGHANGKHONG_BY_MACHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllHangHangKhong()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_HANGHANGKHONG", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
    }
}
