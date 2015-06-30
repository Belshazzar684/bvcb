using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_ThongTinKhachHang : DAL_KetNoi
    {
        public int Insert(string MaNhanVien, DateTime NgaySinh, String GioiTinh, String CMND)
        {
            SqlCommand cmd = new SqlCommand("INSERT_THONGTINKHACHHANG", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@CMND", CMND);
            return cmd.ExecuteNonQuery();

        }

        public int Delete(string MaNhanVien)
        {
            SqlCommand cmd = new SqlCommand("DELETE_THONGTINKHACHHANG", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            return cmd.ExecuteNonQuery();
        }

        public int Update(string MaNhanVien, DateTime NgaySinh, String GioiTinh, String CMND)
        {
            SqlCommand cmd = new SqlCommand("UPDATE_THONGTINKHACHHANG", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@CMND", CMND);
            return cmd.ExecuteNonQuery();
        }

        public DataTable SelectAll()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_THONGTINKHACHHANG", connect());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable SelectThongTinKhachHangByMaNhanVien(string MaNhanVien)
        {
            SqlCommand cm = new SqlCommand("SELECT_THONGTINKHACHHANG_BY_MANHANVIEN", connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
