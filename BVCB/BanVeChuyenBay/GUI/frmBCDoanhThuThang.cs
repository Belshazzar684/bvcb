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
using BanVeChuyenBay.BLL;

namespace BanVeChuyenBay.GUI
{
    public partial class frmBCDoanhThuThang : Form
    {
        public frmBCDoanhThuThang()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                int n = 2010 + i;
                cbNam.Items.Add(n);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            if (cbThang.Text == "" || cbNam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tháng và năm báo cáo!");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = BLL_BCDoanhThuThang.InBCDoanhThuThang(int.Parse(cbThang.Text.ToString()), int.Parse(cbNam.Text.ToString()));

                int DoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    DoanhThu += (int)Convert.ToDecimal(row.ItemArray[2]);
                }

                if (BLL_BCDoanhThuThang.SelectBCDoanhThuThang( int.Parse(cbThang.Text), int.Parse(cbNam.Text.ToString())).Rows.Count == 0)
                    BLL.BLL_BCDoanhThuThang.InsertBaoCaoDoanhThuThang(int.Parse(cbThang.Text.ToString()), int.Parse(cbNam.Text.ToString()), dt.Rows.Count, DoanhThu, 0.0f);
                else
                    BLL.BLL_BCDoanhThuThang.UpdateBaoCaoDoanhThuThang(int.Parse(cbThang.Text.ToString()), int.Parse(cbNam.Text.ToString()), dt.Rows.Count, DoanhThu, 0.0f);
                
                rptBCDoanhThuThang rp = new rptBCDoanhThuThang();
                rp.SetDataSource(dt);
                crvBCDoanhThuThang.ReportSource = rp;
                crvBCDoanhThuThang.Refresh();
            }
        }
    }
}
