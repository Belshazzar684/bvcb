using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_TuyenBay : DAL_KetNoi
    {
        public int InsertTuyenBay(String MaTuyenBay, String MaSanBayDi, String MaSanBayDen)
        {
            SqlCommand cm = new SqlCommand("INSERT_TUYENBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaTuyenBay", MaTuyenBay);
            cm.Parameters.AddWithValue("@MaSanBayDi", MaSanBayDi);
            cm.Parameters.AddWithValue("@MaSanBayDen", MaSanBayDen);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAllTuyenBay()
        {
            // ma tuyen bay, ma san bay di, ma san bay den

            SqlCommand cm = new SqlCommand("SELECT_ALL_TUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public int DeleteTuyenBay(String MaTuyenBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_TUYENBAY", connect());
            cm.CommandType = System.Data.CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaTuyenBay", MaTuyenBay);

            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAtColumnsTuyenBay(string column)
        {
            // ma tuyen bay, ma san bay di, ma san bay den

            SqlCommand cm = new SqlCommand("SELECT_AT_COLUMNS_TUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@TenColumn", column);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
    }
}
