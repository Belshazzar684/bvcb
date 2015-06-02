using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BanVeChuyenBay.DAL
{
    class DAL_NhanVien:DAL_KetNoi
    {
        public DataTable Select_DangNhap(string TenDangNhap, string MatKhau)
        {
            SqlCommand cm = new SqlCommand("NHANVIEN_SELECT_DANGNHAP", connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cm.Parameters.AddWithValue("@MatKhau", MatKhau);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable SelectAll()
        {
            SqlCommand cm = new SqlCommand("NHANVIEN_SELECT_ALL", connect());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable SelectMaNhanVien(string MaNhanVien)
        {
            SqlCommand cm = new SqlCommand("NHANVIEN_SELECT_MANHANVIEN", connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public int Insert(string MaNhanVien, string TenNhanVien, string TenDangNhap, string MatKhau, int QuyenHan, string DiaChi, string DienThoai)
        {
            SqlCommand cmd = new SqlCommand("NHANVIEN_INSERT", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@QuyenHan", QuyenHan);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            return cmd.ExecuteNonQuery();
        }
        public int Delete(int MaNhanVien)
        {
            SqlCommand cmd = new SqlCommand("NHANVIEN_DELETE", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            return cmd.ExecuteNonQuery();
        }
        public int UpdateMatKhau(string MaNhanVien, string MatKhau)
        {
            SqlCommand cmd = new SqlCommand("UPDATE_NHANVIEN_MATKHAU", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            return cmd.ExecuteNonQuery();
        }
        public int Update(string MaNhanVien, string TenNhanVien, string TenDangNhap, string MatKhau, int QuyenHan, string DiaChi, string DienThoai)
        {
            SqlCommand cmd = new SqlCommand("UPDATE_NHANVIEN", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@QuyenHan", QuyenHan);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            return cmd.ExecuteNonQuery();
        }
    }
}
