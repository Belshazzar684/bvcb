using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources = BanVeChuyenBay.Properties.Resources;

namespace BanVeChuyenBay.SqlHelper
{
    public class MyDatabaseConnection
    {
        //-----------------------------------------
        //Desc: Kết nối với csdl sql
        //-----------------------------------------
        private SqlConnection _SqlConn;
        public SqlConnection SqlConn
        {
            get { return _SqlConn; }
            set { _SqlConn = value; }
        }

        public MyDatabaseConnection()
        {
            _SqlConn = new SqlConnection();
        }

        public MyDatabaseConnection(String connectionString)
        {
            _SqlConn = new SqlConnection(connectionString);
        }

        //-----------------------------------------
        //Desc: Mở kết nối
        //-----------------------------------------
        public bool Open()
        {
            try
            {
                _SqlConn.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //-----------------------------------------
        //Desc: Đóng kết nối
        //-----------------------------------------
        public bool Close()
        {
            try
            {
                _SqlConn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //-----------------------------------------
        //Desc: thực thi stored procedure trả về datatable
        //-----------------------------------------
        public DataTable ExecuteStoredProcedure(string spName, params SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCmd = new SqlCommand(spName, _SqlConn) { CommandType = CommandType.StoredProcedure };
            if (sqlParameters != null && sqlParameters.Length > 0)
            {
                foreach (SqlParameter sqlParam in sqlParameters)
                {
                    try
                    {
                        sqlCmd.Parameters.Add(sqlParam);
                    }
                    catch { return null; }
                }
            }

            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            if (Open())
            {
                //đổ dữ liệu vào data table
                try
                {
                    sqlDa.Fill(dt);
                }
                catch
                {
                    Close();
                    return null;
                }
                Close();
            }
            else
                return null;
            return dt;
        }

        //-----------------------------------------
        //Desc: thực thi stored procedure trả về true/false
        //-----------------------------------------
        public bool ExecuteStoredProcedureNonQuery(string spName, params SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCmd = new SqlCommand(spName, _SqlConn) { CommandType = CommandType.StoredProcedure };
            if (sqlParameters != null && sqlParameters.Length > 0)
            {
                foreach (SqlParameter sqlParam in sqlParameters)
                {
                    try
                    {
                        sqlCmd.Parameters.Add(sqlParam);
                    }
                    catch { return false; }
                }
            }
            if (Open())
            {
                try
                {
                    sqlCmd.ExecuteNonQuery();
                }
                catch
                {
                    Close();
                    return false;
                }
                Close();
                return true;
            }
            else
                return false;
        }

        //-----------------------------------------
        //Desc: thực thi store procedure trả về số lượng
        //-----------------------------------------
        public object ExecuteStoredProcedureScalar(string spName, params SqlParameter[] sqlParameters)
        {
           SqlCommand sqlCmd = new SqlCommand(spName, _SqlConn) { CommandType = CommandType.StoredProcedure };
            if (sqlParameters != null && sqlParameters.Length > 0)
            {
                foreach (SqlParameter sqlParam in sqlParameters)
                {
                    try
                    {
                        sqlCmd.Parameters.Add(sqlParam);
                    }
                    catch { return null; }
                }
            }
            object obj = new object();
            if (Open())
            {
                try
                {
                    obj = sqlCmd.ExecuteScalar();
                }
                catch
                {
                    Close();
                    return null;
                }
                Close();
                return obj;
            }
            else
                return null;
        }

        //-----------------------------------------
        //Desc: lấy dữ liệu thông qua câu try vấn sql, thất bại trở về null
        //-----------------------------------------
        public DataTable ExecuteQuery(string sql)
        {
            SqlCommand sqlCmd = new SqlCommand(sql, _SqlConn) { CommandType = CommandType.Text };
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            if (Open())
            {
                //đổ dữ liệu vào data table
                try
                {
                    sqlDa.Fill(dt);
                }
                catch
                {
                    Close();
                    return null;
                }
                Close();
            }
            else
                return null;
            return dt;
        }

        //-----------------------------------------
        //Desc: thực thi câu lệnh sql, dùng cho insert, update, delete
        //-----------------------------------------
        public bool ExecuteNonQuery(string sql)
        {
           SqlCommand sqlCmd = new SqlCommand(sql, _SqlConn) { CommandType = CommandType.Text };
            if (Open())
            {
                try
                {
                    sqlCmd.ExecuteNonQuery();
                }
                catch
                {
                    Close();
                    return false;
                }
                Close();
                return true;
            }
            else
                return false;
        }

        //-----------------------------------------
        //Desc: thực thi câu lệnh sql, dùng cho đếm số lượng, ...
        //-----------------------------------------
        public object ExecuteScalar(string sql)
        {
           SqlCommand sqlCmd = new SqlCommand(sql, _SqlConn) { CommandType = CommandType.Text };
            object obj;
            if (Open())
            {
                try
                {
                    obj = sqlCmd.ExecuteScalar();
                }
                catch
                {
                    Close();
                    return null;
                }
                Close();
                return obj;
            }
            else
                return null;
        }

        //-----------------------------------------
        //Desc: Kiểm tra tồn tại các bảng trong csdl
        //-----------------------------------------
        public bool CheckTable()
        {
            try
            {
                DataTable dt = ExecuteQuery(Resources.CheckTable);
                if (dt != null && dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
