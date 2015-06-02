using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BanVeChuyenBay.SqlHelper;
namespace BanVeChuyenBay.DAL
{
    class DAL_KetNoi
    {
        public SqlConnection connect()
        {
            return DatabaseManager.DbConnection.SqlConn;
        }
    }
}
