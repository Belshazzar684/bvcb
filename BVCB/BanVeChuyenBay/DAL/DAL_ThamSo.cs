using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_ThamSo: DAL_KetNoi
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
        public int UpdateThamSo(int ThoiGianBayToiThieu, int SoSanBayTrungGian, int TGDungToiThieu, int TGDungToiDa, Boolean TGChamNhatHuyDatVe, int TGChamNhatDatVe)
        {
            SqlCommand cm = new SqlCommand("UPDATE_THAMSO", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@ThoiGianBayToiThieu", ThoiGianBayToiThieu);
            cm.Parameters.AddWithValue("@SoSanBayTrungGian", SoSanBayTrungGian);
            cm.Parameters.AddWithValue("@TGDungToiThieu", TGDungToiThieu);
            cm.Parameters.AddWithValue("@TGDungToiDa", TGDungToiDa);
            cm.Parameters.AddWithValue("@TGChamNhatHuyDatVe", TGChamNhatHuyDatVe);
            cm.Parameters.AddWithValue("@TGChamNhatDatVe", TGChamNhatDatVe);
            return cm.ExecuteNonQuery();
        }
    }
}
