using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_BoDem
    {
        private static DAL.DAL_BoDem bd = new DAL.DAL_BoDem();

        //Tra ve so dem o bang TenBang
        public static int SelectBoDem(string TenBang)
        {
            return int.Parse(bd.SelectBoDem(TenBang).Rows[0]["SoDem"].ToString());
        }

    }
}
