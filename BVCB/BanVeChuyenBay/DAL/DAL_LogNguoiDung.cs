using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_LogNguoiDung : DAL_KetNoi
    {
        public DataTable SelectAllLogNguoiDung()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_LOGNGUOIDUNG", connect());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public int InsertLogNguoiDung(String TenDangNhap, DateTime ThoiGian, String HanhDong)
        {
            SqlCommand cmd = new SqlCommand("INSERT_LOGNGUOIDUNG", connect());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@ThoiGian", ThoiGian);
            cmd.Parameters.AddWithValue("@HanhDong", HanhDong);

            return cmd.ExecuteNonQuery();

        }
    }
}
