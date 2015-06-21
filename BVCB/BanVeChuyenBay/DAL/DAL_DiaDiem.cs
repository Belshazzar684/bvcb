using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_DiaDiem : DAL_KetNoi
    {
        public int InsertDiaDiem(String QuocGia, String ThanhPho)
        {
            SqlCommand cm = new SqlCommand("INSERT_DIADIEM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            //Mã random chờ mã tự động
            cm.Parameters.AddWithValue("@MaDiaDiem", new Random().Next());
            cm.Parameters.AddWithValue("@QuocGia", QuocGia);
            cm.Parameters.AddWithValue("@ThanhPho", ThanhPho);

            return cm.ExecuteNonQuery();
        }

        public int UpdateDiaDiem(String MaDiaDiem, String QuocGia, String ThanhPho)
        {
            SqlCommand cm = new SqlCommand("UPDATE_DIADIEM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaDiaDiem", MaDiaDiem);
            cm.Parameters.AddWithValue("@QuocGia", QuocGia);
            cm.Parameters.AddWithValue("@ThanhPho", ThanhPho);

            return cm.ExecuteNonQuery();
        }

        public int DeleteDiaDiem(String MaDiaDiem)
        {
            SqlCommand cm = new SqlCommand("DELETE_DIADIEM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaDiaDiem", MaDiaDiem);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectDiaDiem(String MaDiaDiem)
        {
            SqlCommand cm = new SqlCommand("SELECT_DIADIEM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaDiaDiem", MaDiaDiem);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectMaDiaDiemBy_QuocGia_ThanhPho(String QuocGia, String ThanhPho)
        {
            SqlCommand cm = new SqlCommand("SELECT_MADIADIEM_BY_QUOCGIA_THANHPHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@QuocGia", QuocGia);
            cm.Parameters.AddWithValue("@ThanhPho", ThanhPho);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllDiaDiem()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_DIADIEM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectThanhPhoBy_QuocGia(String QuocGia)
        {
            SqlCommand cm = new SqlCommand("SELECT_THANHPHO_BY_QUOCGIA", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@QuocGia", QuocGia);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
    }
}
