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
    public partial class frmThayDoiQD2 : Form
    {
        public frmThayDoiQD2()
        {
            InitializeComponent();
            LoadDanhSachHangVe();
        }

        void LoadDanhSachHangVe()
        {
            dataGridView1.Rows.Clear();

            DataTable dt = BLL.BLL_HangVe.SelectAllHangVe();

            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDHangVe.MaHangVe], row.ItemArray[(int)Support.BLL.Support.IDHangVe.TenHangVe], row.ItemArray[(int)Support.BLL.Support.IDHangVe.TiLeDonGia]);
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
            frmThemHangVe form = new frmThemHangVe();
            form.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaHangVe form = new frmXoaHangVe();
            form.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachHangVe();
        }

    }
}
