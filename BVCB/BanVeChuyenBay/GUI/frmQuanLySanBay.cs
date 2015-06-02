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
    public partial class frmQuanLySanBay : Form
    {
        public frmQuanLySanBay()
        {
            InitializeComponent();
            LoadDanhSachSanBay();
        }

        void LoadDanhSachSanBay()
        {
            dataGridView1.Rows.Clear();

            DataTable dt = BLL.BLL_SanBay.SelectAllSanBay();

            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay], row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaSanBay form = new frmXoaSanBay();
            form.Show();

            LoadDanhSachSanBay();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmSuaSanBay form = new frmSuaSanBay();
            form.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemSanBay form = new frmThemSanBay();
            form.Show();

            LoadDanhSachSanBay();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachSanBay();
        }

    }
}
