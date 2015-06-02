using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.BLL
{
    public static class Support
    {
        public const String MaPhieuDat = "MP";

        public enum IDTuyenBay
        {
            MaTuyenBay = 0,
            MaSanBayDi = 1,
            MaSanBayDen = 2
        }

        public enum IDThamSo
        {
            MaxSoSanBayTG = 0,
            MaxTGDung = 1,
            MinTGDung = 2,
            MinTGBay = 3,
            TGDatVe = 4,
            TGHuyVe = 5
        }

        public enum IDSanBay
        {
            MaSanBay = 0,
            TenSanBay = 1
        }

        public enum IDHangVe
        {
            MaHangVe = 0,
            TenHangVe = 1,
            TiLeDonGia
        }

        public enum IDLichChuyenBay
        {
            MaChuyenBay = 0,
            MaTuyenBay,
            KhoiHanh,
            ThoiGianBay,
            GiaVe
        }

        public enum IDCTLichChuyenBay
        {
            MaChuyenBay = 0,
            MaSanBayTrungGian,
            ThoiGianDung,
            GhiChu
        }
        public enum IDCTGhe
        {
            MaChuyenBay = 0,
            MaHangVe,
            SoGhe,
            SoGheDat, 
            SoGheTrong
        }

        public enum IDPhieuDatCho
        {
            MaPhieuDat = 0,
            NguoiDat,
            CMND,
            DienThoai,
            NgayDat
        }

        public enum IDCTPhieuDatCho
        {
            MaPhieuDat = 0,
            MaChuyenBay,
            HanhKhachBay,
            CMND,
            DienThoai,
            MaHangVe
        }
    }
}
