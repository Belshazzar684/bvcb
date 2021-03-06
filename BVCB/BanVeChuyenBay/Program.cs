﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeChuyenBay.GUI;
using BanVeChuyenBay.SqlHelper;
using Settings = BanVeChuyenBay.Properties.Settings;

namespace BanVeChuyenBay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!String.IsNullOrEmpty(Settings.Default.MasterConnectionString)
                && !String.IsNullOrEmpty(Settings.Default.ConnectionString))
            {
                DatabaseManager.MasterConnection = new MyDatabaseConnection(Settings.Default.MasterConnectionString);
                DatabaseManager.DbConnection = new MyDatabaseConnection(Settings.Default.ConnectionString);
                if (DatabaseManager.MasterConnection.Open())
                {
                    DatabaseManager.MasterConnection.Close();
                    if (DatabaseManager.DbConnection.Open())
                    {
                        DatabaseManager.DbConnection.Close();
                        DatabaseManager.IsConnected = true;
                    }
                }
            }

            if (!DatabaseManager.IsConnected)
                Application.Run(new ConnectionProperties());
            if (DatabaseManager.IsConnected)
            {
                DatabaseManager.DbConnection.SqlConn.Open();
                Application.Run(new frmMain());
            }
        }
    }
}
