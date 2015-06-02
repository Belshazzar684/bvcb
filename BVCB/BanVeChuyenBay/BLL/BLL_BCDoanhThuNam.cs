using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeChuyenBay.DAL;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_BCDoanhThuNam
    {
        private static DAL_BCDoanhThuNam bc = new DAL_BCDoanhThuNam();

        public static DataTable InBCDoanhThuNam(int nam)
        {
            return bc.InBCDoanhThuNam(nam);
        }
    }
}
