using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BanVeChuyenBay.DAL
{
    class DAL_BCDoanhThuNam : DAL_KetNoi
    {
        public DataTable InBCDoanhThuNam(int nam)
        {
            SqlCommand cm = new SqlCommand("SELECT_BAOCAODOANHTHUTHANG_BY_NAM", connect());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            return dt;
        }
    }
}
