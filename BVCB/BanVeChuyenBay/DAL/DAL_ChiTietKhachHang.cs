using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BanVeChuyenBay.DAL
{
    class DAL_ChiTietKhachHang : DAL_KetNoi
    {
        public int Insert(string MaNhanVien, String MaPhieuDatCho)
        {
            SqlCommand cmd = new SqlCommand("INSERT_CHITIETKHACHHANG", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            return cmd.ExecuteNonQuery();

        }

        public int Delete(string MaNhanVien)
        {
            SqlCommand cmd = new SqlCommand("DELETE_CHITIETKHACHHANG", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            return cmd.ExecuteNonQuery();
        }

        public DataTable SelectAll()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_CHITIETKHACHHANG", connect());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable SelectAllThongTin(string MaNhanVien)
        {
            SqlCommand cm = new SqlCommand("SELECT_CHITIETKHACHHANG_ALL", connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable SelectChiTietKhachHangByMaNhanVien(string MaNhanVien)
        {
            SqlCommand cm = new SqlCommand("SELECT_CHITIETKHACHHANG_BY_MANHANVIEN", connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
