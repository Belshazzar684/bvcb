using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeChuyenBay;

namespace BanVeChuyenBay.GUI
{
    public partial class frmQuanLyChuyenBay : Form
    {
        DataTable DSLichChuyenBay;
        DataTable DSCT_Ghe;

        int MaxRows;
        public frmQuanLyChuyenBay()
        {
            InitializeComponent();
            LoadDanhSachChuyenBay();
        }

        void LoadDanhSachChuyenBay()
        {
            dtgvLichChuyenBay.Rows.Clear();
            DSLichChuyenBay = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBay();
            MaxRows = DSLichChuyenBay.Rows.Count;

            foreach (DataRow row in DSLichChuyenBay.Rows)
            {
                string TenHang = BLL.BLL_HangHangKhong.SelectHangHangKhong(row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaHang].ToString()).Rows[0].ItemArray[1].ToString();
                dtgvLichChuyenBay.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay], row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaTuyenBay],
                    row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.KhoiHanh], row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.ThoiGianBay],
                    row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.GiaVe], TenHang);

                if (dtgvLichChuyenBay.Rows.Count >= MaxRows - 1)
                    dtgvLichChuyenBay.AllowUserToAddRows = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmLichChuyenBay form = new frmLichChuyenBay();
            form.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaChuyenBay form = new frmXoaChuyenBay();
            form.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmSuaChuyenBay form = new frmSuaChuyenBay();
            form.Show();
        }

        private void dtgvLichChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtgvChiTietGhe.Rows.Clear();
                dtgvCTLichChuyenBay.Rows.Clear();

                DataGridViewRow row = dtgvLichChuyenBay.Rows[e.RowIndex];

                DSCT_Ghe = BLL.BLL_CT_Ghe.SelectAtCT_Ghe(row.Cells[0].Value.ToString());
                foreach (DataRow rows in DSCT_Ghe.Rows)
                {
                    dtgvChiTietGhe.Rows.Add(rows.ItemArray[(int)Support.BLL.Support.IDCTGhe.MaHangVe], rows.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGhe]);
                }

                DataTable dt = BLL.BLL_CT_LichChuyenBay.SelectAtCT_LichChuyenBay(row.Cells[0].Value.ToString());

                foreach (DataRow rows in dt.Rows)
                {
                    dtgvCTLichChuyenBay.Rows.Add(rows.ItemArray[1], rows.ItemArray[2], rows.ItemArray[3], rows.ItemArray[4]);
                }
            }
            catch
            { }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachChuyenBay();
        }
    }
}
