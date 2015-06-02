using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_PhieuDatCho: DAL_KetNoi
    {
        public int InsertPhieuDatCho(String MaPhieuDatCho, String NguoiDat, String CMND, String DienThoai, DateTime dateTime)
        {
            SqlCommand cm = new SqlCommand("INSERT_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            cm.Parameters.AddWithValue("@NguoiDat", NguoiDat);
            cm.Parameters.AddWithValue("@CMND", CMND);
            cm.Parameters.AddWithValue("@DienThoai", DienThoai);
            cm.Parameters.AddWithValue("@NgayDat", dateTime);

            return cm.ExecuteNonQuery();
        }

        public int UpdatePhieuDatCho(String MaPhieuDatCho, String NguoiDat, String CMND, String DienThoai)
        {
            SqlCommand cm = new SqlCommand("UPDATE_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            cm.Parameters.AddWithValue("@NguoiDat", NguoiDat);
            cm.Parameters.AddWithValue("@CMND", CMND);
            cm.Parameters.AddWithValue("@DienThoai", DienThoai);

            return cm.ExecuteNonQuery();
        }

        public int DeletePhieuDatCho(String MaPhieuDatCho)
        {
            SqlCommand cm = new SqlCommand("DELETE_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaPhieuDatCho", MaPhieuDatCho);
            return cm.ExecuteNonQuery();
        }

        public DataTable SelectAllPhieuDatCho()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_PHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectMaxSTTPhieuDatCho()
        {
            SqlCommand cm = new SqlCommand("SELECT_MAX_MAPHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        //Nhat
        public DataTable SelectLastMaPhieuDatCho()
        {
            SqlCommand cm = new SqlCommand("SELECT_LAST_MAPHIEUDATCHO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
