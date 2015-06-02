using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_BCDoanhThuThang : DAL_KetNoi
    {
        public DataTable InBCDoanhThuThang(int thang, int nam)
        {
            SqlCommand cm = new SqlCommand("SELECT_BAOCAODOANHTHUCHUYENBAY_BY_THANGNAM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Thang", thang);
            cm.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectBaoCaoDoanhThuThang(int thang, int nam)
        {
            SqlCommand cm = new SqlCommand("SELECT_BAOCAODOANHTHUTHANG_BY_THANGNAM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Thang", thang);
            cm.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public int InsertBaoCaoDoanhThuThang(int Thang, int Nam, int SoChuyenBay, int DoanhThu, float TiLe)
        {
            SqlCommand cm = new SqlCommand("INSERT_BAOCAODOANHTHUTHANG", connect());
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.AddWithValue("@Thang", Thang);
            cm.Parameters.AddWithValue("@Nam", Nam);
            cm.Parameters.AddWithValue("@SoChuyenBay", SoChuyenBay);
            cm.Parameters.AddWithValue("@DoanhThu", DoanhThu);
            cm.Parameters.AddWithValue("@TiLe", TiLe);

            return cm.ExecuteNonQuery();
        }

        public int UpdateBaoCaoDoanhThuThang(int Thang, int Nam, int SoChuyenBay, int DoanhThu, float TiLe)
        {
            SqlCommand cm = new SqlCommand("UPDATE_BAOCAODOANHTHUTHANG", connect());
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.AddWithValue("@Thang", Thang);
            cm.Parameters.AddWithValue("@Nam", Nam);
            cm.Parameters.AddWithValue("@SoChuyenBay", SoChuyenBay);
            cm.Parameters.AddWithValue("@DoanhThu", DoanhThu);
            cm.Parameters.AddWithValue("@TiLe", TiLe);

            return cm.ExecuteNonQuery();
        }
    }
}
