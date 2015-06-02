using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanVeChuyenBay.BLL
{
    class BLL_ThamSo
    {
        private static DAL.DAL_ThamSo ts = new DAL.DAL_ThamSo();

        static public DataTable SelectAllThamSo()
        {
            return ts.SelectAllThamSo();
        }

        static public int UpdateThamSo(int ThoiGianBayToiThieu, int SoSanBayTrungGian, int TGDungToiThieu, int TGDungToiDa)
        {
            DataTable dt = SelectAllThamSo();
            Boolean TGChamNhatHuyDatVe = Convert.ToBoolean(dt.Rows[0].ItemArray[4]);
            int TGChamNhatDatVe = Convert.ToInt32(dt.Rows[0].ItemArray[5]);
            return ts.UpdateThamSo(ThoiGianBayToiThieu, SoSanBayTrungGian, TGDungToiThieu, TGDungToiDa, TGChamNhatHuyDatVe, TGChamNhatDatVe);
        }

        static public int UpdateThamSo(Boolean TGChamNhatHuyDatVe, int TGChamNhatDatVe)
        {
            DataTable dt = SelectAllThamSo();
            
            int ThoiGianBayToiThieu = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            int SoSanBayTrungGian = Convert.ToInt32(dt.Rows[0].ItemArray[1]);
            int TGDungToiThieu = Convert.ToInt32(dt.Rows[0].ItemArray[2]);
            int TGDungToiDa = Convert.ToInt32(dt.Rows[0].ItemArray[3]);
            
            return ts.UpdateThamSo(ThoiGianBayToiThieu, SoSanBayTrungGian, TGDungToiThieu, TGDungToiDa, TGChamNhatHuyDatVe, TGChamNhatDatVe);
        }
    }
}
