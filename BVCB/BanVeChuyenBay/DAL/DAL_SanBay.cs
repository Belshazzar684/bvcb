using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BanVeChuyenBay.DAL
{
    class DAL_SanBay : DAL_KetNoi
    {
        public int InsertSanBay(String MaSanBay, String TenSanBay, String MaDiaDiem)
        {
            SqlCommand cm = new SqlCommand("INSERT_SANBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaSanBay", MaSanBay);
            cm.Parameters.AddWithValue("@TenSanBay", TenSanBay);
            cm.Parameters.AddWithValue("@MaDiaDiem", MaDiaDiem);

            return cm.ExecuteNonQuery();
        }

        public int DeleteSanBayAt(String MaSanBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_SANBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaSanBay", MaSanBay);

            return cm.ExecuteNonQuery();
        }

        public int UpdateSanBayAt(String MaSanBay, String newTenSanBay, String MaDiaDiem)
        {
            SqlCommand cm = new SqlCommand("UPDATE_SANBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaSanBay", MaSanBay);
            cm.Parameters.AddWithValue("@TenSanBay", newTenSanBay);
            cm.Parameters.AddWithValue("@MaDiaDiem", MaDiaDiem);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAllSanBay()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_SANBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        ///hàm kiểm tra sân bay
        ///chức năng: kiểm tra sân bay đã tồn tại chưa
        ///mô tả: kiểm tra theo MaSanBay
        public int KiemTraSanBay(String MaSanBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_EXIST_SANBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaSanBay", MaSanBay);
            int count = (int)cm.ExecuteScalar();
            return count;
        }
    }
}
