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
    public partial class frmBCDoanhThuNam : Form
    {     

        public frmBCDoanhThuNam()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                int n = 2010 + i;
                cbNam.Items.Add(n);
            }
        }


        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            if (cbNam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm báo cáo!");
            }
            else
            {
                for(int i = 1; i <= 12; i++)
                {
                    DataTable dt = new DataTable();
                    dt = BLL_BCDoanhThuThang.InBCDoanhThuThang( i, int.Parse(cbNam.Text.ToString()));

                    if(dt.Rows.Count != 0)
                    {
                        int DoanhThu = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            DoanhThu += (int)Convert.ToDecimal(row.ItemArray[2]);
                        }

                        if (BLL_BCDoanhThuThang.SelectBCDoanhThuThang(i, int.Parse(cbNam.Text.ToString())).Rows.Count == 0)
                            BLL.BLL_BCDoanhThuThang.InsertBaoCaoDoanhThuThang(i, int.Parse(cbNam.Text.ToString()), dt.Rows.Count, DoanhThu, 0.0f);
                        else
                            BLL.BLL_BCDoanhThuThang.UpdateBaoCaoDoanhThuThang(i, int.Parse(cbNam.Text.ToString()), dt.Rows.Count, DoanhThu, 0.0f);
                    }   
                }


                DataTable temp = new DataTable();
                temp = BLL_BCDoanhThuNam.InBCDoanhThuNam(int.Parse(cbNam.Text.ToString()));

                rptBCDoanhThuNam rp = new rptBCDoanhThuNam();
                rp.SetDataSource(temp);
                crvBCDoanhThuNam.ReportSource = rp;
                crvBCDoanhThuNam.Refresh();
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Tạo báo cáo doanh thu năm");

            }
        }

    }
}
