using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BanVeChuyenBay.SqlHelper;

namespace BanVeChuyenBay.DAL
{
    class DAL_LichChuyenBay : DAL_KetNoi
    {
        public DataTable SelectAllThamSo()
        {
            // so san bay trung gian toi da, tg dung toi da, tg dung toi thieu, tg bay toi thieu, tg cham nhat dat ve, tg huy dat ve

            SqlCommand cm = new SqlCommand("SELECT_ALL_THAMSO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public int InsertLichChuyenBay(string MaChuyenBay, string MaTuyenBay, DateTime KhoiHanh, int ThoiGianBay, int DonGia)
        {
            SqlCommand cm = new SqlCommand("INSERT_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaTuyenBay", MaTuyenBay);
            cm.Parameters.AddWithValue("@KhoiHanh", KhoiHanh);
            cm.Parameters.AddWithValue("@ThoiGianBay", ThoiGianBay);
            cm.Parameters.AddWithValue("@GiaVe", DonGia);
            return cm.ExecuteNonQuery();
        }


        public int DeleteLichChuyenBay(string MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("DELETE_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
         
            return cm.ExecuteNonQuery();
        }

        
        public DataTable SelectAllLichChuyenBayNotPlane()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_LICHCHUYENBAY_NOTPLANE", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllLichChuyenBay()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectTraCuuWithDateTime(DateTime tuNgay, DateTime denNgay)
        {
            SqlCommand cm = new SqlCommand("SELECT_TRACUUCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@TuNgay", tuNgay);
            cm.Parameters.AddWithValue("@DenNgay", denNgay);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllLichChuyenBayPlaned()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_LICHCHUYENBAY_PLANED", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAtLichChuyenBay(String MaChuyenBay)
        {
            SqlCommand cm = new SqlCommand("SELECT_AT_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }

        public DataTable SelectAllLichChuyenBay_By_QD3()
        {
            SqlCommand cm = new SqlCommand("SELECT_ALL_LICHCHUYENBAY_BY_QD3", connect());
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
        
        public int UpdateLichChuyenBay(string MaChuyenBay, string MaTuyenBay, DateTime KhoiHanh, int ThoiGianBay, int DonGia)
        {
            SqlCommand cm = new SqlCommand("UPDATE_LICHCHUYENBAY", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
            cm.Parameters.AddWithValue("@MaTuyenBay", MaTuyenBay);
            cm.Parameters.AddWithValue("@KhoiHanh", KhoiHanh);
            cm.Parameters.AddWithValue("@ThoiGianBay", ThoiGianBay);
            cm.Parameters.AddWithValue("@GiaVe", DonGia);
            return cm.ExecuteNonQuery();
        }

        ///Hàm tìm kiếm lịch chuyến bay
        ///chức năng: tìm kiếm theo các điều kiện được chọn
        ///mô tả: gọi stored procedure thực hiện tìm kiếm
        public DataTable SearchLichChuyenBay(string maChuyenBay, string maSanBayDi, string maSanBayDen,
            DateTime? ngayKhoiHanhMin, DateTime? ngayKhoiHanhMax, double? giaVeMin, double? giaVeMax, bool? tinhTrangGheTrong)
        {
            string spName = "[dbo].[SELECT_TRACUUCHUYENBAY]";
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            SqlParameter sqlprMaChuyenBay = new SqlParameter("@MaChuyenBay", SqlDbType.VarChar, 10) { Value = maChuyenBay };
            SqlParameter sqlprMaSBDi = new SqlParameter("@MaSanBayDi", SqlDbType.VarChar, 10) { Value = maSanBayDi };
            SqlParameter sqlprMaSBDen = new SqlParameter("@MaSanBayDen", SqlDbType.VarChar, 10) { Value = maSanBayDen };
            SqlParameter sqlprNgayKhoiHanhMin = new SqlParameter("@NgayKhoiHanhMin", SqlDbType.DateTime) { Value = ngayKhoiHanhMin };
            SqlParameter sqlprNgayKhoiHanhMax = new SqlParameter("@NgayKhoiHanhMax", SqlDbType.DateTime) { Value = ngayKhoiHanhMax };
            SqlParameter sqlprGiaVeMin = new SqlParameter("@GiaVeMin", SqlDbType.Money) { Value = giaVeMin };
            SqlParameter sqlprGiaVeMax = new SqlParameter("@GiaVeMax", SqlDbType.Money) { Value = giaVeMax };
            SqlParameter sqlprTrinhTrangGhe = new SqlParameter("@TinhTrangGheTrong", SqlDbType.Bit) { Value = tinhTrangGheTrong };

            sqlParams.Add(sqlprMaChuyenBay);
            sqlParams.Add(sqlprMaSBDi);
            sqlParams.Add(sqlprMaSBDen);
            sqlParams.Add(sqlprNgayKhoiHanhMin);
            sqlParams.Add(sqlprNgayKhoiHanhMax);
            sqlParams.Add(sqlprGiaVeMin);
            sqlParams.Add(sqlprGiaVeMax);
            sqlParams.Add(sqlprTrinhTrangGhe);
            return DatabaseManager.DbConnection.ExecuteStoredProcedure(spName, sqlParams.ToArray());
        }
    }
}
