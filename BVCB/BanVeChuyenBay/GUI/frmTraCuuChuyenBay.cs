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
    public partial class frmTraCuuChuyenBay : Form
    {
        DataTable DSSanBay;
        public frmTraCuuChuyenBay()
        {
            InitializeComponent();

            DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            DataTable lichchuyenbay = BLL.BLL_LichChuyenBay.SelectTraCuuWithDateTime(dtpTuNgay.Value, dtpDenNgay.Value);
            DataRow[] rows = null;

            
            if (cbSanBayDi.Text.Equals(""))
                rows = lichchuyenbay.Select();
            else
                rows = lichchuyenbay.Select("SanBayDi='" + txtTenSanBayDi.Text + "'");

            
            if (rows.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
                return;
            }

            
            for(int i = 0; i < rows.Count(); i++)
            {
                if (cbSanBayDen.Text.Equals("")) 
                    dataGridView1.Rows.Add(rows[i].ItemArray[1], rows[i].ItemArray[2], rows[i].ItemArray[3], rows[i].ItemArray[4], rows[i].ItemArray[7], rows[i].ItemArray[6]);
                else if(rows[i].ItemArray[2].Equals(txtTenSanBayDen.Text))
                    dataGridView1.Rows.Add(rows[i].ItemArray[1], rows[i].ItemArray[2], rows[i].ItemArray[3], rows[i].ItemArray[4], rows[i].ItemArray[7], rows[i].ItemArray[6]);               
            }
        }

        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbSanBayDi.Text.Equals(""))
            {
                DataRow[] row = DSSanBay.Select("MaSanBay='" + cbSanBayDi.Text + "'");

                txtTenSanBayDi.Text = row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
            }
        }

        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbSanBayDen.Text.Equals(""))
            {
                DataRow[] row = DSSanBay.Select("MaSanBay='" + cbSanBayDen.Text + "'");

                txtTenSanBayDen.Text = row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
            }
        }

        private void cbSanBayDi_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDi.Items.Clear();
            txtTenSanBayDi.Text = "";
            foreach (DataRow row in DSSanBay.Rows)
            {
                cbSanBayDi.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
            }
        }

        private void cbSanBayDen_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDen.Items.Clear();
            txtTenSanBayDen.Text = "";
            foreach (DataRow row in DSSanBay.Rows)
            {
                cbSanBayDen.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
            }
        }
    }
}
