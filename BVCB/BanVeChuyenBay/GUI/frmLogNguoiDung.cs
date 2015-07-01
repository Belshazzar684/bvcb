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
    public partial class frmLogNguoiDung : Form
    {
        DataTable dt = new DataTable();
        public frmLogNguoiDung()
        {
            InitializeComponent();
            LoadLog();
        }

        //chức năng: load log người dùng đã có
        void LoadLog()
        {
            dt = BLL.BLL_LogNguoiDung.SelectAllLogNguoDung();
            foreach (DataRow row in dt.Rows)
            {
                dgwLogNguoiDung.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDLogNguoiDung.TenDangNhap], row.ItemArray[(int)Support.BLL.Support.IDLogNguoiDung.ThoiGian], row.ItemArray[(int)Support.BLL.Support.IDLogNguoiDung.HanhDong]);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }
    }
}
