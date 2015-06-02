using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BanVeChuyenBay.DAL
{
    class DAL_BaoCaoDoanhThuChuyenBay: DAL_KetNoi
    {
        public int InsertBaoCaoDoanhThuChuyenBay(int Thang, int Nam ,String MaChuyenBay, int SoVe, int DoanhThu, float TiLe)
        {
            SqlCommand cm = new SqlCommand("INSERT_BAOCAODOANHTHUCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            
            cm.Parameters.AddWithValue("@Thang", Thang);
            cm.Parameters.AddWithValue("@Nam", Nam);
            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@SoVe", SoVe);
            cm.Parameters.AddWithValue("@DoanhThu", DoanhThu);
            cm.Parameters.AddWithValue("@TiLe", TiLe);

            return cm.ExecuteNonQuery();
        }

        public int UpdateBaoCaoDoanhThuChuyenBay(int Thang, int Nam, String MaChuyenBay, int SoVe, int DoanhThu, float TiLe)
        {
            SqlCommand cm = new SqlCommand("UPDATE_BAOCAODOANHTHUCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.AddWithValue("@Thang", Thang);
            cm.Parameters.AddWithValue("@Nam", Nam);
            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@SoVe", SoVe);
            cm.Parameters.AddWithValue("@DoanhThu", DoanhThu);
            cm.Parameters.AddWithValue("@TiLe", TiLe);

            return cm.ExecuteNonQuery();
        }

        public int DeleteBaoCaoDoanhThuChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_BAOCAODOANHTHUCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAllDoanhThuChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_TONGDOANHTHU_BY_MACHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllDoanhThuChuyenBay(int Nam)
        {
            SqlCommand cm = new SqlCommand("SELECT_BAOCAODOANHTHUCHUYENBAY_BY_NAM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Nam", Nam);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
    }
}
