using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeChuyenBay.SqlHelper
{
    public class Utilities
    {
        private static Utilities _Instance = null;
        public static Utilities Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Utilities();
                return _Instance;
            }
        }

        ///giải thuật md5
        ///chức năng: mã hóa chuỗi
        ///mô tả:
        private byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }

        ///hàm mã hóa chuỗi
        ///chức năng: 
        ///mô tả: sử dụng giải thuật md5
        public string MaHoa(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        ///hàm đọc file excel
        ///chức năng: 
        ///mô tả:
        public List<string> ReadFileExcel(string filePath)
        {
            try
            {
                IExcelDataReader FileExcel;
                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                
                //Câu lệnh dùng cho Excel 2007 trở lên
                FileExcel = ExcelReaderFactory.CreateOpenXmlReader(stream);

                if (!FileExcel.IsValid)
                {
                    if (FileExcel.IsClosed)
                        stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

                    //Câu lệnh dùng cho Excel 2003 trở xuống
                    FileExcel = ExcelReaderFactory.CreateBinaryReader(stream);
                }

                DataSet result = FileExcel.AsDataSet();
                FileExcel.IsFirstRowAsColumnNames = true;
                List<string> data = new List<string>();
                foreach (DataTable tbl in result.Tables)
                {
                    //dòng 1 là tên bảng, dòng 2 là tên cột
                    for (int i = 2; i < tbl.Rows.Count; i++)
                    {
                        for (int j = 0; j < tbl.Columns.Count; j++)
                            data.Add(tbl.Rows[i][j].ToString());
                    }
                }
                FileExcel.Close();
                return data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
