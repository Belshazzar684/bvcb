﻿using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace BanVeChuyenBay.SqlHelper
{
    public class DatabaseManager
    {
        private static bool _IsConnected = false;
        public static bool IsConnected
        {
            get { return DatabaseManager._IsConnected; }
            set { DatabaseManager._IsConnected = value; }
        }

        private static MyDatabaseConnection _MasterConnection;
        public static MyDatabaseConnection MasterConnection
        {
            get
            {
                if (_MasterConnection == null)
                    return new MyDatabaseConnection();
                else
                    return DatabaseManager._MasterConnection;
            }
            set { DatabaseManager._MasterConnection = value; }
        }

        private static MyDatabaseConnection _DbConnection;
        public static MyDatabaseConnection DbConnection
        {
            get 
            {
                if (_DbConnection == null)
                    return new MyDatabaseConnection();
                else
                    return DatabaseManager._DbConnection;
            }
            set { DatabaseManager._DbConnection = value; }
        }

        //-----------------------------------------
        //Desc: lấy tên tất cả cơ sở dữ liệu trong sql server
        //-----------------------------------------
        public static List<string> GetAllDatabaseName(string serverName)
        {
            try
            {
                Server srv = new Server(serverName);
                if (srv == null)
                    return null;
                else
                {
                    List<string> databaseNames = new List<string>();
                    foreach (Database db in srv.Databases)
                        if (!db.IsSystemObject)
                            databaseNames.Add(db.Name);
                    return databaseNames;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        //-----------------------------------------
        //Desc: kiểm tra tồn tại database
        //-----------------------------------------
        public static int CheckDatabaseExist(MyDatabaseConnection dbConn, string databaseName)
        {
            if (dbConn == null)
                return -1;

            string sql = "SELECT count (name) FROM master.sys.databases WHERE name = N'" + databaseName + "'";
            object obj = dbConn.ExecuteScalar(sql);
            if (obj == null)
                return -1;
            else
            {
                int dem;
                try
                {
                    dem = (int)obj;
                }
                catch { return -1; }

                return dem;
            }
        }

        //-----------------------------------------
        //Desc: tạo cơ sở dữ liệu
        //-----------------------------------------
        public static bool CreateDatabase(string serverName, string dataScript,
            string databaseName)
        {
            try
            {
                Server srv = new Server(serverName);
                if (srv == null)
                    return false;
                else
                {
                    string data = dataScript.Replace("Database_Name", databaseName);
                    srv.ConnectionContext.ExecuteNonQuery(data);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        //-----------------------------------------
        //Desc: Sao lưu cơ sở dữ liệu
        //-----------------------------------------
        public static bool BackupDatabase(MyDatabaseConnection dbConn, string fileName, string databaseName)
        {
            if (dbConn == null)
                return false;
            string sql = "BACKUP DATABASE " + databaseName
                       + " TO DISK ='" + fileName + "'";
            if (dbConn.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }

        //-----------------------------------------
        //Desc: Phục hồi dữ liệu
        //-----------------------------------------
        public static bool RestoreDatabase(MyDatabaseConnection dbConn, string databaseName, string fileName)
        {
            if (dbConn == null || dbConn.SqlConn == null)
                return false;
            try
            {
                Server srv;
                ServerConnection srvConn;
                srvConn = new ServerConnection();
                srvConn.ServerInstance = dbConn.SqlConn.DataSource;
                srv = new Server(srvConn);
                Restore res = new Restore();
                res.Devices.AddDevice(fileName, DeviceType.File);

                DataTable fileList = res.ReadFileList(srv);
                string dataLogicalName = fileList.Rows[0][0].ToString();
                string dataPhysicalName = fileList.Rows[0][1].ToString();
                string logLogicalName = fileList.Rows[1][0].ToString();
                string logPhysicalName = fileList.Rows[1][1].ToString();

                string sql = String.Empty;
                if (File.Exists(dataPhysicalName) && File.Exists(logPhysicalName))
                {
                    string newDataPhysicalName = String.Empty;
                    string newLogPhysicalName = String.Empty;

                    string folderPath = new FileInfo(fileName).DirectoryName;
                    DriveInfo driveInfo = new DriveInfo(folderPath);
                    if (driveInfo != null && String.Compare(driveInfo.Name, folderPath, true) == 0)
                    {
                        newDataPhysicalName = folderPath + databaseName + ".mdf";
                        newLogPhysicalName = folderPath + databaseName + "_Log.ldf";
                    }
                    else
                    {
                        newDataPhysicalName = folderPath + "\\" + databaseName + ".mdf";
                        newLogPhysicalName = folderPath + "\\" + databaseName + "_Log.ldf";
                    }

                    sql = "Restore Database " + databaseName + " FROM DISK = '" + fileName + "' WITH RECOVERY"
                        + ", MOVE '" + dataLogicalName + "' TO '" + newDataPhysicalName + "'"
                        + ", MOVE '" + logLogicalName + "' TO '" + newLogPhysicalName + "';";
                }
                else
                {
                    sql = "Restore Database " + databaseName + " FROM DISK = '" + fileName + "' WITH REPLACE;";
                }
                return dbConn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
