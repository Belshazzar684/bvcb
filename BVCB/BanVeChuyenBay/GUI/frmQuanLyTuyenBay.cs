using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeChuyenBay.GUI
{
    public partial class frmQuanLyTuyenBay : Form
    {
        public frmQuanLyTuyenBay()
        {
            InitializeComponent();
            LoadDanhSachTuyenBay();
        }

        void LoadDanhSachTuyenBay()
        {
            dataGridView1.Rows.Clear();

            DataTable dt = BLL.BLL_TuyenBay.SelectAllTuyenBay();
            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaTuyenBay], row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDi], row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDen]);
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
            frmThemTuyenBay form = new frmThemTuyenBay();
            form.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaTuyenBay form = new frmXoaTuyenBay();
            form.Show();
        }

      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachTuyenBay();
        }
    }
}
